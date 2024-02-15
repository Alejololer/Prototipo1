namespace Prototipo1
{
    partial class consResult2
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 12);
            label3.Name = "label3";
            label3.Size = new Size(276, 32);
            label3.TabIndex = 42;
            label3.Text = "Resultados del examen";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 49);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(358, 148);
            richTextBox1.TabIndex = 43;
            richTextBox1.Text = "Reactivo 1: 12    Rango normal: 10-20\nReactivo 2: 8      Rango normal: 5-15\n\n";
            // 
            // consResult2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 215);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "consResult2";
            Text = "Consultar Resultado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private RichTextBox richTextBox1;
    }
}