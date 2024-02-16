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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actPedido2));
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
            button4.Font = new Font("Modern No. 20", 11.249999F);
            button4.Location = new Point(301, 149);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 39;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox2.Location = new Point(170, 116);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(207, 23);
            comboBox2.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 118);
            label7.Name = "label7";
            label7.Size = new Size(162, 17);
            label7.TabIndex = 37;
            label7.Text = "Eliminar tipo de examen:";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(12, 467);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(365, 89);
            richTextBox2.TabIndex = 36;
            richTextBox2.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            label5.Location = new Point(12, 430);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 35;
            label5.Text = "Comentarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(153, 21);
            label3.TabIndex = 34;
            label3.Text = "Tipos de examen";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 222);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(365, 197);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Modern No. 20", 11.249999F);
            button1.Location = new Point(301, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox1.Location = new Point(170, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 23);
            comboBox1.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Modern No. 20", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(148, 17);
            label2.TabIndex = 30;
            label2.Text = "Añadir tipo de examen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 21);
            label1.TabIndex = 29;
            label1.Text = "Datos del pedido";
            // 
            // button3
            // 
            button3.Location = new Point(184, 568);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 41;
            button3.Text = "Registrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 568);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 40;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // actPedido2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.manodocu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(387, 562);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "actPedido2";
            Text = "Actualizar Pedido";
            Load += actPedido2_Load;
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