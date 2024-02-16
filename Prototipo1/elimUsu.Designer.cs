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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elimUsu));
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
            comboBox1.Location = new Point(106, 49);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 23);
            comboBox1.TabIndex = 27;
            // 
            // button1
            // 
            button1.Font = new Font("Modern No. 20", 11.249999F);
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
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Modern No. 20", 11.249999F);
            label2.Location = new Point(21, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 25;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Modern No. 20", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 24);
            label1.TabIndex = 24;
            label1.Text = "Eliminar Usuario";
            // 
            // elimUsu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.manodocu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(387, 124);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "elimUsu";
            Text = "Eliminar Usuario";
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