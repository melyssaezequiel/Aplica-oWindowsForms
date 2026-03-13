using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Q5_CadastroSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                MessageBox.Show("Por favor, preencha os campos");
                return;
            }
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.Idade = txtIdade.Text;

            Repositorio.novapessoa.Add(pessoa);

            ListPessoas.Items.Add($" { pessoa.Nome} {pessoa.Idade}");
        }



     

    }   
            
    
}
              