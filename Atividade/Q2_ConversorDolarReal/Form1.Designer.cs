namespace Q2_ConversorDolarReal
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
            label1 = new Label();
            txtCotacao = new TextBox();
            txtDolar = new TextBox();
            label2 = new Label();
            bntConverter = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Cotação dolar (R$):";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(157, 70);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(233, 23);
            txtCotacao.TabIndex = 1;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(157, 137);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(233, 23);
            txtDolar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 102);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 3;
            label2.Text = "Quantidade em dolares (U$):";
            label2.Click += label2_Click;
            // 
            // bntConverter
            // 
            bntConverter.Location = new Point(236, 182);
            bntConverter.Name = "bntConverter";
            bntConverter.Size = new Size(75, 23);
            bntConverter.TabIndex = 4;
            bntConverter.Text = "button1";
            bntConverter.UseVisualStyleBackColor = true;
            bntConverter.Click += bntConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(255, 223);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 450);
            Controls.Add(lblResultado);
            Controls.Add(bntConverter);
            Controls.Add(label2);
            Controls.Add(txtDolar);
            Controls.Add(txtCotacao);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCotacao;
        private TextBox txtDolar;
        private Label label2;
        private Button bntConverter;
        private Label lblResultado;
    }
}
