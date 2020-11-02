/*
 * Created by SharpDevelop.
 * User: user
 * Date: 17/05/2019
 * Time: 5:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PML_CALCULATOR
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button_unit;
		private System.Windows.Forms.Button button_scientific;
		private System.Windows.Forms.Button button_arithmetic;
		private System.Windows.Forms.Button button_currency;
		private System.Windows.Forms.ToolTip toolTiparith;
		private System.Windows.Forms.ToolTip toolTipscien;
		private System.Windows.Forms.ToolTip toolTipunit;
		private System.Windows.Forms.ToolTip toolTipcurrency;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_unit = new System.Windows.Forms.Button();
            this.button_scientific = new System.Windows.Forms.Button();
            this.button_arithmetic = new System.Windows.Forms.Button();
            this.button_currency = new System.Windows.Forms.Button();
            this.toolTiparith = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipscien = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipunit = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipcurrency = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button_unit
            // 
            this.button_unit.BackColor = System.Drawing.Color.Transparent;
            this.button_unit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_unit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_unit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_unit.ForeColor = System.Drawing.Color.Black;
            this.button_unit.Location = new System.Drawing.Point(77, 271);
            this.button_unit.Name = "button_unit";
            this.button_unit.Size = new System.Drawing.Size(273, 53);
            this.button_unit.TabIndex = 0;
            this.button_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipunit.SetToolTip(this.button_unit, "Unit Conversions is a multi-step process that \r\ninvolves multiplication or divisi" +
        "on by a \r\nnumerical factor, selection of the correct \r\nnumber of significant dig" +
        "its, and rounding.");
            this.button_unit.UseVisualStyleBackColor = false;
            this.button_unit.Click += new System.EventHandler(this.Button_unitClick);
            // 
            // button_scientific
            // 
            this.button_scientific.BackColor = System.Drawing.Color.Transparent;
            this.button_scientific.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_scientific.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_scientific.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_scientific.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scientific.ForeColor = System.Drawing.Color.Black;
            this.button_scientific.Location = new System.Drawing.Point(77, 207);
            this.button_scientific.Name = "button_scientific";
            this.button_scientific.Size = new System.Drawing.Size(273, 53);
            this.button_scientific.TabIndex = 1;
            this.button_scientific.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipscien.SetToolTip(this.button_scientific, "This calculator, usually but not always handheld, \r\ndesigned to calculate problem" +
        "s in science, \r\nengineering, and mathematics. ");
            this.button_scientific.UseVisualStyleBackColor = false;
            this.button_scientific.Click += new System.EventHandler(this.Button_scientificClick);
            // 
            // button_arithmetic
            // 
            this.button_arithmetic.BackColor = System.Drawing.Color.Transparent;
            this.button_arithmetic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_arithmetic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_arithmetic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_arithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_arithmetic.ForeColor = System.Drawing.Color.Black;
            this.button_arithmetic.Location = new System.Drawing.Point(77, 139);
            this.button_arithmetic.Name = "button_arithmetic";
            this.button_arithmetic.Size = new System.Drawing.Size(273, 53);
            this.button_arithmetic.TabIndex = 2;
            this.button_arithmetic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTiparith.SetToolTip(this.button_arithmetic, "The basic arithmetic contains the operators \r\nand includes manipulations of \r\nper" +
        "centage and many more.");
            this.button_arithmetic.UseVisualStyleBackColor = false;
            this.button_arithmetic.Click += new System.EventHandler(this.Button2Click);
            // 
            // button_currency
            // 
            this.button_currency.BackColor = System.Drawing.Color.Transparent;
            this.button_currency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_currency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_currency.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_currency.ForeColor = System.Drawing.Color.Black;
            this.button_currency.Location = new System.Drawing.Point(77, 335);
            this.button_currency.Name = "button_currency";
            this.button_currency.Size = new System.Drawing.Size(273, 53);
            this.button_currency.TabIndex = 3;
            this.button_currency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipcurrency.SetToolTip(this.button_currency, "Currency Conversion is a generally accepted \r\nform of money, including coins and " +
        "papers notes. \r\nUsed as a medium of exchange for goods and \r\nservices, currency " +
        "is the basis for trade.");
            this.button_currency.UseVisualStyleBackColor = false;
            this.button_currency.Click += new System.EventHandler(this.Button_currencyClick);
            // 
            // toolTiparith
            // 
            this.toolTiparith.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipscien
            // 
            this.toolTipscien.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipunit
            // 
            this.toolTipunit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // toolTipcurrency
            // 
            this.toolTipcurrency.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 567);
            this.Controls.Add(this.button_currency);
            this.Controls.Add(this.button_arithmetic);
            this.Controls.Add(this.button_scientific);
            this.Controls.Add(this.button_unit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PML_CALCULATOR";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);

		}
	}
}
