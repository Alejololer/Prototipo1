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
    public partial class elimUsu : Form
    {
        public elimUsu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            DialogResult result = MessageBox.Show("¿Está seguro?", "Eliminación de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Usuario eliminado", "Eliminación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }

            this.Close();
        }

        private void elimUsu_Load(object sender, EventArgs e)
        {

        }
    }
}
