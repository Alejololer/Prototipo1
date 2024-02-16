namespace Prototipo1
{
    partial class actualizarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actualizarPaciente));
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 24);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Modern No. 20", 11.249999F);
            label2.Location = new Point(23, 54);
            label2.Name = "label2";
            label2.Size = new Size(131, 17);
            label2.TabIndex = 13;
            label2.Text = "Cédula de Identidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 10);
            label1.Name = "label1";
            label1.Size = new Size(271, 21);
            label1.TabIndex = 12;
            label1.Text = "Actualizar Datos del Paciente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Modern No. 20", 11.249999F);
            label3.Location = new Point(23, 97);
            label3.Name = "label3";
            label3.Size = new Size(115, 17);
            label3.TabIndex = 15;
            label3.Text = "Dato a modificar:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dirección", "Teléfono", "Correo" });
            comboBox1.Location = new Point(166, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 25);
            comboBox1.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Modern No. 20", 11.249999F);
            label4.Location = new Point(23, 138);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 17;
            label4.Text = "Dato nuevo:";
            label4.Click += label4_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 24);
            textBox2.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(185, 189);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 19;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // actualizarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.manodocu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(449, 227);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Modern No. 20", 11.249999F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "actualizarPaciente";
            Text = "Actualizar Paciente";
            Load += actualizarPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
    }
}