namespace Prototipo1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crea una instancia del nuevo formulario
            Form2 nuevoFormulario = new Form2();

            // Muestra el nuevo formulario
            nuevoFormulario.ShowDialog();

            // Oculta el formulario actual
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            MessageBox.Show("Hasta luego",null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Cerrar el programa
            Application.Exit();
        }

    }
}
