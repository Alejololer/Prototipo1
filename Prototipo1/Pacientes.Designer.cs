namespace Prototipo1
{
    partial class Pacientes
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(473, 320);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 20;
            label3.Text = "Resultados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(277, 299);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 19;
            label2.Text = "Pedidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(59, 275);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 18;
            label1.Text = "Pacientes";
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Resultados;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(438, 105);
            button3.Name = "button3";
            button3.Size = new Size(134, 118);
            button3.TabIndex = 14;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Pedidos1;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(233, 105);
            button2.Name = "button2";
            button2.Size = new Size(134, 118);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Cliente2;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(28, 105);
            button1.Name = "button1";
            button1.Size = new Size(134, 118);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = true;
            // 
            // Pacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 372);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Pacientes";
            Text = "Pacientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}