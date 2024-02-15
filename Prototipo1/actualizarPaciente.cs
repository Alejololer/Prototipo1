using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1
{
    public partial class actualizarPaciente : Form
    {
        public actualizarPaciente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos actualizados correctamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void actualizarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void actualizarPaciente_Load_1(object sender, EventArgs e)
        {

        }
    }
}
