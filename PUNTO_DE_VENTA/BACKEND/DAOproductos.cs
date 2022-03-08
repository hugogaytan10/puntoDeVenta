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
    class DAOproductos
    {
        // METODO PARA OBTENER TODOS LOS DATOS
        // DE UN PRODUCTO 
        public List<clsProductos> obtenerProducto(clsProductos p)
        {
            //la consulta para traer los datos del producto de la BD
            string select = "Select * from products where codigo = @Codigo;";
            MySqlCommand comando = new MySqlCommand(select);
            comando.Parameters.AddWithValue("?Codigo", p.Codigo);

            //LLENAMOS NUESTRA TABLA 
            DataTable tabla = clsConexion.ejecutarConsulta(comando);

            List<clsProductos> listaP = new List<clsProductos>();
            foreach (DataRow d in tabla.Rows)
            {
                clsProductos aux = new clsProductos();
                aux.Codigo = d[1].ToString();
                aux.NombreProducto = d[2].ToString();
                aux.Cantidad = p.Cantidad;
                aux.PrecioUnitario = Convert.ToDouble(d[4].ToString());
                aux.SubTotal = Math.Round(Convert.ToDouble(d[4].ToString()) * p.Cantidad, 2);
                listaP.Add(aux);
            }
            return listaP;
        }
        public bool insertProducto(clsProductos p)
        {
            try
            {
                //creamos el insert de un producto a la bd
                string insert = "insert into products(codigo,productName, unitInStock, unitPrice) value(@codigo,@nombre, @stock,@precioUni);";
                MySqlCommand comando = new MySqlCommand(insert);
                comando.Parameters.AddWithValue("codigo",p.Codigo);
                comando.Parameters.AddWithValue("nombre",p.NombreProducto);
                comando.Parameters.AddWithValue("stock",p.Cantidad);
                comando.Parameters.AddWithValue("precioUni",p.PrecioUnitario);
                clsConexion.ejecutarSentencia(comando);
                return true;
            }catch(Exception e)
            {
                return false;
            }
            finally
            {

            }
        }
        public bool deleteProduct(clsProductos p)
        {
            try
            {
                //creamos el insert de un producto a la bd
                string delete = "delete from products where codigo = @Codigo;";
                MySqlCommand comando = new MySqlCommand(delete);
                comando.Parameters.AddWithValue("Codigo", p.Codigo);
                clsConexion.ejecutarSentencia(comando);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {

            }
        }
        public bool updateProducto(clsProductos p)
        {

            try
            {
                string update = "update products set unitPrice = @UnitPrice, unitInStock = @UnitStock, "
                                  + " productName = @ProductName where codigo = @Codigo; ";
                MySqlCommand comando = new MySqlCommand(update);
                comando.Parameters.AddWithValue("?UnitPrice",p.PrecioUnitario);
                comando.Parameters.AddWithValue("?Codigo", p.Codigo);
                comando.Parameters.AddWithValue("?UnitStock", p.Cantidad);
                comando.Parameters.AddWithValue("?ProductName", p.NombreProducto);
                clsConexion.ejecutarSentencia(comando);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
        //METEDO PARA VERIFICAR SI ESTA EL PRODUCTO POR
        // MEDIO DE SU ID
        public bool obtenerUnProducto(clsProductos p)
        {
            try
            {
                string select = "Select idproducts from products where codigo = @Codigo;";
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("?Codigo", p.Codigo);
                clsConexion.ejecutarSentencia(comando);
                //SI LA TABLA SI CONTIENE UN VALOR SIGNIFICA QUE ESTA 
                // EN LA BD Y SE PUEDE ELIMINAR
                DataTable tabla = clsConexion.ejecutarConsulta(comando);
               if(tabla.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false ;
            }
        }
        public List<clsProductos> obtenerTodosLosProductos()
        {
            try
            {
                string select = "SELECT * from products;";
                MySqlCommand comando = new MySqlCommand(select);
                clsConexion.ejecutarConsulta(comando);
                //LLENAMOS NUESTRA TABLA 
                DataTable tabla = clsConexion.ejecutarConsulta(comando);

                List<clsProductos> listaP = new List<clsProductos>();
                foreach (DataRow d in tabla.Rows)
                {
                    clsProductos aux = new clsProductos();
                    aux.Codigo = d[1].ToString();
                    aux.NombreProducto = d[2].ToString();
                    aux.Cantidad = Convert.ToDouble(d[3].ToString());
                    aux.PrecioUnitario = Convert.ToDouble(d[4].ToString());
                    aux.SubTotal = Convert.ToDouble(d[4].ToString());
                    listaP.Add(aux);
                }
                return listaP;

            }
            catch(Exception ex)
            {
                return null;
            }
        }
        //OBTENER PRODUCTO POR NOMBRE
        public List<clsProductos> obtenerProductoPorNombre(clsProductos p)
        {
            //la consulta para traer los datos del producto de la BD
            string select = "Select * from products where productName = @productName;";
            MySqlCommand comando = new MySqlCommand(select);
            comando.Parameters.AddWithValue("?productName", p.NombreProducto);

            //LLENAMOS NUESTRA TABLA 
            DataTable tabla = clsConexion.ejecutarConsulta(comando);

            List<clsProductos> listaP = new List<clsProductos>();
            foreach (DataRow d in tabla.Rows)
            {
                clsProductos aux = new clsProductos();
                aux.Codigo = d[1].ToString();
                aux.NombreProducto = d[2].ToString();
                aux.Cantidad = Convert.ToDouble(d[3].ToString());
                aux.PrecioUnitario = Convert.ToDouble(d[4].ToString());
                aux.SubTotal = Math.Round(Convert.ToDouble(d[4].ToString()),2);
                listaP.Add(aux);
            }
            return listaP;
        }
        //METEDO PARA VERIFICAR SI ESTA EL PRODUCTO POR
        // MEDIO DE SU NOMBRE
        public bool buscarPorNombre(clsProductos p)
        {
            try
            {
                string select = "Select * from products where productName = @ProductName;";
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("?ProductName", p.NombreProducto);
 
                //SI LA TABLA SI CONTIENE UN VALOR SIGNIFICA QUE ESTA 
                // EN LA BD Y SE PUEDE ELIMINAR
                DataTable tabla = clsConexion.ejecutarConsulta(comando);
                if (tabla.Rows.Count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //BUSCAR POR PRODUCTO EN VENTANA DE BUSCAR POR PRODUCTO
        public List<clsProductos> consultarProducto(clsProductos p)
        {
            //la consulta para traer los datos del producto de la BD
            string select = "Select * from products where codigo = @Codigo;";
            MySqlCommand comando = new MySqlCommand(select);
            comando.Parameters.AddWithValue("?Codigo", p.Codigo);

            //LLENAMOS NUESTRA TABLA 
            DataTable tabla = clsConexion.ejecutarConsulta(comando);

            List<clsProductos> listaP = new List<clsProductos>();
            foreach (DataRow d in tabla.Rows)
            {
                clsProductos aux = new clsProductos();
                aux.Codigo = d[1].ToString();
                aux.NombreProducto = d[2].ToString();
                aux.Cantidad = Convert.ToDouble(d[3].ToString());
                aux.PrecioUnitario = Convert.ToDouble(d[4].ToString());
                aux.SubTotal = Math.Round(Convert.ToDouble(d[4].ToString()), 2);
                listaP.Add(aux);
            }
            return listaP;
        }
        

    }
}
