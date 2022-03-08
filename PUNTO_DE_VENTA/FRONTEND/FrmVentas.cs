using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.POJOS;
using PUNTO_DE_VENTA.BACKEND;
using PUNTO_DE_VENTA.FRONTEND;
using System.Globalization;
using System.Media;

namespace PUNTO_DE_VENTA
{
    public partial class FrmVentas : Form
    {
        static double total = 0;
        public static string fecha_inicial_corte_caja;
        public static string tipo_usuario;
        public static string nombre_usuario;
        public FrmVentas()
        {
            InitializeComponent();
            fecha_inicial_corte_caja = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            clsCierraCaja c = new clsCierraCaja();
            c.Fecha_inicio = fecha_inicial_corte_caja;
            color_grid();
        }
        private void button1_Click(object sender, EventArgs e)
        {


            if (txtCodigo.Text != "")
            {
                dvg_ventas.DataSource = datosTabla();
                //VAMOS A REPRODUCIR NUESTRO BEEP
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = "C:/Users/estar/source/repos/PUNTO_DE_VENTA/resourses/beep.wav";
                sound.Play();
                bloquearCeldas();
                limpiar_campos();
            }

            
        }
        private List<clsProductos> datosTabla()
        {
            try
            {
                //ESTOS SON LOS VALORES QUE INGRESA EL USUARIO Y SE DEBEN 
                //COMPARAR CON LOS DATOS DE LA TABLA PARA AUMENTARLES 
                string codigo_tabla = txtCodigo.Text;
                double cantidad_tabla = Convert.ToDouble(txtCantidad.Text);
                //PARA EL CASO DONDE DONDE NO TIENE DATOS
                if (dvg_ventas.Rows.Count == 0)
                {
                    clsProductos pr = new clsProductos();
                    pr.Codigo = txtCodigo.Text;
                    pr.Cantidad = cantidad_tabla;
                    DAOproductos daop = new DAOproductos();
                    List<clsProductos> lista = new List<clsProductos>();
                    lista = daop.obtenerProducto(pr);
                    // RECUPERAMOS EL VALOR DE ESE PRDUCTO POR DEFECTO SIEMPRE SERÁ SOLO UN 
                    // PRODUCTO
                    total += pr.SubTotal;
                    dvg_ventas.DataSource = lista;
                    foreach (DataGridViewRow x in dvg_ventas.Rows)
                    {
                       
                        clsProductos p = new clsProductos();
                        p.Codigo = x.Cells["Codigo"].Value.ToString();
                        p.NombreProducto = x.Cells["NombreProducto"].Value.ToString();
                        p.Cantidad = Convert.ToDouble(x.Cells["Cantidad"].Value.ToString());
                        p.PrecioUnitario = Convert.ToDouble(x.Cells["PrecioUnitario"].Value.ToString());
                        //subT = p.Cantidad * p.PrecioUnitario;
                        p.SubTotal = Convert.ToDouble(x.Cells["subTotal"].Value.ToString());
                        //p.SubTotal = Convert.ToDouble(x.Cells["SubTotal"].Value.ToString());
                        total += Math.Round(p.Cantidad * p.PrecioUnitario, 2);
                        lista.Add(p);
                    }
                    lblTotal.Text = total.ToString();
                    total = 0;
                    return lista;
                }
                //PARA TODOS LOS CASOS DONDE EL DATAGRID YA TIENE DATOS
                else if(dvg_ventas.Rows.Count > 0)
                {

                    if (comprobar_duplicados_grid())
                    {
                        //SI YA SE ENCUENTRA EN LA LISTA DE COMPRAS ENTONCES 
                        //VAMOS A BUSCAR ESE ARTICULO Y LE AUMENTAREMOS LA CANTIDAD 
                        //NUEVA
                        List<clsProductos> lista = new List<clsProductos>();
                       
                        foreach (DataGridViewRow x in dvg_ventas.Rows)
                        {

                            clsProductos p = new clsProductos();
                            //CUANDO LO ENCONTREMOS VAMOS A AUMENTAR LA CANTIDAD
                            if (codigo_tabla == x.Cells["Codigo"].Value.ToString())
                            {
                                p.Codigo = x.Cells["Codigo"].Value.ToString();
                                p.NombreProducto = x.Cells["NombreProducto"].Value.ToString();
                                p.Cantidad = Math.Round(Convert.ToDouble(x.Cells["Cantidad"].Value.ToString()) + cantidad_tabla,2);
                                p.PrecioUnitario = Convert.ToDouble(x.Cells["PrecioUnitario"].Value.ToString());
                                //subT = p.Cantidad * p.PrecioUnitario;
                                p.SubTotal = Math.Round(p.Cantidad * p.PrecioUnitario,2);
                                //p.SubTotal = Convert.ToDouble(x.Cells["SubTotal"].Value.ToString());
                                total += p.SubTotal;
                                
                            }
                            //SINO ES EL PRODUCTO QUE BUSCAMOS NO LE HACEMOS NADA 
                            //Y SE AGREGA NORMAL
                            else
                            {

                                p.Codigo = x.Cells["Codigo"].Value.ToString();
                                p.NombreProducto = x.Cells["NombreProducto"].Value.ToString();
                                p.Cantidad = Convert.ToDouble(x.Cells["Cantidad"].Value.ToString());
                                p.PrecioUnitario = Convert.ToDouble(x.Cells["PrecioUnitario"].Value.ToString());
                                //subT = p.Cantidad * p.PrecioUnitario;
                                p.SubTotal = Convert.ToDouble(x.Cells["subTotal"].Value.ToString());
                                //p.SubTotal = Convert.ToDouble(x.Cells["SubTotal"].Value.ToString());
                                total += Math.Round(p.Cantidad * p.PrecioUnitario, 2);
                            }
                            lista.Add(p);
                        }
                        lblTotal.Text = total.ToString();
                        total = 0;
                        return lista;
                    }
                    else
                    {
                        clsProductos pr = new clsProductos();
                        pr.Codigo = txtCodigo.Text;
                        pr.Cantidad = Convert.ToDouble(txtCantidad.Text);

                        DAOproductos daop = new DAOproductos();
                        List<clsProductos> lista = new List<clsProductos>();
                        lista = daop.obtenerProducto(pr);
                        // RECUPERAMOS EL VALOR DE ESE PRDUCTO POR DEFECTO SIEMPRE SERÁ SOLO UN 
                        // PRODUCTO
                        //PARA RECUPERAR ESE VALOR SIN PERDERLO CREAREMOS UN GRID AUX
                        grid_aux.DataSource = null;
                        grid_aux.DataSource = lista;
                        //AHORA RECORREMOS ESE GRID Y OBTENEMOS EL SUBTOTAL DE ESE PRODUCTO PARA AÑADIRLO AL TOTAL DE VENTA
                        double sub = 0;
                        foreach(DataGridViewRow temp in grid_aux.Rows)
                        {
                             sub = Math.Round(Convert.ToDouble(temp.Cells["subTotal"].Value.ToString()) 
                                        * Convert.ToDouble(temp.Cells["Cantidad"].Value.ToString()),2);
                        }
                        total += sub;

                        foreach (DataGridViewRow x in dvg_ventas.Rows)
                        {

                            clsProductos p = new clsProductos();
                            p.Codigo = x.Cells["Codigo"].Value.ToString();
                            p.NombreProducto = x.Cells["NombreProducto"].Value.ToString();
                            p.Cantidad = Convert.ToDouble(x.Cells["Cantidad"].Value.ToString());
                            p.PrecioUnitario = Convert.ToDouble(x.Cells["PrecioUnitario"].Value.ToString());
                            //subT = p.Cantidad * p.PrecioUnitario;
                            p.SubTotal = Convert.ToDouble(x.Cells["subTotal"].Value.ToString());
                            //p.SubTotal = Convert.ToDouble(x.Cells["SubTotal"].Value.ToString());
                            total += Math.Round(p.Cantidad * p.PrecioUnitario,2);
                            lista.Add(p);
                        }
                        lblTotal.Text = total.ToString();
                        total = 0;
                        return lista;
                    }
                    
                    
                   
                }
               
                return null;
            }
            catch (Exception e) { return null; }

        }
        private bool comprobar_duplicados_grid()
        {
            bool bandera = false;
            //BUSCAMOS EL PRODUCTO
            string codigo_tabla = txtCodigo.Text;
            foreach (DataGridViewRow x in dvg_ventas.Rows)
            {

                if (codigo_tabla == x.Cells["codigo"].Value.ToString())
                {
                    bandera = true;
                }


            }
            return bandera;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<clsProductos> lista = new List<clsProductos>();
                //RECUPERAMOS EL SELECCIONADO PARA ELIMINARLO
                int index = dvg_ventas.SelectedRows[0].Index;
                lblTotal.Text = "0";
                foreach (DataGridViewRow x in dvg_ventas.Rows)
                {
                    // SI NO ESTA SELECCIONADO ENTONCES LO AGREGAMOS A NUESTRA LISTA
                    if (x.Index != index)
                    {
                        clsProductos p = new clsProductos();

                        p.Codigo = x.Cells["Codigo"].Value.ToString();
                        p.NombreProducto = x.Cells["NombreProducto"].Value.ToString();
                        p.Cantidad = Convert.ToDouble(x.Cells["Cantidad"].Value.ToString());
                        p.PrecioUnitario = Convert.ToDouble(x.Cells["PrecioUnitario"].Value.ToString());
                        p.SubTotal = Convert.ToDouble(x.Cells["SubTotal"].Value.ToString());
                        total += p.Cantidad * p.PrecioUnitario;
                        lista.Add(p);
                    }
                   
                }
                lblTotal.Text = total.ToString();
                total = 0;
                dvg_ventas.DataSource = lista;
                bloquearCeldas();
            }catch(Exception ex)
            {

            }
            

        }
        private void bloquearCeldas()
        {
            
            foreach (DataGridViewRow x in dvg_ventas.Rows)
            {
                x.Cells["Codigo"].ReadOnly = true;
                x.Cells["NombreProducto"].ReadOnly = true;
                x.Cells["PrecioUnitario"].ReadOnly = true;
                x.Cells["Cantidad"].ReadOnly = true;
                x.Cells["subTotal"].ReadOnly = true;
                
            }

            
            
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            if (dvg_ventas.Rows.Count > 0)
            {
                // RESCATAMOS EL TOTAL DE LA OPERACION
                double total = double.Parse(lblTotal.Text);

                //MOSTRAMOS LA VENTANA DE COBRO PARA FINALIZAR O 
                //DECLINAR LA VENTA
                FrmCobro cobro = new FrmCobro(dvg_ventas);
                cobro.Show();
                //LE MOSTRAMOS EL CAMBIO O EN SU DEFECTO 
                //NEGAMOS LA OPERACION POR FALTA DE DINERO
                cobro.total_a_pagar(lblTotal.Text);
                //LIMPIAMOS LO CAMPOS DE ESTA VENTANA
                dvg_ventas.DataSource = null;
                lblTotal.Text = "0";

            }
            
            
        }
        
       
        private void limpiar_campos()
        {
            txtCodigo.Text = "";
            txtCantidad.Text = "1";
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //METODO PARA CUANDO MODIFICA LA CANTIDAD DESDE EL GRID
        private void dvg_ventas_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SI PRESIONA LA TECLA ENTER ENTONCES CAMBIA LOS DATOS
            if (e.KeyChar == 13)
            {
                dvg_ventas.DataSource = datosTabla();
                bloquearCeldas();
                limpiar_campos();
            }
        }

        //METODO PARA CUANDO PRESIONA UNA TECLA EN EL TXTCODIGO
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //CUANDO PRESIONE ENTER AGREGARA EL PRODUCTO 
            //O CAMBIARA LA CANTIDAD DEL MISMO
            if (e.KeyChar == 13 && txtCodigo.Text != "")
            {
                
                dvg_ventas.DataSource = datosTabla();
                
                bloquearCeldas();
                limpiar_campos();
                //quitar sonido al textbox 
                e.Handled = true;
                //VAMOS A REPRODUCIR NUESTRO BEEP
                SoundPlayer sound = new SoundPlayer();
                sound.SoundLocation = "C:/Users/estar/source/repos/PUNTO_DE_VENTA/resourses/beep.wav";
                sound.Play();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnVentas_Paint(object sender, PaintEventArgs e)
        {

        }
        private void color_grid()
        {
            dvg_ventas.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dvg_ventas.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#20A022");
            dvg_ventas.EnableHeadersVisualStyles = false;
            dvg_ventas.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 15);
            

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {

        }

        private void dvg_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
