
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PML_CALCULATOR
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button_unitClick(object sender, EventArgs e)
		{
			this.Hide();
			Unit un = new Unit();
			un.ShowDialog();
			this.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
			Arithmetic arith = new Arithmetic();
			arith.ShowDialog();
			this.Close();
		}
		void Button_scientificClick(object sender, EventArgs e)
		{
			this.Hide();
			Scientific sci = new Scientific();
			sci.ShowDialog();
			this.Close();
		}
		void Button_currencyClick(object sender, EventArgs e)
		{
			this.Hide();
			Currency cur = new Currency();
			cur.ShowDialog();
			this.Close();
		}
	}
}
