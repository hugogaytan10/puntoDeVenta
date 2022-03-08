using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PUNTO_DE_VENTA.POJOS;
using PUNTO_DE_VENTA.BACKEND;

namespace PUNTO_DE_VENTA.BACKEND
{
    class DAOusuario
    {
        public DataTable consultar_usuario(clUsuario u)
        {
            try
            {
                string select = "select typeUser from users where userName = @Nombre and userPassword = sha1(@contrasenia);";
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("@Nombre", u.UserName);
                comando.Parameters.AddWithValue("@contrasenia", u.Contrasenia);
                //CREAMOS LA TABLA A RETORNAR
                DataTable ans_query = clsConexion.ejecutarConsulta(comando);
                return ans_query;
            }
            catch (Exception ex) { return null; }
        }
        public DataTable consultar_nombre(clUsuario u)
        {
            try
            {
                string select = "select firstname from employees as e join users as u on e.userID = u.userID where u.userName = @Username and u.typeUser = @Tipo; ";
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("@UserName", u.UserName);
                comando.Parameters.AddWithValue("@Tipo", u.Tipo_usuario);
                //CREAMOS LA TABLA A RETORNAR
                DataTable ans_query = clsConexion.ejecutarConsulta(comando);
                return ans_query;
            }
            catch (Exception ex) { return null; }
        }

        public DataTable consultar_id_empleado(string nombre)
        {
            try
            {
                string select = "select employeeID from employees where firstname = @Nombre; ";
                MySqlCommand comando = new MySqlCommand(select);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                //CREAMOS LA TABLA A RETORNAR
                DataTable ans_query = clsConexion.ejecutarConsulta(comando);
                return ans_query;
            }
            catch (Exception ex) { return null; }
        }
    }
}
