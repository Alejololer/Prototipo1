namespace Prototipo1
{
    partial class consultarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(consultarPedido));
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 12);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 12;
            label1.Text = "Pedidos Pendientes";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 49);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(414, 359);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // consultarPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 425);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "consultarPedido";
            Text = "Consultar Pedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private RichTextBox richTextBox1;
    }
}