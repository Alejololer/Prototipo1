using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Prototipo1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Agregar los controladores de eventos para todos los botones
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del nuevo formulario
            Pedidos pedidos = new Pedidos();
            pedidos.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            pedidos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del nuevo formulario
            Resultados res = new Resultados();
            res.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            res.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del nuevo formulario
            submeVent vent = new submeVent();
            vent.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            vent.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del nuevo formulario
            AdmSistema adm = new AdmSistema();
            adm.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            adm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del nuevo formulario
            Pacientes2 pacientes = new Pacientes2();
            pacientes.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            pacientes.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del nuevo formulario
            Suministros suministros = new Suministros();
            suministros.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            suministros.ShowDialog();
        }
    }
}
