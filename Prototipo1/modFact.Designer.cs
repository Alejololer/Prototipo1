﻿namespace Prototipo1
{
    partial class modFact
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
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(159, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 123);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 25;
            label4.Text = "Dato nuevo:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cédula de Identidad", "Dirección", "Teléfono", "Correo", "Valor Total" });
            comboBox1.Location = new Point(142, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 23);
            comboBox1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 86);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 23;
            label3.Text = "Dato a modificar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 49);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 21;
            label2.Text = "Factura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 20;
            label1.Text = "Actualizar Datos del Paciente:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Factura 1", "Factura 3", "Factura 2" });
            comboBox2.Location = new Point(142, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 23);
            comboBox2.TabIndex = 28;
            // 
            // modFact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 200);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "modFact";
            Text = "modFact";
            Load += modFact_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
    }
}