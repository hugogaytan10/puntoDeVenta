using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PUNTO_DE_VENTA.POJOS;

namespace PUNTO_DE_VENTA.BACKEND
{
    class DAOtransaccion
    {
        public void insertar_detalle_orden(clsDetallesOrden od)
        {
            string insert = "insert into `order details` values(@UnitPrice, @Quantity, @Idproducts, @OrderID);";
            MySqlCommand comando = new MySqlCommand(insert);
            comando.Parameters.AddWithValue("?UnitPrice", od.PrecioUnitario);
            comando.Parameters.AddWithValue("?Quantity", od.Cantidad);
            comando.Parameters.AddWithValue("?Idproducts", od.ProductID);
            comando.Parameters.AddWithValue("?OrderID", od.OrderID);

            clsConexion.ejecutarSentencia(comando);
        }
        //METODO PARA IR BAJANDO LOS PRODUCTOS UNO POR UNO DE CADA RENGLON
        // TAMBIEN SE VERIFICA QUE SE PUEDA HACER SINO NO REALIZAR LA CONSULTA
        public bool update_producto_inevntario(clsProductos p)
        {
            try
            {

                string update = "update products set unitInStock = unitInStock - @cantidadVendida " +
                    "where codigo = @Codigo and unitInStock >= @cantidadVendida";
                MySqlCommand comando = new MySqlCommand(update);
                comando.Parameters.AddWithValue("?cantidadVendida", p.Cantidad);
                comando.Parameters.AddWithValue("?Codigo", p.Codigo);
                clsConexion.ejecutarSentencia(comando);
                return true;
            }
            catch (Exception ex) { return false; }
        }
        public int productos_stock(clsProductos p)
        {
            try
            {
                string select = "select unitInStock from products where codigo = @Codigo;";
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("?Codigo", p.Codigo);
                DataTable dt = new DataTable();
                dt = clsConexion.ejecutarConsulta(comando);
                //RECUPERAMOS EL VALOR
                int valor = 0;
                foreach(DataRow x in dt.Rows)
                {
                    valor = Convert.ToInt32(x[0].ToString());
                }
                return valor;
            }
            catch (Exception ex) { return 0; }
        }
        public string orden_actual()
        {
            try
            {
                string selectOrder = "select OrderID from orders order by orderID desc limit 1;";
                MySqlCommand slCommand = new MySqlCommand(selectOrder);
                // creamos la tabla y obtenemos el valor de la consulta
                DataTable dt = clsConexion.ejecutarConsulta(slCommand);
                int orderID = -1;
                foreach (DataRow ultimaOrden in dt.Rows)
                {
                    orderID = Convert.ToInt32(ultimaOrden[0].ToString());
                }
                string orden = orderID.ToString();
                return orden;
            }
            catch (Exception ex) { return ""; }
        }
    }
}
