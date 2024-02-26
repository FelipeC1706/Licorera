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
        public void montrarClientes(DataGridView tablaCliente)
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

        public void guardarClientes(TextBox cedula,TextBox nombre, TextBox apellidos, TextBox correo, TextBox telefono)
        {
            int numCedula = Convert.ToInt32(cedula.Text);
            int numTelefono = Convert.ToInt32(telefono.Text);
            try
            {
                MessageBox.Show("aca toy");
                Conexion conexion = new Conexion();

                string query = "insert into clientes (cedula_Cliente, nombre_Cliente, apellido_Cliente, correo_Cliente, telefono_Cliente, status_Cliente)" +
                    " values('" + numCedula +"','"+ nombre.Text+"','"+apellidos.Text+"','"+correo.Text+"','"+numTelefono+"', '1');";
                
                MySqlCommand myComand = new MySqlCommand(query, conexion.open());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se guardo al cliente Exitosamente.");
                while(reader.Read())
                {
                   
                }
                conexion.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Mi perro no funciona ver clientes." + ex.ToString());
            }
        }
    }
}
