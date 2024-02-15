namespace Prototipo1
{
    partial class elimUsu
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Usuario 2", "Usuario 3" });
            comboBox1.Location = new Point(106, 46);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 23);
            comboBox1.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(296, 86);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 26;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 49);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 25;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 24;
            label1.Text = "Eliminar Usuario:";
            // 
            // elimUsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 124);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "elimUsu";
            Text = "elimUsu";
            Load += elimUsu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}