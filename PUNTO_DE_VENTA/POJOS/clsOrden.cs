using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.POJOS
{
    class clsOrden
    {
        private int orderID;
        private string fecha;
        private double total;
        private int empleado;

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
        public string Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public double Total
        {
            get
            {
                return total;

            }
            set
            {
                total = value;
            }
        }
        public int Empleado
        {
            get
            {
                return empleado;
            }
            set
            {
                empleado = value;
            }
        }
    }
}
