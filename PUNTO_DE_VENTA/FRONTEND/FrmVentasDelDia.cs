using MySql.Data.MySqlClient;
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

namespace PUNTO_DE_VENTA.FRONTEND
{
    public partial class FrmVentasDelDia : Form
    {
        public FrmVentasDelDia()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //traemos todos los datos de las ordenes del dia de hoy
                string fecha_de_hoy= DateTime.Now.ToString("yyyy-MM-dd");
                //EXTRAEMOS LOS DATOS NECESARIOS
                string dia = fecha_de_hoy.Substring(8);
                string mes= fecha_de_hoy.Substring(5,2);
                string anio= fecha_de_hoy.Substring(0,4);
                //CREAMOS LA CONSULTA DE LAS ORDENES DEL HOY
                string select = "Select * from orders where year(orderDate) = @year and month(orderDate) = @month and day(orderDate)= @day;";
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("?year", anio);
                comando.Parameters.AddWithValue("?month", mes);
                comando.Parameters.AddWithValue("?day", dia);
                DataTable tabla = clsConexion.ejecutarConsulta(comando);
                //CREAMOS LA LISTA PARA PASARLA AL DATAGRID
                List<clsOrden> lista = new List<clsOrden>();
                foreach(DataRow filas in tabla.Rows)
                {
                    //OBTENEMOS TODOS LOS DATOS DE LA ORDEN Y LA AGREGAMOS A LA LISTA
                    clsOrden orden = new clsOrden();
                    orden.OrderID = Convert.ToInt32(filas[0].ToString());
                    orden.Fecha = filas[1].ToString();
                    orden.Total = Convert.ToDouble(filas[2].ToString());
                    orden.Empleado = Convert.ToInt32(filas[3].ToString());
                    lista.Add(orden);
                }
                dataGridView1.DataSource = lista;
                //LE HACEMOS LA SUMA PORQUE QUE FLOJERA QUE SAQUEN SU CALCU
                
                string monto_del_dia = "select round(sum(freight),2) from orders where year(orderDate) = @year and month(orderDate) = @month and day(orderDate)= @day;";
                comando = new MySqlCommand(monto_del_dia);
                comando.Parameters.AddWithValue("?year", anio);
                comando.Parameters.AddWithValue("?month", mes);
                comando.Parameters.AddWithValue("?day", dia);
                DataTable DT_monto = clsConexion.ejecutarConsulta(comando);
                foreach (DataRow filas in DT_monto.Rows)
                {
                    lbMontoDelDia.Text = filas[0].ToString();
                }
                
            }
            catch(Exception ex)
            {

            }
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
