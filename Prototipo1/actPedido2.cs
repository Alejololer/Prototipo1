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
    public partial class actPedido2 : Form
    {
        public actPedido2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Muestra Form1 cuando Form2 se cierre
            this.Owner.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            MessageBox.Show("Pedido registrado con éxito!", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
