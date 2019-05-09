using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        
        public frmCalculadora()
        {
            InitializeComponent();
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "1";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "1";
            }

            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "2";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "3";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "4";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "5";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "6";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "7";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "8";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "9";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "0";
            }
            else
            {
                txtResultado.Text = txtResultado.Text + "0";
            }
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            txtSinal.Text = "";
            txtValorAuxiliar.Text = "0";
            btnVoltar.Enabled = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            


            txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);

            if (txtResultado.Text == "")
            {
                txtResultado.Text = "0";
            }

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtValorAuxiliar.Text = txtResultado.Text;
            txtSinal.Text = "+";
            txtResultado.Text = "0";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtValorAuxiliar.Text = txtResultado.Text;
            txtSinal.Text = "-";
            txtResultado.Text = "0";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtValorAuxiliar.Text = txtResultado.Text;
            txtSinal.Text = "x";
            txtResultado.Text = "0";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtValorAuxiliar.Text = txtResultado.Text;
            txtSinal.Text = "÷";
            txtResultado.Text = "0";
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal valor1, valor2, resultado;
            string sinal;

            valor1 = Convert.ToDecimal(txtValorAuxiliar.Text);

            valor2 = Convert.ToDecimal (txtResultado.Text);
            resultado = 0;

            sinal = txtSinal.Text;

            if (sinal == "÷" && valor2 == 0)
            {
                MessageBox.Show("não pode dividir por zero");
            }
            else
            {
                switch (sinal)
                {
                    case "+":
                        resultado = valor1 + valor2;
                        break;


                    case "-":
                        resultado = valor1 - valor2;
                        break;

                    case "÷":
                        resultado = valor1 / valor2;
                        break;

                    case "x":
                        resultado = valor1 * valor2;
                        break;

                }
                txtResultado.Text = Convert.ToString(resultado);
                
            }

            

        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains  (",") )
            {
                txtResultado.Text = txtResultado.Text + ",";
            }
         
        }

        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }*/

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }





        }
    }
}
