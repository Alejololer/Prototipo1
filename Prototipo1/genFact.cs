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
    public partial class genFact : Form
    {
        public genFact()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido no encontrado", "Generación de factura", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
