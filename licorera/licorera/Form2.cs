using licorera.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licorera
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Cliente cliente = new Cliente();
            cliente.montrarAlumnos(dgvTablaCliente);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvTablaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
