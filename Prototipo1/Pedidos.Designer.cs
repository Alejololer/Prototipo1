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
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(701, 33);
            panel1.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-1, 6);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 31;
            label7.Text = "AmatreSis";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 6);
            label8.Name = "label8";
            label8.Size = new Size(309, 20);
            label8.TabIndex = 22;
            label8.Text = "Usuario: Silvana Villegas - Jefe de laboratorio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(572, 238);
            label3.Name = "label3";
            label3.Size = new Size(103, 48);
            label3.TabIndex = 41;
            label3.Text = "Estadísticas \r\nde Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(272, 238);
            label2.Name = "label2";
            label2.Size = new Size(154, 48);
            label2.TabIndex = 40;
            label2.Text = "     Consultar \r\nPedidos Pendientes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(10, 250);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 39;
            label1.Text = "Registrar Pedido";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Resultados;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(547, 63);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(153, 157);
            button3.TabIndex = 38;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Pedidos1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(273, 63);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(153, 157);
            button2.TabIndex = 37;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Cliente2;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(-1, 63);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(153, 157);
            button1.TabIndex = 36;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(398, 491);
            label4.Name = "label4";
            label4.Size = new Size(123, 24);
            label4.TabIndex = 46;
            label4.Text = "Eliminar Pedido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F);
            label5.Location = new Point(173, 491);
            label5.Name = "label5";
            label5.Size = new Size(135, 24);
            label5.TabIndex = 45;
            label5.Text = "Actualizar Pedido";
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Pedidos1;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(381, 304);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(153, 157);
            button4.TabIndex = 44;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.Cliente2;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(163, 304);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(153, 157);
            button5.TabIndex = 43;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 535);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Pedidos";
            Text = "Pedido";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label4;
        private Label label5;
        private Button button4;
        private Button button5;
    }
}