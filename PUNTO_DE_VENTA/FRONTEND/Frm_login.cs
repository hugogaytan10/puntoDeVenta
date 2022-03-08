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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE DE USUARIO")
            {
                txtNombre.Text = "";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE DE USUARIO";
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if(txtContrasenia.Text == "CONTRASEÑA")
            {
                txtContrasenia.Text = "";
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "CONTRASEÑA";
                txtContrasenia.UseSystemPasswordChar = false;
            }
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS LOS DATOS Y LO BUSCAMOS EN LA BD 
            string nombre = txtNombre.Text;
            string contra = txtContrasenia.Text;
            //si esta vacio algun campo lanzamos un mensaje
            if(nombre == "NOMBRE DE USUARIO" || contra == "CONTRASEÑA")
            {
                MessageBox.Show("INGRESE DATOS VALIDOS");
            }
            else
            {
                //RECUPERAMOS LOS DATOS DE USUARIO 
                clUsuario usuario = new clUsuario();
                usuario.Contrasenia = contra;
                usuario.UserName = nombre;
                //ALISTAMOS NUESTRAS COSAS PARA RECUPERAR EL TIPO DE USUARIO
                DataTable tabla_usuario = new DataTable();
                DAOusuario daoU = new DAOusuario();
                //CONSULTAMOS
                tabla_usuario = daoU.consultar_usuario(usuario);
                //recuperamos el tipo de usuario 
                string tipo_usuario = "";
                foreach(DataRow row in tabla_usuario.Rows)
                {
                    tipo_usuario = row[0].ToString();
                }
                //EN CASO DE TENER DATOS, PERO EL USUARIO NO ESTA EN LA BD
                //LANZAMOS MENSAJE DE ERROR
                if (tipo_usuario == "")
                {
                    MessageBox.Show("EL USUARIO NO SE ENCUENTRA EN LA BASE DE DATOS");
                    
                }
                else
                {
                    //SI ESTA EN LA BD SE ACCEDE Y SE LE PASA EL TIPO DE USUARIO
                    //DE ESTA MANERA PODEMOS BLOQUEAR CIERTAS FUNCIONALIDADES
                    Frm_Cajero v = new Frm_Cajero();
                    v.tipo_userio(tipo_usuario);
                    v.Show();
                    this.Visible = false;
                    //LE PASAMOS EL TIPO DE USUARIO QUE INGRESO
                    //PARA BLOQUEAR O NO CIERTAS FUNCIONES
                    FrmVentas.tipo_usuario = tipo_usuario;
                    FrmVentas.nombre_usuario = txtNombre.Text;
                }
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
