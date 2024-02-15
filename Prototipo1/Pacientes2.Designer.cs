namespace Prototipo1
{
    partial class Pacientes2
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
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 6);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 30;
            label7.Text = "AmatreSis";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 25);
            panel1.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 6);
            label8.Name = "label8";
            label8.Size = new Size(241, 15);
            label8.TabIndex = 22;
            label8.Text = "Usuario: Silvana Villegas - Jefe de laboratorio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(391, 188);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 29;
            label3.Text = "Actualizar Datos de Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(191, 188);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 28;
            label2.Text = "Consultar Datos de Paciente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(20, 188);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 27;
            label1.Text = "Registrar Paciente";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Resultados;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(414, 51);
            button3.Name = "button3";
            button3.Size = new Size(134, 118);
            button3.TabIndex = 26;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Pedidos1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(213, 51);
            button2.Name = "button2";
            button2.Size = new Size(134, 118);
            button2.TabIndex = 25;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Cliente2;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(12, 51);
            button1.Name = "button1";
            button1.Size = new Size(134, 118);
            button1.TabIndex = 24;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Pedidos1;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(310, 236);
            button4.Name = "button4";
            button4.Size = new Size(134, 118);
            button4.TabIndex = 33;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.Cliente2;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(120, 236);
            button5.Name = "button5";
            button5.Size = new Size(134, 118);
            button5.TabIndex = 32;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(338, 376);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 35;
            label4.Text = "Dar de baja";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F);
            label5.Location = new Point(151, 376);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 34;
            label5.Text = "Dar de alta";
            // 
            // Pacientes2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 416);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Pacientes2";
            Text = "Pacientes2";
            Load += Pacientes2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private Label label8;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private Label label4;
        private Label label5;
    }
}