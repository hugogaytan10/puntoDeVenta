using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUNTO_DE_VENTA.FRONTEND;
using PUNTO_DE_VENTA.BACKEND;


namespace PUNTO_DE_VENTA.POJOS
{
    class clsCierraCaja
    {
        private string fecha_inicial;
        private string fecha_final;
        public string Fecha_inicio
        {
            get
            {
                return fecha_inicial;
            }
            set
            {
                fecha_inicial = value;
            }
        }
        public string Fecha_fin
        {
            get
            {
                return fecha_final;
            }
            set
            {
                fecha_final = value;
            }
        }
    }
}
