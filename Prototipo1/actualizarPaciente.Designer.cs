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
            textBox1.Location = new Point(142, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 49);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 13;
            label2.Text = "Cédula de Identidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 12;
            label1.Text = "Actualizar Datos del Paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 86);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 15;
            label3.Text = "Dato a modificar:";
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dirección", "Teléfono", "Correo" });
            comboBox1.Location = new Point(142, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 123);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 17;
            label4.Text = "Dato nuevo:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 18;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(159, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // actualizarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 200);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "actualizarPaciente";
            Text = "actualizarPaciente";
            Load += actualizarPaciente_Load_1;
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