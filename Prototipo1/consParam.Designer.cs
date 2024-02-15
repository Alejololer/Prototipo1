namespace Prototipo1
{
    partial class consParam
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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 49);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(414, 193);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "Parámetro 1\nNombre:\nIVA\nValor:\n12\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 12);
            label1.Name = "label1";
            label1.Size = new Size(281, 32);
            label1.TabIndex = 20;
            label1.Text = "Parámetros del Sistema";
            // 
            // consParam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 256);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "consParam";
            Text = "Consultar Parametro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
    }
}