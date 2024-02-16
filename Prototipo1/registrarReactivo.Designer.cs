namespace Prototipo1
{
    partial class registrarReactivo
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
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            dtpFechaCaducidadReactivo = new DateTimePicker();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(337, 300);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 23;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(191, 300);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 22;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 113);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 27);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 67);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 116);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 19;
            label3.Text = "Cantidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 18;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(108, 12);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 17;
            label1.Text = "Datos del Reactivo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 162);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 24;
            label4.Text = "Fecha de caducidad:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(162, 251);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(261, 27);
            textBox4.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 254);
            label5.Name = "label5";
            label5.Size = new Size(160, 20);
            label5.TabIndex = 28;
            label5.Text = "Máximo rango normal:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(162, 205);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(261, 27);
            textBox5.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 208);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 26;
            label6.Text = "Mínimo rango normal:";
            // 
            // dtpFechaCaducidadReactivo
            // 
            dtpFechaCaducidadReactivo.Location = new Point(162, 159);
            dtpFechaCaducidadReactivo.Name = "dtpFechaCaducidadReactivo";
            dtpFechaCaducidadReactivo.Size = new Size(261, 27);
            dtpFechaCaducidadReactivo.TabIndex = 30;
            // 
            // registrarReactivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 345);
            Controls.Add(dtpFechaCaducidadReactivo);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "registrarReactivo";
            Text = "Registrar Reactivo";
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
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private DateTimePicker dtpFechaCaducidadReactivo;
    }
}