
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PML_CALCULATOR
{
	public partial class Scientific : Form
	{
		public Scientific()
		{
			InitializeComponent();
		}
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

       private void button_click(object sender, EventArgs e)
        {
            if ((inputBox.Text == "0") || (isOperationPerformed))
                inputBox.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            { 
               if(!inputBox.Text.Contains("."))
                   inputBox.Text = inputBox.Text + button.Text;

            }else
            inputBox.Text = inputBox.Text + button.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(inputBox.Text);
                isOperationPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        	inputBox.ResetText();
        	operationPerformed = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
			inputBox.ResetText();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    inputBox.Text = (resultValue + Double.Parse(inputBox.Text)).ToString();
                    break;
                case "-":
                    inputBox.Text = (resultValue - Double.Parse(inputBox.Text)).ToString();
                    break;
                case "*":
                    inputBox.Text = (resultValue * Double.Parse(inputBox.Text)).ToString();
                    break;
                case "/":
                    inputBox.Text = (resultValue / Double.Parse(inputBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
		void Button2Click(object sender, EventArgs e)
		{
			if (inputBox.Text.Contains("-"))
			{
				
				inputBox.Text = inputBox.Text.Remove(0,1);
			
			}
				else
				{
				inputBox.Text = "-" + inputBox.Text;
				}
		}
		void Button13Click(object sender, EventArgs e)
		{
	      inputBox.Text = (Math.Tan(double.Parse(inputBox.Text))).ToString();
		}
		void Button15Click(object sender, EventArgs e)
		{
	inputBox.Text = (Math.Sin(double.Parse(inputBox.Text))).ToString();
		}
		void Button14Click(object sender, EventArgs e)
		{
	inputBox.Text = (Math.Cos(double.Parse(inputBox.Text))).ToString();
		}
		void Button30Click(object sender, EventArgs e)
		{
	inputBox.Text = (Math.Log(double.Parse(inputBox.Text))).ToString();
		}
		void Button23Click(object sender, EventArgs e)
		{
            double xa;
            xa = Convert.ToDouble(inputBox.Text) * Convert.ToDouble(inputBox.Text);
            inputBox.Text = System.Convert.ToString(xa);
		}
		void Button29Click(object sender, EventArgs e)
		{
	           long f = 1;
            for (long i = 1; i <= long.Parse(inputBox.Text); i++)
            {
                f = f * i;
            }
            inputBox.Text = f.ToString();
		}
		void Button10Click(object sender, EventArgs e)
		{
	        double isinh = Double.Parse(inputBox.Text);
            isinh = Math.Sinh(isinh);
            inputBox.Text = System.Convert.ToString(isinh);
		}
		void Button9Click(object sender, EventArgs e)
		{
	        double icosh = Double.Parse(inputBox.Text);
            icosh = Math.Cosh(icosh);
            inputBox.Text = System.Convert.ToString(icosh);
		}
		void Button8Click(object sender, EventArgs e)
		{
            double iTanh = Double.Parse(inputBox.Text);
            iTanh = Math.Tanh(iTanh);
            inputBox.Text = System.Convert.ToString(iTanh);
		}
		void Button20Click(object sender, EventArgs e)
		{
            double xa;
            xa = Convert.ToDouble(inputBox.Text) * Convert.ToDouble(inputBox.Text)* Convert.ToDouble(inputBox.Text);
            inputBox.Text = System.Convert.ToString(xa);
		}
		void Button26Click(object sender, EventArgs e)
		{
	        double xa;
            xa = Convert.ToDouble (1.0/ Convert.ToDouble(inputBox.Text));
            inputBox.Text = System.Convert.ToString(xa);
		}
		void Button7Click(object sender, EventArgs e)
		{
	       double ilog = Double.Parse(inputBox.Text);
            ilog = Math.Log(ilog);
            inputBox.Text = System.Convert.ToString(ilog);
		}
		void Button111Click(object sender, EventArgs e)
		{
	inputBox.Text = (Math.Sqrt(double.Parse(inputBox.Text))).ToString();
		}
		void Button22Click(object sender, EventArgs e)
		{
	
		}
		void Button6Click(object sender, EventArgs e)
		{
	
		}
		void Button25Click(object sender, EventArgs e)
		{
			double sign;
	              try
            {
             if (inputBox.Text.Length != 0)
             {
            double l;
            
            l = Math.Exp(Convert.ToDouble(inputBox.Text));
            inputBox.Text = Convert.ToString(l);
            }
             sign = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
		void Button24Click(object sender, EventArgs e)
		{
			double no1 = Double.Parse(inputBox.Text);
			no1 = Convert.ToDouble(inputBox.Text) * Convert.ToDouble(inputBox.Text) / Convert.ToDouble(inputBox.Text);
			inputBox.Text = System.Convert.ToString(no1);
		}
		void Button_menuClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm main = new MainForm();
			main.ShowDialog();
			this.Close();
		}
}
}