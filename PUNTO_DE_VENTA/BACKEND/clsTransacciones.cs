using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PUNTO_DE_VENTA.POJOS;
using PUNTO_DE_VENTA.BACKEND;
using PUNTO_DE_VENTA.FRONTEND;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace PUNTO_DE_VENTA.BACKEND
{
    class clsTransacciones
    {
        public bool transaccionFinOperacion(DataGridView dg, double totalOrden, int employee, float descuento)
        {
            
            string conex = "server = 192.168.8.3; database = punto_venta; " + "uid = cris; pwd = 1234;";
            MySqlConnection con = new MySqlConnection(conex);
            MySqlTransaction trans = null;
            try
            {
                con.Open();
                trans = con.BeginTransaction();
                //obtnemos los datos necesarios para el insert de la orden
               
                //string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd ");
                string fechaHoy = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
               
                //CREAR ORDEN
                string insert = "insert into orders (orderDate,freight, employeeID) values(@fecha,@precio,@idemployee);";
                MySqlCommand insertOrder = new MySqlCommand(insert);
                insertOrder.Parameters.AddWithValue("fecha", fechaHoy);
                insertOrder.Parameters.AddWithValue("precio", totalOrden);
                insertOrder.Parameters.AddWithValue("idemployee", employee);
                clsConexion.ejecutarSentencia(insertOrder);
                
                //OBTENER ORDEN agregada
                string selectOrder = "select OrderID from orders order by orderID desc limit 1;";
                MySqlCommand slCommand = new MySqlCommand(selectOrder);
                // creamos la tabla y obtenemos el valor de la consulta
                DataTable dt = clsConexion.ejecutarConsulta(slCommand);
                int orderID = 0;
                foreach (DataRow ultimaOrden in dt.Rows)
                {
                    orderID = Convert.ToInt32(ultimaOrden[0].ToString());
                }
                if(orderID == 0)
                {
                    orderID = 1;
                }
                //INGRESAR LOS DETALLES DE ORDEN
                foreach(DataGridViewRow x in dg.Rows)
                {
                    if(x.Cells["Codigo"].Value != null)
                    {

                        //CREAMOS LAS INSTANCIAS NECESARIAS POR OPERACION
                        DAOtransaccion daoT = new DAOtransaccion();
                        clsDetallesOrden od = new clsDetallesOrden();
                        clsProductos p = new clsProductos();

                        //AQUI DEBO RECUPERAR EL ID QUE SE USA EN LA BD PARA CADA PRODUCTO
                        string selectID = "select idproducts from products where codigo = @Codigo";
                        MySqlCommand select_id_producto = new MySqlCommand(selectID);
                        select_id_producto.Parameters.AddWithValue("Codigo", x.Cells["Codigo"].Value.ToString());
                        DataTable tabla_id_producto = clsConexion.ejecutarConsulta(select_id_producto);
                        int id_producto = -1;
                        foreach (DataRow id_obtenido in tabla_id_producto.Rows)
                        {
                            id_producto = Convert.ToInt32(id_obtenido[0].ToString());
                        }
                        //RECUPERAMOS LOS DATOS DE CADA RENGLÓN
                        od.ProductID = id_producto;
                        od.Cantidad = Convert.ToDouble(x.Cells["Cantidad"].Value.ToString());
                        od.PrecioUnitario = Convert.ToDouble(x.Cells["PrecioUnitario"].Value.ToString());
                        od.OrderID = orderID;
                        //CHECAR LOS DESCUENTOS
                        //od.Discount = descuento;
                        //OBTENEMOS EL PRODUCTID PARA QUITARLO DESPUES DEL STOCK
                        p.Codigo = x.Cells["Codigo"].Value.ToString();
                        p.Cantidad = Convert.ToDouble(x.Cells["Cantidad"].Value.ToString());
                        //LO ALMACENAMOS EN LA BD
                        daoT.insertar_detalle_orden(od);
                    
                        //verificamos que tenemos suficiente en stock
                        //int stock = daoT.productos_stock(p);
                        /*
                        if(stock >= p.Cantidad)
                        {
                            //hacemos el update de productos 
                            //que acabamos de agregar
                            bool up = daoT.update_producto_inevntario(p);
                        }
                        else
                        {
                            MessageBox.Show("NO HAY SUFICIENTES PRODUCTOS EN STOCK");
                        
                        }*/
                        bool up = daoT.update_producto_inevntario(p);
                    }

                    
                }

                
                // si todo esta bien se hace la transaccion
                trans.Commit();
                return true;
            }catch(Exception ex)
            {
               
                trans.Rollback();
                return false;
            }
            finally
            {
                
            }
        }
        
    }
}
