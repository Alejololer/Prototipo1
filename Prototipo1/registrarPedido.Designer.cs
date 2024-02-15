namespace Prototipo1
{
    partial class registrarPedido
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
            textBox4 = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label5 = new Label();
            richTextBox2 = new RichTextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(179, 66);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 27);
            textBox4.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 69);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 13;
            label4.Text = "Cédula de Identidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(215, 32);
            label1.TabIndex = 12;
            label1.Text = "Datos del Pedido:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 184);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 15;
            label2.Text = "Añadir tipo de examen:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox1.Location = new Point(179, 184);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 28);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(354, 237);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 17;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 439);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(426, 261);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(354, 876);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 19;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(230, 876);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 20;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 388);
            label3.Name = "label3";
            label3.Size = new Size(214, 32);
            label3.TabIndex = 21;
            label3.Text = "Tipos de examen:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 705);
            label5.Name = "label5";
            label5.Size = new Size(166, 32);
            label5.TabIndex = 22;
            label5.Text = "Comentarios:";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(14, 743);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(426, 117);
            richTextBox2.TabIndex = 23;
            richTextBox2.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 128);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 24;
            label6.Text = "Doctor asociado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 128);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 25;
            // 
            // button4
            // 
            button4.Location = new Point(354, 345);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 28;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox2.Location = new Point(182, 297);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(261, 28);
            comboBox2.TabIndex = 27;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-1, 300);
            label7.Name = "label7";
            label7.Size = new Size(174, 20);
            label7.TabIndex = 26;
            label7.Text = "Eliminar tipo de examen:";
            // 
            // registrarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 920);
            Controls.Add(button4);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(richTextBox2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "registrarPedido";
            Text = "registrarPedido";
            Load += registrarPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private Label label4;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label5;
        private RichTextBox richTextBox2;
        private Label label6;
        private TextBox textBox1;
        private Button button4;
        private ComboBox comboBox2;
        private Label label7;
    }
}