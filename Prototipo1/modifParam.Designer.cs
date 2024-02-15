namespace Prototipo1
{
    partial class modifParam
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
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(182, 174);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 27;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(175, 122);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 125);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 25;
            label4.Text = "Valor nuevo:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dirección", "Teléfono", "Correo" });
            comboBox1.Location = new Point(175, 69);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 73);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 23;
            label3.Text = "Parámetro a modificar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(399, 32);
            label1.TabIndex = 20;
            label1.Text = "Modificar Parámetros del Sistema";
            // 
            // modifParam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 212);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "modifParam";
            Text = "Modificar Parametros del Sistema";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private Label label1;
    }
}