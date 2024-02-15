namespace Prototipo1
{
    partial class consInfVent
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
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 58);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(423, 72);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "Total de ingresos: NULL$\nExamen con mayores ingresos: Tipo de examen 1\nMes con mayores ingresos: NULL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 12);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 19;
            label1.Text = "Informe de Ventas";
            // 
            // button1
            // 
            button1.Location = new Point(351, 144);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 21;
            button1.Text = "Descargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // consInfVent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 192);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "consInfVent";
            Text = "Consultar Informe Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Button button1;
    }
}