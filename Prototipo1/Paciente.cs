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
    public partial class Pacientes2 : Form
    {
        public Pacientes2()
        {
            InitializeComponent();
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += Boton_MouseEnter;
                    control.MouseLeave += Boton_MouseLeave;
                }
            }
            this.StartPosition = FormStartPosition.CenterScreen;

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
                boton.BackColor = SystemColors.Control; // Restaurar el color de fondo por defecto
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Muestra Form1 cuando Form2 se cierre
            this.Owner.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            registrarPaciente registrar = new registrarPaciente();
            registrar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultarPaciente consultar = new consultarPaciente();
            consultar.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actualizarPaciente actual = new actualizarPaciente();
            actual.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            darDeAlta alta = new darDeAlta();
            alta.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            darDeBaja baja = new darDeBaja();   
            baja.ShowDialog();
        }
    }
}
