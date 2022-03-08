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

namespace PUNTO_DE_VENTA.FRONTEND
{
    public partial class Frm_validar_usuario : Form
    {
        
        public Frm_validar_usuario()
        {
            InitializeComponent();
        }

        private void btn_agrega_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS LOS DATOS Y LO BUSCAMOS EN LA BD 
            string nombre = txtNombre.Text;
            string contra = txtContrasenia.Text;
            //si esta vacio algun campo lanzamos un mensaje
            if (nombre == "NOMBRE DE USUARIO" || contra == "CONTRASEÑA")
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
                foreach (DataRow row in tabla_usuario.Rows)
                {
                    tipo_usuario = row[0].ToString();
                }
                //EN CASO DE TENER DATOS, PERO EL USUARIO NO ESTA EN LA BD
                //LANZAMOS MENSAJE DE ERROR
                if (tipo_usuario == "")
                {
                    MessageBox.Show("ACCESO DENEGADO");
                    FrmVentas.validar_usuario = "0";
                    
                }
                else if(tipo_usuario == "1")
                {
                    //SI es un administrador entonces si puede cerrar la caja
                    FrmVentas.validar_usuario = "1";
                    this.Close();
                }
                //SI DEVUELVE UN 2 ES UN CAJERO Y NO PUEDE HACER EL CORTE EL MISMO
                else if(tipo_usuario == "2")
                {
                    FrmVentas.validar_usuario = "2";
                    MessageBox.Show("ACCESO DENEGADO");
                    this.Close();
                }
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
