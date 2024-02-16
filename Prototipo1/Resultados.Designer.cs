namespace Prototipo1
{
    partial class Resultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resultados));
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 35);
            panel1.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Modern No. 20", 11.249999F);
            label7.Location = new Point(-2, 11);
            label7.Name = "label7";
            label7.Size = new Size(71, 17);
            label7.TabIndex = 55;
            label7.Text = "AmatreSis";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Modern No. 20", 11.249999F);
            label8.Location = new Point(278, 11);
            label8.Name = "label8";
            label8.Size = new Size(291, 17);
            label8.TabIndex = 22;
            label8.Text = "Usuario: Silvana Villegas - Jefe de laboratorio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Modern No. 20", 11.9999981F);
            label3.Location = new Point(446, 173);
            label3.Name = "label3";
            label3.Size = new Size(77, 36);
            label3.TabIndex = 53;
            label3.Text = "Modificar \r\nResultados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 11.9999981F);
            label1.Location = new Point(243, 173);
            label1.Name = "label1";
            label1.Size = new Size(77, 36);
            label1.TabIndex = 52;
            label1.Text = "Consultar \r\nResultados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Modern No. 20", 11.9999981F);
            label4.Location = new Point(48, 173);
            label4.Name = "label4";
            label4.Size = new Size(77, 36);
            label4.TabIndex = 51;
            label4.Text = "Registrar \r\nResultados";
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.Resultados;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(419, 39);
            button3.Name = "button3";
            button3.Size = new Size(134, 118);
            button3.TabIndex = 50;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.Pedidos1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(216, 39);
            button2.Name = "button2";
            button2.Size = new Size(134, 118);
            button2.TabIndex = 49;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Cliente2;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(21, 39);
            button1.Name = "button1";
            button1.Size = new Size(134, 118);
            button1.TabIndex = 48;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Modern No. 20", 11.9999981F);
            label5.Location = new Point(226, 360);
            label5.Name = "label5";
            label5.Size = new Size(117, 18);
            label5.TabIndex = 56;
            label5.Text = "Generar Informe";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.Pedidos1;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(216, 226);
            button4.Name = "button4";
            button4.Size = new Size(134, 118);
            button4.TabIndex = 55;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Resultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.manodocu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(565, 397);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Resultados";
            Text = "Resultados";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label8;
        private Label label3;
        private Label label1;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label5;
        private Button button4;
    }
}