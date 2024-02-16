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
            nuevoFormulario.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            nuevoFormulario.ShowDialog();

            // Oculta el formulario actual

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Enviar un mensaje
            MessageBox.Show("Hasta luego", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Cerrar el programa
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
