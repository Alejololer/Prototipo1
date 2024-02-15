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
    public partial class Pacientes2 : Form
    {
        public Pacientes2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registrarPaciente registrar = new registrarPaciente();
            registrar.Show();
        }

        private void Pacientes2_Load(object sender, EventArgs e)
        {

        }
    }
}
