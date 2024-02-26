using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace licorera.Clases
{
    internal class Users
    {
        public void montrarUsuarios(DataGridView tablaCliente)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = "select * from Users";
                tablaCliente.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.Open());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCliente.DataSource = dt;
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mi perro no funciona ver usuarios bruto." + ex.ToString());
            }
        }
    }
}
