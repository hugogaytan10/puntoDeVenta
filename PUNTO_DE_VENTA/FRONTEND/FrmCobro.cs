using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUNTO_DE_VENTA.POJOS;
using PUNTO_DE_VENTA.BACKEND;
using System.Globalization;

namespace PUNTO_DE_VENTA.FRONTEND
{
    public partial class FrmCobro : Form
    {
        
        public FrmCobro()
        {
            InitializeComponent();
            
        }
        public FrmCobro(DataGridView dg)
        {
            InitializeComponent();
            //PASAMOS NUESTRA DATAGRID DE LA VENTANA DE VENTAS 
            //PORQUE SI SE REALIZA LA COMPRA SERÁ EN ESTA VENTANA
            foreach (DataGridViewRow filas in dg.Rows)
            {
                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[filas.Index].Cells["Codigo"].Value = filas.Cells[0].Value.ToString();
                dataGridView1.Rows[filas.Index].Cells["NombreProducto"].Value = filas.Cells[1].Value.ToString();
                dataGridView1.Rows[filas.Index].Cells["Cantidad"].Value = filas.Cells[2].Value.ToString();
                dataGridView1.Rows[filas.Index].Cells["PrecioUnitario"].Value = filas.Cells[3].Value.ToString();
                dataGridView1.Rows[filas.Index].Cells["SubTotal"].Value = filas.Cells[4].Value.ToString();
            }
           

        }

        private void pnCobro_Paint(object sender, PaintEventArgs e)
        {

        }
        public void total_a_pagar(string total)
        {
            lblCobrar.Text = total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SI PAGA CON SUFICIENTE DINERO ENTONCES ENTRA AL IF 
            if(cobro() == 1)
            {
                //PROCEDEMOS A INSERTARLO EN LA BD
                //Y CREACION DE TICKET AL USIARO Y UNA COPIA PARA NOSOTROS.
                transaccion_final();
                this.Close();
            }
        }
        public int cobro()
        {
            try
            {
                //RETORNAMOS EL CAMBIO Y LO REDONDEAMOS A DOS DECIMALES
                double cambio = double.Parse(txtRecibido.Text) - double.Parse(lblCobrar.Text);
                cambio = Math.Round(cambio, 2);
                if(cambio < 0)
                {
                    MessageBox.Show("NO ES POSIBLE REALIZAR LA OPERACIÓN");

                    return 2;
                }
                else
                {

                    MessageBox.Show(cambio.ToString(),"CAMBIO");
                    return 1;
                }
                
            }
            catch (Exception ex) { return 0; }
        }
        public void transaccion_final()
        {
            
            clsTransacciones clsT = new clsTransacciones();
            double total = Convert.ToDouble(lblCobrar.Text);

            //VAMOS A RESCATAR EL NOMBRE DEL USUARIO (real)
            clUsuario usuario = new clUsuario();
            usuario.UserName = FrmVentas.nombre_usuario;
            usuario.Tipo_usuario = FrmVentas.tipo_usuario;
            //hacemos la consulta del nombre 
            DAOusuario daoUser = new DAOusuario();
            DataTable nombre_empleado = daoUser.consultar_nombre(usuario);
            string nombre_empleado_ticket = "";
            //recuperamos el valor en la variable recien creada
            foreach (DataRow row in nombre_empleado.Rows)
            {
                nombre_empleado_ticket = row[0].ToString();
            }
            //RECUPERAMOS EL ID DEL EMPLEADO
            DataTable id_empleado = daoUser.consultar_id_empleado(nombre_empleado_ticket);
            int ID_empleado = 0;
            foreach (DataRow row in id_empleado.Rows)
            {
                ID_empleado = Convert.ToInt32(row[0].ToString());
            }
            //PASAMOS LOS DATOS DEL DATA GRID PARA QUE PROCEDA CON LA 
            //TRANSACCION DE LA VENTA
            if (clsT.transaccionFinOperacion(dataGridView1, total, ID_empleado, 0))
            {
                


                /*ESTE TICKET FUNCIONES ES DE LA CLASE clsTicket pero intentaré otro
                 * 
                 * 
                //CREACION DE TICKET
                clsCrearTicket ticket = new clsCrearTicket();
                DAOtransaccion daoT = new DAOtransaccion();
                clsProductos p;
                ticket.empresa = "NOMBRE DE LA EMPRESA";
                ticket.direccion = "DIRECCION DE LA EMPRESA";
                ticket.telefeno = "TELEFONO";
                //ticket.logo = Image.FromFile(@"C:\Users\estar\source\repos\PUNTO_DE_VENTA\resourses\5.png");
                ticket.logo = pLogo.Image;
                ticket.total = double.Parse(lblCobrar.Text);
                //sacar los datos del grid
                //LE PASAMOS TODOS LOS PRODUCTOS AL TICKET 
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    p = new clsProductos();
                    p.NombreProducto = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    p.PrecioUnitario = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    p.Cantidad = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    p.SubTotal = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    ticket.listaP.Add(p);
                }
                //OBTENEMOS LA ORDEN PARA PONERLO EN TICKET Y NOMBRE DE TICKET
                string nombre = daoT.orden_actual();
                ticket.nombreTicket = nombre;
                ticket.dinero_recibido = double.Parse(txtRecibido.Text);
                ticket.imprimir(ticket);
                //ticket.inicio();


                */


               

                //INTENTO DE TICKET DOS

                clsTicket ticket = new clsTicket();
                //OBTENEMOS LA ORDEN PARA PONERLO EN TICKET Y NOMBRE DE TICKET
                DAOtransaccion daoT = new DAOtransaccion();
                string venta_numero = daoT.orden_actual();
                ticket.nombreTicket = venta_numero;

                //ticket.HeaderImage = pLogo.Image;
                ticket.AddHeaderLine("Super Mercado");
                ticket.AddSubHeaderLine("Venta: " + venta_numero);
                ticket.AddSubHeaderLine("Lo atendió: " + nombre_empleado_ticket);
                ticket.AddSubHeaderLine("DIRECCION DE LA EMPRESA");
                ticket.AddSubHeaderLine("TELEFONO");
                ticket.AddSubHeaderLine("CANT  DESCRIPCION      IMPORTE");
                //ticket.AddItem("5", "Peras", "1.99");
                //ticket.AddItem("1", "Aguacate", "1.00");

                //LE PASAMOS TODOS LOS PRODUCTOS AL TICKET 
                clsProductos p;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    p = new clsProductos();
                    p.NombreProducto = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    p.PrecioUnitario = Double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString(), CultureInfo.InvariantCulture);
                    p.Cantidad = Double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString(), CultureInfo.InvariantCulture);
                    p.SubTotal = Double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString(), CultureInfo.InvariantCulture);

                    ticket.AddItem(p.Cantidad.ToString(),p.NombreProducto,p.PrecioUnitario.ToString());
                }

                //SACAMOS EL IVA DE LA VENTA
                double iva = total / 1.16;
                iva = Math.Round((iva - total), 2);
                if (iva < 0)
                {
                    iva = iva * -1;
                }

                ticket.AddTotal("DINERO RECIBIDO:", txtRecibido.Text);
                ticket.AddTotal("TOTAL", total.ToString());
                ticket.AddIva("IVA:", iva);
                ticket.AddTotal("SU CAMBIO:", Math.Round((double.Parse(txtRecibido.Text) - double.Parse(lblCobrar.Text)),2).ToString());
                ticket.AddFooterLine("Gracias por su preferencia...");
                //ticket.PrintTicket("80mm Series Printer");
                ticket.PrintTicket();



                dataGridView1.DataSource = null;
              
                
            }
            else
            {
                MessageBox.Show("operación fallida");
               
            }
        }

        private void pb20_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 20;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "20";
            }
        }

        private void pb50_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 50;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "50";
            }
        }

        private void pb500_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 500;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "500";
            }
        }

        private void pb100_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 100;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "100";
            }
        }

        private void pb200_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 200;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "200";
            }
        }

        private void pb1000_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 1000;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "1000";
            }
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 1;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "1";
            }
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 2;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "2";
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 5;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "5";
            }
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            if (txtRecibido.Text != "")
            {
                int dinero = Convert.ToInt32(txtRecibido.Text);
                dinero += 10;
                txtRecibido.Text = dinero.ToString();
            }
            else
            {

                txtRecibido.Text = "10";
            }
        }
    }
}
