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
    public partial class registrarReactivo : Form
    {
        public registrarReactivo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void registrarReactivo_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Enviar un mensaje
            MessageBox.Show("Reactivo registrado con éxito!", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
