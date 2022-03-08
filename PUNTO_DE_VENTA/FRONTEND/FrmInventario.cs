using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.BACKEND;
using PUNTO_DE_VENTA.POJOS;
using PUNTO_DE_VENTA.FRONTEND;

namespace PUNTO_DE_VENTA
{
    public partial class FrmInventario : Form
    {
        public int bandera = 0;
        public FrmInventario()
        {
            InitializeComponent();
            color_grid();
        }

        private void btn_todo_Click(object sender, EventArgs e)
        {
            
            if(bandera == 0)
            {
                DAOproductos daop = new DAOproductos();
                dtg_stock.DataSource = daop.obtenerTodosLosProductos();
                agregar_columnas();
            }
            else
            {
                quitar_columnas();
                DAOproductos daop = new DAOproductos();
                dtg_stock.DataSource = daop.obtenerTodosLosProductos();
                agregar_columnas();
            }
        }

        private void btn_codigo_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text != "")
            {
                if(bandera == 0)
                {
                    DAOproductos daop = new DAOproductos();
                    clsProductos p = new clsProductos();
                    p.Codigo = txtCodigo.Text;

                    if (daop.obtenerUnProducto(p))
                    {
                        dtg_stock.DataSource = daop.consultarProducto(p);
                        agregar_columnas();

                    }
                    else
                    {
                        MessageBox.Show("El producto no se encuentra en la base de datos");
                    }
                }
                else
                {
                    DAOproductos daop = new DAOproductos();
                    clsProductos p = new clsProductos();
                    p.Codigo = txtCodigo.Text;

                    if (daop.obtenerUnProducto(p))
                    {
                        quitar_columnas();
                        dtg_stock.DataSource = daop.consultarProducto(p);
                        agregar_columnas();

                    }
                    else
                    {
                        MessageBox.Show("El producto no se encuentra en la base de datos");
                    }
                }
                
                txtCodigo.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un codigo");
            }
            resetear_campos();
        }

        private void btn_nombre_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                if(bandera == 0)
                {
                    DAOproductos daop = new DAOproductos();
                    clsProductos p = new clsProductos();
                    p.NombreProducto = txtNombre.Text;
                    if (daop.buscarPorNombre(p))
                    {
                        
                        dtg_stock.DataSource = daop.obtenerProductoPorNombre(p);
                        agregar_columnas();
                    }
                    else
                    {
                        MessageBox.Show("El producto no se encuentra en la base de datos");
                    }
                }
                else
                {
                    DAOproductos daop = new DAOproductos();
                    clsProductos p = new clsProductos();
                    p.NombreProducto = txtNombre.Text;
                    if (daop.buscarPorNombre(p))
                    {
                        quitar_columnas();
                        dtg_stock.DataSource = daop.obtenerProductoPorNombre(p);
                        agregar_columnas();
                    }
                    else
                    {
                        MessageBox.Show("El producto no se encuentra en la base de datos");
                    }
                }
                
                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un nombre valido");
            }
            resetear_campos();
        }
        

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "BUSCAR POR CODIGO")
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.Green;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                txtCodigo.Text = "BUSCAR POR CODIGO";
               
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "BUSCAR POR NOMBRE";
                
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "BUSCAR POR NOMBRE")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Green;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTAS SEGURO DE ELIMINAR EL PRODUCTO(S)?",
                               "ADVERTENCIA",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //RESCATAR LOS VALORES DE LA CELDA SELECCIONADA
                try
                {
                    List<clsProductos> lista = new List<clsProductos>();
                    //RECUPERAMOS EL SELECCIONADO PARA ELIMINARLO
                    int index = dtg_stock.SelectedRows[0].Index;
                    
                    foreach (DataGridViewRow row in dtg_stock.Rows)
                    {
                        // SI ESTA SELECCIONADO LO ELIMINAMOS
                        if (row.Index == index)
                        {
                            clsProductos p = new clsProductos();

                            p.Codigo = row.Cells["Codigo"].Value.ToString();
                            p.NombreProducto = row.Cells["NombreProducto"].Value.ToString();
                            DAOproductos daop = new DAOproductos();
                            if (daop.deleteProduct(p))
                            {
                                
                                MessageBox.Show("PRODUCTO: " + p.NombreProducto + " AH SIDO ELIMINADO");
                            }
                            else
                            {
                                MessageBox.Show("INTENTE NUEVAMENTE");
                            }

                        }

                    }

                }
                catch (Exception ex)
                {

                }
            }
 
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTAS SEGURO DE MODIFICAR EL PRODUCTO(S)?",
                               "ADVERTENCIA",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //RESCATAR LOS VALORES DE LA CELDA SELECCIONADA
                try
                {
                    List<clsProductos> lista = new List<clsProductos>();
                    //RECUPERAMOS EL SELECCIONADO PARA ELIMINARLO
                    int index = dtg_stock.SelectedRows[0].Index;

                    foreach (DataGridViewRow row in dtg_stock.Rows)
                    {
                        // SI ESTA SELECCIONADO LO ELIMINAMOS
                        if (row.Index == index)
                        {
                            //RESCATAMOS EL PRODUCTOS SELECIONADOS
                            clsProductos p = new clsProductos();

                            p.Codigo = row.Cells["Codigo"].Value.ToString();
                            p.NombreProducto = row.Cells["NombreProducto"].Value.ToString();
                            p.Cantidad = Convert.ToDouble(row.Cells["Cantidad"].Value.ToString());
                            p.PrecioUnitario = Convert.ToDouble(row.Cells["PrecioUnitario"].Value.ToString());
                            p.SubTotal = Convert.ToDouble(row.Cells["SubTotal"].Value.ToString());
                            DAOproductos daop = new DAOproductos();

                            //AHORA CON LOS DATOS SE LOS PASAMOS AL SIGUIENTE FORMULARIO
                            FrmModificarProducto vModificar = new FrmModificarProducto();
                            //le pasamos los parametros al metodo correspondiente
                            vModificar.ingresar_datos(p.Codigo, p.NombreProducto, p.Cantidad.ToString(), p.PrecioUnitario.ToString());
                            //mostramos la ventana con los datos
                            vModificar.Show();
                            
                        }

                    }

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_agregar_producto vAgregar = new Frm_agregar_producto();
            vAgregar.Show();
            
        }

        private void dtg_stock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void color_grid()
        {
            dtg_stock.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dtg_stock.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#20A022");
            dtg_stock.EnableHeadersVisualStyles = false;
            dtg_stock.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);


        }
        private void resetear_campos()
        {
            txtNombre.Text = "BUSCAR POR NOMBRE";
            txtCodigo.Text = "BUSCAR POR CODIGO";
        }

        //AGREGAMOS COLUMNAS
        private void agregar_columnas()
        {
            //boton de modificar
            DataGridViewButtonColumn btn_modificar = new DataGridViewButtonColumn();
            btn_modificar.Name = "btn_modi";
            btn_modificar.Text = "Modificar";
            btn_modificar.HeaderText = "Accion";
            btn_modificar.DefaultCellStyle.BackColor = Color.Green;
            btn_modificar.UseColumnTextForButtonValue = true;
            dtg_stock.Columns.Add(btn_modificar);
            //boton de eliminar
            DataGridViewButtonColumn btn_eliminar = new DataGridViewButtonColumn();
            btn_eliminar.Name = "btn_modi";
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.HeaderText = "Accion";
            btn_eliminar.DefaultCellStyle.BackColor = Color.Red;
            btn_eliminar.UseColumnTextForButtonValue = true;    
            dtg_stock.Columns.Add(btn_eliminar);
            bandera++;
        }
        //QUITAMOS COLUMNA
        private void quitar_columnas()
        {
            dtg_stock.Columns.RemoveAt(6);
            dtg_stock.Columns.RemoveAt(5);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnInventario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtg_stock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                //RESCATAR LOS VALORES DE LA CELDA SELECCIONADA
                try
                {
                    List<clsProductos> lista = new List<clsProductos>();
                    //RECUPERAMOS EL SELECCIONADO PARA ELIMINARLO
                    int index = e.RowIndex;

                    foreach (DataGridViewRow row in dtg_stock.Rows)
                    {
                        // SI ESTA SELECCIONADO LO ELIMINAMOS
                        if (row.Index == index)
                        {
                            //RESCATAMOS EL PRODUCTOS SELECIONADOS
                            clsProductos p = new clsProductos();

                            p.Codigo = row.Cells["Codigo"].Value.ToString();
                            p.NombreProducto = row.Cells["NombreProducto"].Value.ToString();
                            p.Cantidad = Convert.ToDouble(row.Cells["Cantidad"].Value.ToString());
                            p.PrecioUnitario = Convert.ToDouble(row.Cells["PrecioUnitario"].Value.ToString());
                            p.SubTotal = Convert.ToDouble(row.Cells["SubTotal"].Value.ToString());
                            DAOproductos daop = new DAOproductos();

                            //AHORA CON LOS DATOS SE LOS PASAMOS AL SIGUIENTE FORMULARIO
                            FrmModificarProducto vModificar = new FrmModificarProducto();
                            //le pasamos los parametros al metodo correspondiente
                            vModificar.ingresar_datos(p.Codigo, p.NombreProducto, p.Cantidad.ToString(), p.PrecioUnitario.ToString());
                            //mostramos la ventana con los datos
                            vModificar.Show();

                        }

                    }

                }
                catch (Exception ex)
                {

                }
            }
            if(e.ColumnIndex == 6)
            {
                //RESCATAR LOS VALORES DE LA CELDA SELECCIONADA
                try
                {
                    List<clsProductos> lista = new List<clsProductos>();
                    //RECUPERAMOS EL SELECCIONADO PARA ELIMINARLO
                    int index = e.RowIndex;

                    foreach (DataGridViewRow row in dtg_stock.Rows)
                    {
                        // SI ESTA SELECCIONADO LO ELIMINAMOS
                        if (row.Index == index)
                        {
                            clsProductos p = new clsProductos();

                            p.Codigo = row.Cells["Codigo"].Value.ToString();
                            p.NombreProducto = row.Cells["NombreProducto"].Value.ToString();
                            DAOproductos daop = new DAOproductos();
                            if (daop.deleteProduct(p))
                            {

                                MessageBox.Show("PRODUCTO: " + p.NombreProducto + " AH SIDO ELIMINADO");
                            }
                            else
                            {
                                MessageBox.Show("INTENTE NUEVAMENTE");
                            }

                        }

                    }

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
