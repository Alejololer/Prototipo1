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
    public partial class submeExam : Form
    {
        public submeExam()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            regExam regExam = new regExam();
            regExam.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consExam consExam = new consExam();
            consExam.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modExam modExam = new modExam();
            modExam.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            elimExam elimExam = new elimExam();
            elimExam.ShowDialog();
        }
    }
}
