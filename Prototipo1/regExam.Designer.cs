﻿namespace Prototipo1
{
    partial class regExam
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
            button4 = new Button();
            comboBox2 = new ComboBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(338, 523);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 32;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(191, 523);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 31;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(162, 111);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 64);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 114);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 28;
            label3.Text = "Costo (sin IVA):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 27;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 12);
            label1.Name = "label1";
            label1.Size = new Size(311, 32);
            label1.TabIndex = 26;
            label1.Text = "Datos del Tipo de Examen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 356);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 33;
            label4.Text = "Reactivos";
            // 
            // button4
            // 
            button4.Location = new Point(337, 305);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 40;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Tipo de Examen Placeholder" });
            comboBox2.Location = new Point(162, 257);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(261, 28);
            comboBox2.TabIndex = 39;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 261);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 38;
            label7.Text = "Eliminar reactivo:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(19, 408);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(405, 261);
            richTextBox1.TabIndex = 37;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(337, 206);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 36;
            button3.Text = "Añadir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Reactivo 1", "Reactivo 2", "Reactivo 3", "Reactivo 4" });
            comboBox1.Location = new Point(162, 158);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 28);
            comboBox1.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 162);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 34;
            label5.Text = "Añadir reactivo:";
            // 
            // button5
            // 
            button5.Location = new Point(210, 689);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(86, 31);
            button5.TabIndex = 42;
            button5.Text = "Registrar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(334, 689);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 41;
            button6.Text = "Cancelar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // regExam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 740);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(richTextBox1);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "regExam";
            Text = "Registro Examen ";
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
        private Button button4;
        private ComboBox comboBox2;
        private Label label7;
        private RichTextBox richTextBox1;
        private Button button3;
        private ComboBox comboBox1;
        private Label label5;
        private Button button5;
        private Button button6;
    }
}