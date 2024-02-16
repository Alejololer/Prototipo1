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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrarPedido));
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
            textBox4.Location = new Point(157, 47);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(229, 23);
            textBox4.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Modern No. 20", 11.249999F);
            label4.Location = new Point(-1, 50);
            label4.Name = "label4";
            label4.Size = new Size(131, 17);
            label4.TabIndex = 13;
            label4.Text = "Cédula de Identidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold);
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 24);
            label1.TabIndex = 12;
            label1.Text = "Datos del Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Modern No. 20", 11.249999F);
            label2.Location = new Point(-1, 119);
            label2.Name = "label2";
            label2.Size = new Size(148, 17);
            label2.TabIndex = 15;
            label2.Text = "Añadir tipo de examen:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox1.Location = new Point(157, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Modern No. 20", 11.249999F);
            button1.Location = new Point(310, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(11, 300);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(373, 156);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(310, 650);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 19;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(201, 650);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 20;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold);
            label3.Location = new Point(12, 262);
            label3.Name = "label3";
            label3.Size = new Size(164, 24);
            label3.TabIndex = 21;
            label3.Text = "Tipos de examen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold);
            label5.Location = new Point(12, 474);
            label5.Name = "label5";
            label5.Size = new Size(123, 24);
            label5.TabIndex = 22;
            label5.Text = "Comentarios";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(11, 512);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(373, 89);
            richTextBox2.TabIndex = 23;
            richTextBox2.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Modern No. 20", 11.249999F);
            label6.Location = new Point(-1, 84);
            label6.Name = "label6";
            label6.Size = new Size(108, 17);
            label6.TabIndex = 24;
            label6.Text = "Doctor asociado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 23);
            textBox1.TabIndex = 25;
            // 
            // button4
            // 
            button4.Font = new Font("Modern No. 20", 11.249999F);
            button4.Location = new Point(310, 224);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 28;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox2.Location = new Point(159, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 23);
            comboBox2.TabIndex = 27;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Modern No. 20", 11.249999F);
            label7.Location = new Point(-1, 192);
            label7.Name = "label7";
            label7.Size = new Size(162, 17);
            label7.TabIndex = 26;
            label7.Text = "Eliminar tipo de examen:";
            // 
            // registrarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.manodocu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(396, 562);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "registrarPedido";
            Text = "Registrar Pedido";
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