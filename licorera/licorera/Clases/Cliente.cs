using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace licorera.Clases
{
    internal class Cliente
    {
        public void montrarAlumnos(DataGridView tablaCliente)
        {
            try
            {
                Conexion conexion = new Conexion();

                string query = "select * from clientes";
                tablaCliente.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion.open());

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCliente.DataSource = dt;
                conexion.close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Mi perro no funciona ver clientes." + ex.ToString());
            }
        }
    }
}
