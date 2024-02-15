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
    public partial class regExam : Form
    {
        public regExam()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            richTextBox1.ReadOnly = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Limpiar ComboBox2
            comboBox2.Items.Clear();

            // Dividir el texto en líneas y agregar cada línea como un elemento en ComboBox2
            string[] lineas = richTextBox1.Text.Split('\n');
            foreach (string linea in lineas)
            {
                comboBox2.Items.Add(linea.Trim());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            MessageBox.Show("Pedido registrado con éxito!", "Registro correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = comboBox2.SelectedIndex;
            if (indiceSeleccionado >= 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.GetFirstCharIndexFromLine(indiceSeleccionado), richTextBox1.Lines[indiceSeleccionado].Length).Trim();
                comboBox2.Items.RemoveAt(indiceSeleccionado);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSeleccionado = comboBox2.SelectedIndex;
            if (indiceSeleccionado >= 0 && indiceSeleccionado < comboBox2.Items.Count)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.GetFirstCharIndexFromLine(indiceSeleccionado), richTextBox1.Lines[indiceSeleccionado].Length).Trim();
                comboBox2.Items.RemoveAt(indiceSeleccionado);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Obtener el texto seleccionado del ComboBox
            string textoSeleccionado = comboBox1.SelectedItem.ToString();

            // Añadir el texto seleccionado al RichTextBox en una nueva línea
            richTextBox1.AppendText(textoSeleccionado + "\n");
        }
    }
}
