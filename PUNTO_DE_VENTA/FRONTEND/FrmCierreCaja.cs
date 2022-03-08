using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PUNTO_DE_VENTA.BACKEND;
using PUNTO_DE_VENTA.POJOS;

namespace PUNTO_DE_VENTA.FRONTEND
{
    public partial class FrmCierreCaja : Form
    {
        //VARIABLE CREADA PARA DETERMINAR LA ULTIMA HORA EN QUE INGRESO ESTE CAJERO
        static string fecha_final_corte_caja;
        public FrmCierreCaja()
        {
            InitializeComponent();
            fecha_final_corte_caja = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        internal void dinero(string fecha_inicio)
        {
            //CONSULTA PARA OBTENER EL TOTAL DE LO VENDIDO EN EL TRASNCURSO DE SU TURNO
            string select = "select sum(freight) from orders where orderDate between @fechaInicio and @fechaFin; ";
            MySqlCommand comando = new MySqlCommand(select);
            comando.Parameters.AddWithValue("?fechaInicio", fecha_inicio);
            comando.Parameters.AddWithValue("?fechaFin",fecha_final_corte_caja);

            

            //OBTENEMOS EL DINERO ACUMULADO EN ESE TURNO
            //Y LO INGRESAMOS EN LA VENTANA DE CIERRE DE CAJA
            DataTable tabla = clsConexion.ejecutarConsulta(comando);
            foreach(DataRow recorrido in tabla.Rows)
            {
                lblDineroAcumulado.Text = recorrido[0].ToString();
            }

            //INSERTAREMOS EL MONTO QUE SE VENDIO EN ESTE TURNO PARA LLEVAR UN CONTROL DE LOS 
            //ARQUEOS 
            string insert = "insert into Arqueos(monto, fecha) values(@Monto,@Fecha);";
            comando = new MySqlCommand(insert);
            comando.Parameters.AddWithValue("Monto",Convert.ToDouble(lblDineroAcumulado.Text));
            comando.Parameters.AddWithValue("Fecha",fecha_final_corte_caja);
            clsConexion.ejecutarSentencia(comando);
        }

        private void pnCierreCaja_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //hacemos la operacion del cierre de caja 
                double dinero_acumulado = double.Parse(lblDineroAcumulado.Text);
                double dinero_inicial = double.Parse(txtSaldoInicial.Text);
                double dinero_final = dinero_acumulado + dinero_inicial;
                lblSaldoReal.Text = dinero_final.ToString();
                //activamos la bandera para que pueda cerrar la caja
                btn_cerrar_caja.Enabled = true;
            }
            catch (Exception ex) { }
        }

        private void btn_cerrar_caja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ventas_dia_Click(object sender, EventArgs e)
        {
            FrmVentasDelDia ventasDia = new FrmVentasDelDia();
            ventasDia.Show();
        }
    }
}
