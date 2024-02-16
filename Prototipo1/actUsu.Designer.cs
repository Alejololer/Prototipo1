namespace Prototipo1
{
    partial class actUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(actUsu));
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Modern No. 20", 11.249999F);
            button1.Location = new Point(158, 164);
            button1.Name = "button1";
            button1.Size = new Size(87, 24);
            button1.TabIndex = 27;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 23);
            textBox2.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Modern No. 20", 11.249999F);
            label4.Location = new Point(24, 128);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 25;
            label4.Text = "Dato nuevo:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nombre de usuario", "Contraseña" });
            comboBox1.Location = new Point(151, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 23);
            comboBox1.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Modern No. 20", 11.249999F);
            label3.Location = new Point(24, 91);
            label3.Name = "label3";
            label3.Size = new Size(115, 17);
            label3.TabIndex = 23;
            label3.Text = "Dato a modificar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Modern No. 20", 11.249999F);
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(125, 17);
            label2.TabIndex = 21;
            label2.Text = "Nombre de usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 24);
            label1.TabIndex = 20;
            label1.Text = "Actualizar Usuario";
            // 
            // actUsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.manodocu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(393, 200);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "actUsu";
            Text = "Actualizacion Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}