namespace Prototipo1
{
    partial class actPedido2
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
            button4 = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            richTextBox2 = new RichTextBox();
            label5 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(344, 199);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 39;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox2.Location = new Point(194, 154);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(236, 28);
            comboBox2.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 158);
            label7.Name = "label7";
            label7.Size = new Size(174, 20);
            label7.TabIndex = 37;
            label7.Text = "Eliminar tipo de examen:";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(14, 623);
            richTextBox2.Margin = new Padding(3, 4, 3, 4);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(417, 117);
            richTextBox2.TabIndex = 36;
            richTextBox2.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 574);
            label5.Name = "label5";
            label5.Size = new Size(159, 32);
            label5.TabIndex = 35;
            label5.Text = "Comentarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 247);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 34;
            label3.Text = "Tipos de examen";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 296);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(417, 261);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(344, 106);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 32;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox1.Location = new Point(194, 61);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 28);
            comboBox1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 65);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 30;
            label2.Text = "Añadir tipo de examen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(113, 12);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 29;
            label1.Text = "Datos del pedido";
            // 
            // button3
            // 
            button3.Location = new Point(210, 757);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 41;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 757);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 40;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // actPedido2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 807);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(richTextBox2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "actPedido2";
            Text = "Actualizar Pedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private ComboBox comboBox2;
        private Label label7;
        private RichTextBox richTextBox2;
        private Label label5;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
    }
}