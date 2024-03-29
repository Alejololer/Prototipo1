﻿using System;
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
    public partial class Suministros : Form
    {
        public Suministros()
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
        private void button1_Click(object sender, EventArgs e)
        {
            submeReact submeReact = new submeReact();
            submeReact.ShowDialog();

        }

        private void Suministros_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            submeIns submeIns = new submeIns();
            submeIns.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            submeExam submeExam = new submeExam();
            submeExam.ShowDialog();
        }
    }
}
