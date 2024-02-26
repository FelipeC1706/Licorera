using licorera.Clases;
using MySql.Data.MySqlClient;

namespace licorera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Users usuarios = new Users();
            usuarios.montrarUsuarios(dgvTablaUsers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String NombreUser = txtNombreUser.Text;
            String ApellidoUser = txtApellidoUser.Text;
            int CedulaUser = int.Parse(txtCedulaUser.Text);
            String CorreoUser = txtCorreoUser.Text;
            int Telefono = int.Parse(txtTelefonoUser.Text);


            string sql = "INSERT INTO licorera (id_User, cedula_User, nombre_User, apellido_User, correo_User, telefono_User, status_User) VALUES ('" + CedulaUser + "','" + NombreUser + "','" + ApellidoUser + "','" + CorreoUser + "','" + Telefono + "')";

            MySqlConnection conexionDB = 

        }
    }
}
