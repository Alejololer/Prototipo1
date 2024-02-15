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
    public partial class submeIns : Form
    {
        public submeIns()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            regIns regIns = new regIns();
            regIns.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consIns consIns = new consIns();
            consIns.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modIns modIns = new modIns();
            modIns.ShowDialog();
        }
    }
}
