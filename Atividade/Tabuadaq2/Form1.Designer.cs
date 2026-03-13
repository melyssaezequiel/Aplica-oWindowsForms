namespace Tabuadaq2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LstTabuada = new ListBox();
            label1 = new Label();
            bntgerar = new Button();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // LstTabuada
            // 
            LstTabuada.FormattingEnabled = true;
            LstTabuada.ItemHeight = 15;
            LstTabuada.Location = new Point(47, 90);
            LstTabuada.Name = "LstTabuada";
            LstTabuada.Size = new Size(283, 274);
            LstTabuada.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 64);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero";
            // 
            // bntgerar
            // 
            bntgerar.Location = new Point(148, 383);
            bntgerar.Name = "bntgerar";
            bntgerar.Size = new Size(75, 23);
            bntgerar.TabIndex = 2;
            bntgerar.Text = "Gerar";
            bntgerar.UseVisualStyleBackColor = true;
            bntgerar.Click += bntgerar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(104, 61);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(226, 23);
            txtNumero.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 450);
            Controls.Add(txtNumero);
            Controls.Add(bntgerar);
            Controls.Add(label1);
            Controls.Add(LstTabuada);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstTabuada;
        private Label label1;
        private Button bntgerar;
        private TextBox txtNumero;
    }
}
