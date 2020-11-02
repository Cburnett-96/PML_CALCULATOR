
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PML_CALCULATOR
{
	public partial class Currency : Form
	{
		public Currency()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
	//USA
	
	if(dollar.Checked){
			double answer1;
			double cdollar= 50.05;
			double answer;
		
			answer1 = Double.Parse(textBox1.Text);
			answer = cdollar*answer1;
			textBox2.Text = answer.ToString();
	}
	//Japan	
	else if(yen.Checked){
			double result1;
			double cyen= 0.48;
			double result;
		
			result1 = Double.Parse(textBox1.Text);
			result = cyen*result1;
			textBox2.Text = result.ToString();
	}
	//UAE
	else if(dirham.Checked){	
			double wow1;
			double cdirham= 14.34;
			double wow;
		
			wow1 = Double.Parse(textBox1.Text);
			wow = cdirham*wow1;
			textBox2.Text = wow.ToString();
	}
			
	//Qatar	
	else if(riyal.Checked){
			double nice1;
			double criyal= 14.05;
			double nice;
		
			nice1 = Double.Parse(textBox1.Text);
			nice = criyal*nice1;
			textBox2.Text = nice.ToString();
	}
			
	//Korea
	else if(won.Checked){
			double boom1;
			double cwon= 0.044;
			double boom;
		
			boom1 = Double.Parse(textBox1.Text);
			boom = cwon*boom1;
			textBox2.Text = boom.ToString();
	}
	}
		void Button_menuClick(object sender, EventArgs e)
		{
			this.Hide();
			MainForm main = new MainForm();
			main.ShowDialog();
			this.Close();
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		void CurrencyLoad(object sender, EventArgs e)
		{
	
		}
}
}