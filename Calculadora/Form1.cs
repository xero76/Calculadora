using Calculadora.Clases;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }


        private void brnSuma_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();

            txtResultado.Text =  operaciones.Sumar( double.Parse(txtValorA.Text), double.Parse(txtValorB.Text)).ToString();

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            txtResultado.Text = operaciones.Restar(Double.Parse(txtValorA.Text), Double.Parse(txtValorB.Text)).ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            txtResultado.Text = operaciones.Multiplicar(Double.Parse(txtValorA.Text), Double.Parse(txtValorB.Text)).ToString();

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {


        }
        private void btnExponente_Click(object sender, EventArgs e)
        {
            //      Math.Pow(VariableA ,VariableB)


        }
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            //      Math.Pow(VariableB ,(1/VariableA ))  Restriccion: B > 0 
        }
    }
}