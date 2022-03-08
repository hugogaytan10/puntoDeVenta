using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.POJOS
{
    class clsDetallesOrden
    {
        //ATRIBUTOS PARA INSERTAR EN 
        // DETALLE DE ORDEN
        private int orderID;
        private double cantidad;
        private double precioUnitario;
        private int productID;
        private float discount;
        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
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
        public int ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }
        public float Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }

    }
}
