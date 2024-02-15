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
    public partial class consExam : Form
    {
        public consExam()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tipo de examen no encontrado", "Consulta de tipo de examen", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
