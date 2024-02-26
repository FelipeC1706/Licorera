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
        MySqlConnection conexionDB = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "licorera";
        static string usuario = "root";
        static string password = "";

        string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

        public MySqlConnection open() 
        {
            

            try
            {
                conexionDB.ConnectionString = cadenaConexion;
                conexionDB.Open();
                MessageBox.Show("BUENA ESE ES MI INGE");                                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR BRO UD ES MUY ESTUPIDO: " + ex.Message);
                               
            }

            return conexionDB;
        }

        public void close()
        {
            conexionDB.Close();
        }

    }
}
