namespace Prototipo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario
            Form2 nuevoFormulario = new Form2();

            // Muestra el nuevo formulario
            nuevoFormulario.Show();

            // Oculta el formulario actual
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            MessageBox.Show("Hasta luego!");

            // Cerrar el programa
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
