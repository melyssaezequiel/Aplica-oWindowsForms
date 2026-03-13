using System.Diagnostics.Eventing.Reader;

namespace Q3_PassagemPorDistancia
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

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double distancia, calculo;

            distancia = Convert.ToDouble(txtDistancia.Text);
            


            if (distancia <= 200)
            {

              calculo =  distancia * 0.50;
                lblResultado.Text = calculo.ToString();
            }
            else
            {
               calculo = distancia  * 0.45;
                lblResultado.Text = calculo.ToString();
            }
                
            
            

          


           


        }
    }
}
