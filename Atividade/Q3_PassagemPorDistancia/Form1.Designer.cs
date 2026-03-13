namespace Q3_PassagemPorDistancia
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
            txtDistancia = new TextBox();
            lblResultado = new Label();
            bntCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 60);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Distancia";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(123, 57);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(257, 23);
            txtDistancia.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(231, 138);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "label2";
            // 
            // bntCalcular
            // 
            bntCalcular.Location = new Point(216, 99);
            bntCalcular.Name = "bntCalcular";
            bntCalcular.Size = new Size(75, 23);
            bntCalcular.TabIndex = 3;
            bntCalcular.Text = "button1";
            bntCalcular.UseVisualStyleBackColor = true;
            bntCalcular.Click += bntCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 368);
            Controls.Add(bntCalcular);
            Controls.Add(lblResultado);
            Controls.Add(txtDistancia);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDistancia;
        private Label lblResultado;
        private Button bntCalcular;
    }
}
