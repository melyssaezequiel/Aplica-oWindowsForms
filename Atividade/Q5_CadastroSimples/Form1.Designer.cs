namespace Q5_CadastroSimples
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
            ListPessoas = new ListBox();
            label2 = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // ListPessoas
            // 
            ListPessoas.FormattingEnabled = true;
            ListPessoas.ItemHeight = 15;
            ListPessoas.Location = new Point(48, 88);
            ListPessoas.Name = "ListPessoas";
            ListPessoas.Size = new Size(359, 274);
            ListPessoas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 59);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Idade";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(83, 30);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(294, 23);
            txtNome.TabIndex = 3;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(83, 59);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(295, 23);
            txtIdade.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(182, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 450);
            Controls.Add(button1);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(ListPessoas);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox ListPessoas;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Button button1;
    }
}
