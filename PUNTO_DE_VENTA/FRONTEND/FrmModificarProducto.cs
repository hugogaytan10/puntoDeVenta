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
    public partial class FrmModificarProducto : Form
    {
        public FrmModificarProducto()
        {
            InitializeComponent();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                //RECUPERAMOS LOS DATOS PARA MODIFICAR EN LA BD
                clsProductos p = new clsProductos();
                p.Cantidad = Convert.ToDouble(txtStock.Text);
                p.Codigo = txtCodigo.Text;
                p.NombreProducto = txtNombre.Text;
                p.PrecioUnitario = Convert.ToDouble(txtPrecio.Text);
                //pasamos los datos para hacer el update en la bd
                DAOproductos daop = new DAOproductos();
                if (daop.updateProducto(p))
                {
                    MessageBox.Show("ARCTICULO MODIFICADO");
                }
                else
                {
                    MessageBox.Show("Operacion fallida");
                }
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Operación fallida");
            }
        }

        private void limpiarCampos()
        {
            txtCodigo.Text = "CODIGO";
            txtNombre.Text = "NOMBRE DEL PRODUCTO";
            txtPrecio.Text = "PRECIO UNITARIO";
            txtStock.Text = "CANTIDAD EN STOCK";
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                txtCodigo.Text = "CODIGO";
                txtCodigo.ForeColor = Color.White;
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "CODIGO")
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.Green;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE DEL PRODUCTO";
                txtNombre.ForeColor = Color.White;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "NOMBRE DEL PRODUCTO")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Green;
            }
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                txtPrecio.Text = "PRECIO UNITARIO";
                txtPrecio.ForeColor = Color.White;
            }
        }

        private void txtPrecio_Enter(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "PRECIO UNITARIO")
            {
                txtPrecio.Text = "";
                txtPrecio.ForeColor = Color.Green;
            }
        }

        private void txtStock_Leave(object sender, EventArgs e)
        {
            if (txtStock.Text == "")
            {
                txtStock.Text = "CANTIDAD EN STOCK";
                txtStock.ForeColor = Color.White;
            }
        }

        private void txtStock_Enter(object sender, EventArgs e)
        {
            if (txtStock.Text == "CANTIDAD EN STOCK")
            {
                txtStock.Text = "";
                txtStock.ForeColor = Color.Green;
            }
        }

        private void pnModificarProducto_Paint(object sender, PaintEventArgs e)
        {

        }
        public void ingresar_datos(string codigo, string nombre, string stock, string precio)
        {
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtStock.Text = stock;
            txtPrecio.Text = precio;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
