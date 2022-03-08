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

namespace PUNTO_DE_VENTA
{
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
            color_grid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //VERIFICAMOS QUE LOS CAMPOS TENGAN COHERENCIA
            if(rbOp1.Checked == true && txtCodigo.Text != "")
            {
                //OBTENEMOS LOS DATOS DE ACUERDO A LO NECESARIO 
                
                DAOproductos daop = new DAOproductos();
                clsProductos p = new clsProductos();
                p.Codigo = txtCodigo.Text;
                //PRIMERO CONSULTAMOS SI ESTA EN LA BD
                if (daop.obtenerUnProducto(p))
                {
                    //LO ASIGANMOS A NUESTRA TABLA
                    dataGridView1.DataSource = daop.consultarProducto(p);
                }
                else
                {
                    MessageBox.Show("El producto no está en la base de datos");
                }
                rbOp1.Checked = false;
                txtCodigo.Text = "";
            }
            //VERIFICAMOS LA COHERENCIA DE LOS CAMPOS
            else if(rbOp2.Checked ==  true && txtNombre.Text != "")
            {
                DAOproductos daop = new DAOproductos();
                clsProductos p = new clsProductos();
                p.NombreProducto = txtNombre.Text;
                //VERIFICAMOS QUE ESTE EN LA BD
                if (daop.buscarPorNombre(p))
                {
                    //LO AGREGAMOS A LA DATAGRID
                    dataGridView1.DataSource = daop.obtenerProductoPorNombre(p);
                }
                else
                {
                    MessageBox.Show("El producto no está en la base de datos");
                }
                rbOp2.Checked = false;
                txtNombre.Text = "";
            }
            else
            {
                //SI NO TIENE COHERENCIA LOS DATOS, LIMPIAMOS LOS DATOS
                
                txtCodigo.Text = "";
                txtNombre.Text = "";
                rbOp1.Checked = false;
                rbOp2.Checked = false;
            }
            
        }

        private void rbOp1_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtCodigo.Enabled = true;
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "CODIGO")
            {
                txtCodigo.Text = "";
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                txtCodigo.Text = "CODIGO";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                txtNombre.Text = "NOMBRE";
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if(txtNombre.Text == "NOMBRE")
            {
                txtNombre.Text = "";
                
            }
        }
        private void color_grid()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#20A022");
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);


        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
