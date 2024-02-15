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
    public partial class darDeBaja : Form
    {
        public darDeBaja()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro?", "Dar de Baja", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Paciente dado de baja", "Dar de Baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {

            }
        }
    }
}
