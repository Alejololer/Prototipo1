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
    public partial class consultarPaciente : Form
    {
        public consultarPaciente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Paciente no encontrado", "Consulta de paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
