﻿namespace Prototipo1
{
    partial class consParam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consParam));
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Modern No. 20", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(12, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(363, 146);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "Parámetro 1\nNombre:\nIVA\nValor:\n12\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 24);
            label1.TabIndex = 20;
            label1.Text = "Parámetros del Sistema";
            // 
            // consParam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.manodocu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(387, 192);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "consParam";
            Text = "Consultar Parametro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
    }
}