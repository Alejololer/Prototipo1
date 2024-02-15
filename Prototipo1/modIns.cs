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
    public partial class modIns : Form
    {
        public modIns()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos actualizados correctamente", "Actualización de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void modIns_Load(object sender, EventArgs e)
        {

        }
    }
}
