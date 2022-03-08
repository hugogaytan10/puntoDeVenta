using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.POJOS
{
    public class clsProductos
    {
       
        private string codigo;
        private string nombreProducto;
        private double cantidad;
        private double precioUnitario;
        private double subTotal;
        //private int stock;

        
        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public string NombreProducto
        {
            get
            {
                return nombreProducto;
            }
            set
            {
                nombreProducto = value;
            }
        }
        public double Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
        public double PrecioUnitario
        {
            get
            {
                return precioUnitario;
            }
            set
            {
                precioUnitario = value;
            }
        }
        public double SubTotal
        {
            get
            {
                return subTotal;
            }
            set
            {
                subTotal = value;
            }
        }
        /*public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }
        */
    }
}
