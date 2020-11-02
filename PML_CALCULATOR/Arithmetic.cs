
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PML_CALCULATOR
{
	public partial class Arithmetic : Form
	{
		public Arithmetic()
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
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
			MainForm main = new MainForm();
			main.ShowDialog();
			this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
	        double per;
            per = Convert.ToDouble(inputBox.Text) / Convert.ToDouble(100);
            inputBox.Text = System.Convert.ToString(per);
		}
	}
        }