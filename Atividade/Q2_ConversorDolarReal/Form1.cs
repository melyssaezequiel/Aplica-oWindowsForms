namespace Q2_ConversorDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bntConverter_Click(object sender, EventArgs e)
        {

            double Dolar, Quantidade, reais;

            Dolar = Convert.ToDouble(txtCotacao.Text);
            Quantidade = Convert.ToDouble(txtDolar.Text);

            reais = Dolar * Quantidade;

            lblResultado.Text = reais.ToString();
        }
    }
}
