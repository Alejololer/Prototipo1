namespace Prototipo1
{
    partial class regisResult2
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 118);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 40;
            label7.Text = "Reactivo 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 71);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 39;
            label2.Text = "Reactivo 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 12);
            label3.Name = "label3";
            label3.Size = new Size(276, 32);
            label3.TabIndex = 41;
            label3.Text = "Resultados del examen";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 68);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 42;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 115);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 71);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 44;
            label1.Text = "Rango normal: 10-100";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 118);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 45;
            label4.Text = "Rango normal: 10-100";
            // 
            // button1
            // 
            button1.Location = new Point(74, 165);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 46;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(218, 165);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 47;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // regisResult2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 215);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "regisResult2";
            Text = "Registrar Resultados de Examen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}