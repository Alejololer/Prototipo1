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
    public partial class anulFac : Form
    {
        public anulFac()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            DialogResult result = MessageBox.Show("¿Desea anular la factura?", "Anulación de Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Factura anulada", "Anulación de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }

            this.Close();
        }

        private void anulFac_Load(object sender, EventArgs e)
        {

        }
    }
}
