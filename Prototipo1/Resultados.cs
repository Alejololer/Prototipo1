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
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += Boton_MouseEnter;
                    control.MouseLeave += Boton_MouseLeave;
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Muestra Form1 cuando Form2 se cierre
            this.Owner.Show();
        }
        // Controlador de eventos para cuando el mouse entra en un botón
        private void Boton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Button boton)
            {
                boton.BackColor = Color.LightGray; // Cambiar el color de fondo
            }
        }

        // Controlador de eventos para cuando el mouse sale de un botón
        private void Boton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button boton)
            {
                boton.BackColor = Color.Transparent; // Restaurar el color de fondo por defecto
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            regisResult regisResult = new regisResult();
            regisResult.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consResult consResult = new consResult();
            consResult.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modResult modResult = new modResult();
            modResult.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            genInforme genInforme = new genInforme();
            genInforme.ShowDialog();
        }
    }
}
