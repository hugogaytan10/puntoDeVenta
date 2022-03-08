using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using PUNTO_DE_VENTA.FRONTEND;
using PUNTO_DE_VENTA.POJOS;

namespace PUNTO_DE_VENTA
{
    public partial class Frm_Cajero : Form
    {
        string tipo_usuario = "";
        public Frm_Cajero()
        {
            InitializeComponent();
            
        }
      
        
       
        public void tipo_userio(string tipo)
        {
            this.tipo_usuario = tipo;
            //DEPENDIENDO EL TIPO DE USUARIO BLOQUEAMOS CIERTAS FUNCIONES 
            // 1 = ADMINISTRADOR, TIENE TODAS LAS FUNCIONES
            if (tipo_usuario == "1")
            {
                FrmVentas.tipo_usuario = "0";
            }
            //TIPO 2 = CAJERO 
            else if(tipo_usuario == "2")
            {
                btn_inventario.Enabled = false;
               
                FrmVentas.tipo_usuario = "0";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ventanas_nuevas(new FrmVentas());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ventanas_nuevas(object ventana)
        {
            //SI CONTIENE ALGO EL PANEL LO LIMPIAMOS
            if (this.pnContenedor.Controls.Count > 0)
            {
                this.pnContenedor.Controls.RemoveAt(0);
                Form v = ventana as Form;
                v.TopLevel = false;
                v.Dock = DockStyle.Fill;
                this.pnContenedor.Controls.Add(v);
                this.pnContenedor.Tag = v;
                v.Show();
            }
            //SINO TIENE NADA LO AGREGAMOS NORMALMENTE
            else
            {
                Form v = ventana as Form;
                v.TopLevel = false;
                v.Dock = DockStyle.Fill;
                this.pnContenedor.Controls.Add(v);
                this.pnContenedor.Tag = v;
                v.Show();
            }
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTAS SEGURO DE CAMBIAR DE VENTANA?",
                               "ADVERTENCIA",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                
                ventanas_nuevas(new FrmInventario());
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿ESTAS SEGURO DE CAMBIAR DE VENTANA?",
                               "ADVERTENCIA",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                ventanas_nuevas(new Frm_agregar_producto());
            }
            
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto v = new FrmBuscarProducto();
            v.Show();
            
        }

        private void btn_cierre_caja_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿ESTAS SEGURO DE CAMBIAR DE VENTANA?",
                               "ADVERTENCIA",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                try
                {
                    //MOSTRAMOS LA VENTANA EMERGENTE PARA AUTORIZAR ESTA VENTANA
                    Frm_validar_usuario validar = new Frm_validar_usuario();
                    validar.ShowDialog();
                    //SI VALIDA EL USUARIO Y ES ADMINISTRADOR ENTONCES PUEDE PASAR HACER CORTE 
                    if (FrmVentas.tipo_usuario == "1")
                    {
                        //PASAMOS LA HORA DE INICIO DE ESTE CORTE DE CAJA
                        string fecha_inicio = FrmVentas.fecha_inicial_corte_caja;
                        FrmCierreCaja cierre = new FrmCierreCaja();
                        ventanas_nuevas(cierre);
                        cierre.dinero(fecha_inicio);
                        //LE DEVOLVEMOS UN VALOR CERO PARA QUE NO ENTRE SIEMPRE AQUI SINO QUE HAGA LA CONSULTA
                        FrmVentas.tipo_usuario = "0";
                    }
                    
                    
                    
                    

                }
                catch (Exception ex) { }
            }
            
            
        }

        private void iconButton4_MouseHover(object sender, EventArgs e)
        {
            iconButton4.ForeColor = Color.FromArgb(255,255,255);
            iconButton4.IconColor = Color.White;
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)
        {
            iconButton4.ForeColor = Color.Green;
            iconButton4.IconColor = Color.Green;
        }

        private void btn_ventas_MouseHover(object sender, EventArgs e)
        {
            btn_ventas.ForeColor = Color.FromArgb(255, 255, 255);
            btn_ventas.IconColor = Color.White;
        }

        private void btn_ventas_MouseLeave(object sender, EventArgs e)
        {
            btn_ventas.ForeColor = Color.Green;
            btn_ventas.IconColor = Color.Green;
        }

        private void btn_inventario_MouseHover(object sender, EventArgs e)
        {
            btn_inventario.ForeColor = Color.FromArgb(255, 255, 255);
            btn_inventario.IconColor = Color.White;
        }

        private void btn_inventario_MouseLeave(object sender, EventArgs e)
        {
            btn_inventario.ForeColor = Color.Green;
            btn_inventario.IconColor = Color.Green;
        }

       

        private void btn_cierre_caja_MouseHover(object sender, EventArgs e)
        {
            btn_cierre_caja.ForeColor = Color.FromArgb(255, 255, 255);
            btn_cierre_caja.IconColor = Color.White;
        }

        private void btn_cierre_caja_MouseLeave(object sender, EventArgs e)
        {
            btn_cierre_caja.ForeColor = Color.Green;
            btn_cierre_caja.IconColor = Color.Green;
        }

        private void Frm_Cajero_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Frm_Cajero_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    
}
