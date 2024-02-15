namespace Prototipo1
{
    partial class regUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(296, 196);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 23;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(167, 196);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(229, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 82);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 19;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 18;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 17;
            label1.Text = "Datos del Paciente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 164);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 24;
            label4.Text = "Tipo de Usuario:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jefe de Laboratorio", "Asistente de Laboratorio", "Invitado" });
            comboBox1.Location = new Point(142, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(142, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(229, 23);
            textBox3.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 126);
            label5.Name = "label5";
            label5.Size = new Size(137, 15);
            label5.TabIndex = 26;
            label5.Text = "Confirmar la contraseña:";
            // 
            // regUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 231);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "regUsuario";
            Text = "regUsuario";
            Load += regUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label5;
    }
}