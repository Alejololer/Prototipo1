﻿namespace Prototipo1
{
    partial class Pedidos
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Cliente2;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(333, 166);
            button1.Name = "button1";
            button1.Size = new Size(134, 118);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Pedidos";
            Text = "Pedidos";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}