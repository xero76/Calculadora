using Calculadora.Clases;
using Microsoft.VisualBasic;

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
            if (ComprobarVariables() == true)
            {
                Operaciones operaciones = new Operaciones();

                txtResultado.Text = operaciones.Sumar(double.Parse(txtValorA.Text), double.Parse(txtValorB.Text)).ToString();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (ComprobarVariables() == true)
            {
                Operaciones operaciones = new Operaciones();

                txtResultado.Text = operaciones.Restar(double.Parse(txtValorA.Text), double.Parse(txtValorB.Text)).ToString();
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (ComprobarVariables() == true)
            {
                Operaciones operaciones = new Operaciones();

                txtResultado.Text = operaciones.Multiplicar(double.Parse(txtValorA.Text), double.Parse(txtValorB.Text)).ToString();
            }

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (ComprobarVariables() == true)
            {
                if (txtValorB.Text == "0")
                {
                    MessageBox.Show("Las variable B no puede ser 0");
                }
                else
                {
                    Operaciones operaciones = new Operaciones();

                    txtResultado.Text = operaciones.Dividir(double.Parse(txtValorA.Text), double.Parse(txtValorB.Text)).ToString("N3");
                }
            }


        }
        private void btnExponente_Click(object sender, EventArgs e)
        {
            //      Math.Pow(VariableA ,VariableB)
            if (ComprobarVariables() == true)
            {
                if (txtValorB.Text == "0")
                {
                    MessageBox.Show("Las variable B no puede ser 0");
                }
                else
                {
                    Operaciones operaciones = new Operaciones();

                    txtResultado.Text = operaciones.Exponente(double.Parse(txtValorA.Text), double.Parse(txtValorB.Text)).ToString();
                }


            }
        }
            private void btnRaiz_Click(object sender, EventArgs e)
        {
            //      Math.Pow(VariableB ,(1/VariableA ))  Restriccion: B > 0 

            if (ComprobarVariables() == true)
            {
                Double RestriccionA = Double.Parse(txtValorA.Text);
                Double RestriccionB= Double.Parse(txtValorB.Text);
                if ( RestriccionA < 0)
                {
                    MessageBox.Show("La variable A no puede ser menor a 0");
                } else if (0 == 1 )
                {
                    MessageBox.Show("La variable B no puede ser menor a 0");
                }   
                else
                {
                    Operaciones operaciones = new Operaciones();

                    txtResultado.Text = operaciones.RaizCuadrada(double.Parse(txtValorA.Text),double.Parse(txtValorB.Text)).ToString();
                }
            }

        }


        public bool ComprobarVariables()
        {
            bool variablesOk = false;

            if (double.TryParse(txtValorA.Text, out double num1))
            {
                if (double.TryParse(txtValorB.Text, out double num2))
                {
                    variablesOk = true;
                }
                else
                {
                    if (txtValorB.Text == "")
                    {
                        MessageBox.Show("La Variable B esta Vacia");
                    }
                    else
                    {
                        MessageBox.Show("La Variable B no es un numero");
                    }
                }
            }
            else
            {
                if (txtValorA.Text == "")
                {
                    MessageBox.Show("La Variable A esta Vacia");
                }
                else
                {
                    MessageBox.Show("La Variable A no es un numero");
                }
            }
            return variablesOk;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Termina la ejecución de la solucion
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResultado.Text = " ";
            txtValorA.Text = " ";
            txtValorB.Text = " ";
        }

    }
}