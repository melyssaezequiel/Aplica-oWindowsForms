using System.Windows.Forms;

namespace Tabuadaq2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntgerar_Click(object sender, EventArgs e)
        {
           int num = int.Parse (txtNumero.Text);

            for (int i = 1; i <=10; i++)
            {

                int resultado = num;

                LstTabuada.Items.Add(num + " X " + i + " = " + resultado);
                txtNumero .Clear();
                txtNumero.Focus();
            }

                
        }
        

    }
}
