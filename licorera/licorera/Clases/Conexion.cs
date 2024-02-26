using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace licorera.Clases
{
    internal class Conexion
    {

        public static MySqlConnection conexion() 
        {
            string servidor = "localhost";
            string bd = "licorera";
            string usuario = "root";
            string password = "password";

            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(cadenaConexion);

                MessageBox.Show("BUENA ESE ES MI INGE");

                return conexionDB;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("ERROR BRO: " + ex.Message);

                return null;
            }


        }

    }
}
