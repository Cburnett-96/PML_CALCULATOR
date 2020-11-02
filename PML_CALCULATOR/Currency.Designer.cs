/*
 * Created by SharpDevelop.
 * User: user
 * Date: 17/05/2019
 * Time: 5:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PML_CALCULATOR
{
	partial class Currency
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button_menu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton dollar;
		private System.Windows.Forms.RadioButton won;
		private System.Windows.Forms.RadioButton yen;
		private System.Windows.Forms.RadioButton dirham;
		private System.Windows.Forms.RadioButton riyal;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Currency));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dollar = new System.Windows.Forms.RadioButton();
            this.won = new System.Windows.Forms.RadioButton();
            this.yen = new System.Windows.Forms.RadioButton();
            this.dirham = new System.Windows.Forms.RadioButton();
            this.riyal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(388, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(201, 31);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(121, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 31);
            this.textBox1.TabIndex = 11;
            // 
            // button_menu
            // 
            this.button_menu.BackColor = System.Drawing.Color.Transparent;
            this.button_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_menu.Location = new System.Drawing.Point(602, 25);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(75, 38);
            this.button_menu.TabIndex = 19;
            this.button_menu.Text = "Menu";
            this.button_menu.UseVisualStyleBackColor = false;
            this.button_menu.Click += new System.EventHandler(this.Button_menuClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pesos (PHP)";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Currency Converter";
            // 
            // dollar
            // 
            this.dollar.BackColor = System.Drawing.Color.Transparent;
            this.dollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollar.Location = new System.Drawing.Point(121, 131);
            this.dollar.Name = "dollar";
            this.dollar.Size = new System.Drawing.Size(125, 33);
            this.dollar.TabIndex = 22;
            this.dollar.TabStop = true;
            this.dollar.Text = "Dollar (US)";
            this.dollar.UseVisualStyleBackColor = false;
            // 
            // won
            // 
            this.won.BackColor = System.Drawing.Color.Transparent;
            this.won.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.won.Location = new System.Drawing.Point(120, 183);
            this.won.Name = "won";
            this.won.Size = new System.Drawing.Size(167, 31);
            this.won.TabIndex = 23;
            this.won.TabStop = true;
            this.won.Text = "Won (Korean)";
            this.won.UseVisualStyleBackColor = false;
            // 
            // yen
            // 
            this.yen.BackColor = System.Drawing.Color.Transparent;
            this.yen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yen.Location = new System.Drawing.Point(121, 235);
            this.yen.Name = "yen";
            this.yen.Size = new System.Drawing.Size(166, 28);
            this.yen.TabIndex = 24;
            this.yen.TabStop = true;
            this.yen.Text = "Yen (Japanese)";
            this.yen.UseVisualStyleBackColor = false;
            // 
            // dirham
            // 
            this.dirham.BackColor = System.Drawing.Color.Transparent;
            this.dirham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirham.Location = new System.Drawing.Point(119, 281);
            this.dirham.Name = "dirham";
            this.dirham.Size = new System.Drawing.Size(148, 34);
            this.dirham.TabIndex = 25;
            this.dirham.TabStop = true;
            this.dirham.Text = "Dirham (UAE)";
            this.dirham.UseVisualStyleBackColor = false;
            // 
            // riyal
            // 
            this.riyal.BackColor = System.Drawing.Color.Transparent;
            this.riyal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riyal.Location = new System.Drawing.Point(119, 334);
            this.riyal.Name = "riyal";
            this.riyal.Size = new System.Drawing.Size(148, 30);
            this.riyal.TabIndex = 26;
            this.riyal.TabStop = true;
            this.riyal.Text = "Riyal (Qatar)";
            this.riyal.UseVisualStyleBackColor = false;
            // 
            // Currency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(708, 407);
            this.Controls.Add(this.riyal);
            this.Controls.Add(this.dirham);
            this.Controls.Add(this.yen);
            this.Controls.Add(this.won);
            this.Controls.Add(this.dollar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Currency";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency";
            this.Load += new System.EventHandler(this.CurrencyLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
