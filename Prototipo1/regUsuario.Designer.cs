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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(regUsuario));
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
            button2.Font = new Font("Modern No. 20", 11.249999F);
            button2.Location = new Point(295, 194);
            button2.Name = "button2";
            button2.Size = new Size(75, 25);
            button2.TabIndex = 23;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Modern No. 20", 11.249999F);
            button1.Location = new Point(167, 194);
            button1.Name = "button1";
            button1.Size = new Size(78, 25);
            button1.TabIndex = 22;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Modern No. 20", 11.249999F);
            label3.Location = new Point(-1, 87);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 19;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Modern No. 20", 11.249999F);
            label2.Location = new Point(-1, 51);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 18;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 24);
            label1.TabIndex = 17;
            label1.Text = "Datos del Paciente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Modern No. 20", 11.249999F);
            label4.Location = new Point(-1, 160);
            label4.Name = "label4";
            label4.Size = new Size(109, 17);
            label4.TabIndex = 24;
            label4.Text = "Tipo de Usuario:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Jefe de Laboratorio", "Asistente de Laboratorio", "Invitado" });
            comboBox1.Location = new Point(153, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 121);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(218, 23);
            textBox3.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Modern No. 20", 11.249999F);
            label5.Location = new Point(-1, 123);
            label5.Name = "label5";
            label5.Size = new Size(159, 17);
            label5.TabIndex = 26;
            label5.Text = "Confirmar la contraseña:";
            // 
            // regUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.manodocu;
            BackgroundImageLayout = ImageLayout.Stretch;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "regUsuario";
            Text = "Registrar Usuario";
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