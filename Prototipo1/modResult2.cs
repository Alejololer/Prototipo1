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
    public partial class modResult2 : Form
    {
        public modResult2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Muestra Form1 cuando Form2 se cierre
            this.Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            DialogResult result = MessageBox.Show("¿Está seguro?", "Modificación de Resultados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Resultados modificados", "Modificación de Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
