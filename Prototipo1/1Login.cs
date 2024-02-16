namespace Prototipo1
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            this.Hide();
            // Crea una instancia del nuevo formulario
            Menuprin2 nuevoFormulario = new Menuprin2();
            nuevoFormulario.FormClosed += (s, args) => this.Show(); // Suscribe al evento FormClosed de Form2
            // Muestra el nuevo formulario
            nuevoFormulario.ShowDialog();

            // Oculta el formulario actual
            //edición ventana Login

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
