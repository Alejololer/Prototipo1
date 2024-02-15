namespace Prototipo1
{
    partial class Form2
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Cliente2;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(30, 24);
            button1.Name = "button1";
            button1.Size = new Size(134, 118);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Pedidos1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(234, 24);
            button2.Name = "button2";
            button2.Size = new Size(134, 118);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Resultados;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(438, 24);
            button3.Name = "button3";
            button3.Size = new Size(134, 118);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.Inventario1;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Location = new Point(30, 198);
            button4.Name = "button4";
            button4.Size = new Size(134, 118);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.Ventas;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Location = new Point(234, 198);
            button5.Name = "button5";
            button5.Size = new Size(134, 118);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += this.button5_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.AdmSistema;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Location = new Point(438, 198);
            button6.Name = "button6";
            button6.Size = new Size(134, 118);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(63, 160);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 6;
            label1.Text = "Pacientes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(271, 160);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 7;
            label2.Text = "Pedidos";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(467, 160);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 8;
            label3.Text = "Resultados";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(58, 334);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 9;
            label4.Text = "Suministros";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F);
            label5.Location = new Point(276, 334);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "Ventas";
            label5.Click += this.label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F);
            label6.Location = new Point(447, 334);
            label6.Name = "label6";
            label6.Size = new Size(116, 20);
            label6.TabIndex = 11;
            label6.Text = "Adm. del Sistema";
            label6.Click += label6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 372);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}