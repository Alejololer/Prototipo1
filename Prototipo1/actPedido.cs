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
    public partial class actPedido : Form
    {
        public actPedido()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del nuevo formulario
            actPedido2 nuevoFormulario = new actPedido2();
            nuevoFormulario.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            nuevoFormulario.ShowDialog();

            // Oculta el formulario actual
        }

        private void actPedido_Load(object sender, EventArgs e)
        {

        }
        // estio es una prueba para git 223 agrego imaeges
    }
}
