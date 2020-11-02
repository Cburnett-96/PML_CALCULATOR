/*
 * Created by SharpDevelop.
 * User: user
 * Date: 17/05/2019
 * Time: 5:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PML_CALCULATOR
{
	partial class Arithmetic
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button b0;
		private System.Windows.Forms.Button button_dot;
		private System.Windows.Forms.Button b1;
		private System.Windows.Forms.Button b2;
		private System.Windows.Forms.Button b4;
		private System.Windows.Forms.Button button_equal;
		private System.Windows.Forms.Button b5;
		private System.Windows.Forms.Button b3;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.Button b7;
		private System.Windows.Forms.Button button_sub;
		private System.Windows.Forms.Button b6;
		private System.Windows.Forms.Button button_add;
		private System.Windows.Forms.Button button_del;
		private System.Windows.Forms.Button b8;
		private System.Windows.Forms.Button button_mul;
		private System.Windows.Forms.Button b9;
		private System.Windows.Forms.Button button_div;
		private System.Windows.Forms.TextBox inputBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arithmetic));
            this.button1 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.button_sub = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_del = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.button_mul = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(348, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.Color.White;
            this.b0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b0.Location = new System.Drawing.Point(50, 332);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(64, 41);
            this.b0.TabIndex = 58;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = false;
            this.b0.Click += new System.EventHandler(this.button_click);
            // 
            // button_dot
            // 
            this.button_dot.BackColor = System.Drawing.Color.White;
            this.button_dot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.button_dot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_dot.Location = new System.Drawing.Point(135, 332);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(64, 41);
            this.button_dot.TabIndex = 57;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = false;
            this.button_dot.Click += new System.EventHandler(this.button_click);
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.White;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b1.Location = new System.Drawing.Point(50, 282);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(64, 41);
            this.b1.TabIndex = 56;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button_click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.White;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b2.Location = new System.Drawing.Point(135, 283);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(64, 41);
            this.b2.TabIndex = 55;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.button_click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.Color.White;
            this.b4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b4.Location = new System.Drawing.Point(50, 233);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(64, 41);
            this.b4.TabIndex = 54;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.button_click);
            // 
            // button_equal
            // 
            this.button_equal.BackColor = System.Drawing.Color.Transparent;
            this.button_equal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_equal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button_equal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_equal.Location = new System.Drawing.Point(220, 333);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(64, 41);
            this.button_equal.TabIndex = 53;
            this.button_equal.UseVisualStyleBackColor = false;
            this.button_equal.Click += new System.EventHandler(this.button15_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.White;
            this.b5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b5.Location = new System.Drawing.Point(135, 232);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(64, 41);
            this.b5.TabIndex = 52;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.button_click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.White;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b3.Location = new System.Drawing.Point(219, 282);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(63, 40);
            this.b3.TabIndex = 51;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button_click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Transparent;
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_clear.Location = new System.Drawing.Point(50, 136);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(64, 41);
            this.button_clear.TabIndex = 50;
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button4_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.Color.White;
            this.b7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b7.Location = new System.Drawing.Point(50, 184);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(64, 41);
            this.b7.TabIndex = 49;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.button_click);
            // 
            // button_sub
            // 
            this.button_sub.BackColor = System.Drawing.Color.Transparent;
            this.button_sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sub.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_sub.Location = new System.Drawing.Point(305, 330);
            this.button_sub.Name = "button_sub";
            this.button_sub.Size = new System.Drawing.Size(64, 41);
            this.button_sub.TabIndex = 48;
            this.button_sub.Text = "-";
            this.button_sub.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_sub.UseVisualStyleBackColor = false;
            this.button_sub.Click += new System.EventHandler(this.operator_click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.Color.White;
            this.b6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b6.Location = new System.Drawing.Point(219, 233);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(64, 42);
            this.b6.TabIndex = 47;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.button_click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_add.Location = new System.Drawing.Point(305, 282);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(64, 41);
            this.button_add.TabIndex = 46;
            this.button_add.Text = "+";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.operator_click);
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.Transparent;
            this.button_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_del.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_del.Location = new System.Drawing.Point(305, 135);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(64, 41);
            this.button_del.TabIndex = 45;
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button5_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.Color.White;
            this.b8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b8.Location = new System.Drawing.Point(135, 183);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(64, 41);
            this.b8.TabIndex = 44;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.button_click);
            // 
            // button_mul
            // 
            this.button_mul.BackColor = System.Drawing.Color.Transparent;
            this.button_mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mul.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_mul.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_mul.Location = new System.Drawing.Point(305, 233);
            this.button_mul.Name = "button_mul";
            this.button_mul.Size = new System.Drawing.Size(64, 41);
            this.button_mul.TabIndex = 43;
            this.button_mul.Text = "*";
            this.button_mul.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_mul.UseVisualStyleBackColor = false;
            this.button_mul.Click += new System.EventHandler(this.operator_click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.Color.White;
            this.b9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.b9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.b9.Location = new System.Drawing.Point(219, 183);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(64, 41);
            this.b9.TabIndex = 42;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.button_click);
            // 
            // button_div
            // 
            this.button_div.BackColor = System.Drawing.Color.Transparent;
            this.button_div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_div.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_div.Location = new System.Drawing.Point(305, 184);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(64, 41);
            this.button_div.TabIndex = 59;
            this.button_div.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_div.UseVisualStyleBackColor = false;
            this.button_div.Click += new System.EventHandler(this.operator_click);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(74, 85);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(270, 31);
            this.inputBox.TabIndex = 41;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(135, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 41);
            this.button2.TabIndex = 60;
            this.button2.Text = "+/-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(219, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 41);
            this.button3.TabIndex = 61;
            this.button3.Text = "%";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // Arithmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(416, 420);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.button_sub);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_del);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.button_mul);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Arithmetic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arithmetic";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}
