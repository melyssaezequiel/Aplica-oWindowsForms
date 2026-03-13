namespace ConversorCelsius_Q1
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
            txtCelsius = new TextBox();
            bntConverter = new Button();
            label2 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 54);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Celsius :";
            label1.Click += label1_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(96, 51);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(140, 23);
            txtCelsius.TabIndex = 1;
            // 
            // bntConverter
            // 
            bntConverter.Location = new Point(124, 84);
            bntConverter.Name = "bntConverter";
            bntConverter.Size = new Size(75, 23);
            bntConverter.TabIndex = 2;
            bntConverter.Text = "converter";
            bntConverter.UseVisualStyleBackColor = true;
            bntConverter.Click += bntConverter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 88);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(144, 124);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 231);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(bntConverter);
            Controls.Add(txtCelsius);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCelsius;
        private Button bntConverter;
        private Label label2;
        private Label lblResultado;
    }
}
