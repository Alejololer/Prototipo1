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
    public partial class modifParam : Form
    {
        public modifParam()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parámetros modificados correctamente", "Modificación de Parámetros", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void modifParam_Load(object sender, EventArgs e)
        {

        }
    }
}
