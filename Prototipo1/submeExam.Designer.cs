namespace Prototipo1
{
    partial class submeExam
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
            label4 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 6);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 54;
            label7.Text = "AmatreSis";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 25);
            panel1.TabIndex = 55;
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
            label3.Location = new Point(398, 188);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 53;
            label3.Text = "Modificar Tipo de Examen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(199, 188);
            label2.Name = "label2";
            label2.Size = new Size(167, 20);
            label2.TabIndex = 52;
            label2.Text = "Consultar Tipo de Examen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(-3, 188);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 51;
            label1.Text = "Registrar Tipo de Examen";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Resultados;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(414, 51);
            button3.Name = "button3";
            button3.Size = new Size(134, 118);
            button3.TabIndex = 50;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Pedidos1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(215, 51);
            button2.Name = "button2";
            button2.Size = new Size(134, 118);
            button2.TabIndex = 49;
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
            button1.TabIndex = 48;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(207, 358);
            label4.Name = "label4";
            label4.Size = new Size(159, 20);
            label4.TabIndex = 57;
            label4.Text = "Eliminar Tipo de Examen";
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Pedidos1;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(219, 221);
            button4.Name = "button4";
            button4.Size = new Size(134, 118);
            button4.TabIndex = 56;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // submeExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 386);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "submeExam";
            Text = "submeExam";
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
        private Label label4;
        private Button button4;
    }
}