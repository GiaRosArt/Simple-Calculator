/*
 * Created by SharpDevelop.
 * User: GiaRosArt
 * Date: 05/07/2023
 * Time: 20:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GiaRosArt_Calculator
{
	partial class frmCalculator
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
			this.txtRst = new System.Windows.Forms.TextBox();
			this.btn7 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btnDvs = new System.Windows.Forms.Button();
			this.btnMlt = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btnSbt = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnEql = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btnPnt = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtExp = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtRst
			// 
			this.txtRst.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtRst.Font = new System.Drawing.Font("Prestige Elite Std", 24F, System.Drawing.FontStyle.Bold);
			this.txtRst.Location = new System.Drawing.Point(12, 12);
			this.txtRst.Name = "txtRst";
			this.txtRst.ReadOnly = true;
			this.txtRst.Size = new System.Drawing.Size(256, 65);
			this.txtRst.TabIndex = 0;
			this.txtRst.Text = "0";
			this.txtRst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn7
			// 
			this.btn7.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn7.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(12, 130);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(53, 43);
			this.btn7.TabIndex = 1;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = false;
			this.btn7.Click += new System.EventHandler(this.Btn7Click);
			// 
			// btn8
			// 
			this.btn8.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn8.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(79, 130);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(53, 43);
			this.btn8.TabIndex = 2;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = false;
			this.btn8.Click += new System.EventHandler(this.Btn8Click);
			// 
			// btn9
			// 
			this.btn9.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn9.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(146, 130);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(53, 43);
			this.btn9.TabIndex = 3;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = false;
			this.btn9.Click += new System.EventHandler(this.Btn9Click);
			// 
			// btnDvs
			// 
			this.btnDvs.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnDvs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDvs.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDvs.Location = new System.Drawing.Point(214, 130);
			this.btnDvs.Name = "btnDvs";
			this.btnDvs.Size = new System.Drawing.Size(54, 43);
			this.btnDvs.TabIndex = 4;
			this.btnDvs.Text = "÷";
			this.btnDvs.UseVisualStyleBackColor = false;
			this.btnDvs.Click += new System.EventHandler(this.BtnDvsClick);
			// 
			// btnMlt
			// 
			this.btnMlt.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnMlt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMlt.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMlt.Location = new System.Drawing.Point(214, 189);
			this.btnMlt.Name = "btnMlt";
			this.btnMlt.Size = new System.Drawing.Size(54, 43);
			this.btnMlt.TabIndex = 8;
			this.btnMlt.Text = "×";
			this.btnMlt.UseVisualStyleBackColor = false;
			this.btnMlt.Click += new System.EventHandler(this.BtnMltClick);
			// 
			// btn6
			// 
			this.btn6.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn6.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(145, 189);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(53, 43);
			this.btn6.TabIndex = 7;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = false;
			this.btn6.Click += new System.EventHandler(this.Btn6Click);
			// 
			// btn5
			// 
			this.btn5.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn5.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(78, 189);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(53, 43);
			this.btn5.TabIndex = 6;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = false;
			this.btn5.Click += new System.EventHandler(this.Btn5Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn4.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(11, 189);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(53, 43);
			this.btn4.TabIndex = 5;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.Btn4Click);
			// 
			// btnSbt
			// 
			this.btnSbt.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnSbt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSbt.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSbt.Location = new System.Drawing.Point(214, 251);
			this.btnSbt.Name = "btnSbt";
			this.btnSbt.Size = new System.Drawing.Size(54, 43);
			this.btnSbt.TabIndex = 12;
			this.btnSbt.Text = "-";
			this.btnSbt.UseVisualStyleBackColor = false;
			this.btnSbt.Click += new System.EventHandler(this.BtnSbtClick);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn3.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(146, 251);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(53, 43);
			this.btn3.TabIndex = 11;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.Btn3Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn2.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(79, 251);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(53, 43);
			this.btn2.TabIndex = 10;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn1.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(12, 251);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(53, 43);
			this.btn1.TabIndex = 9;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAdd.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(214, 313);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(54, 43);
			this.btnAdd.TabIndex = 16;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
			// 
			// btnEql
			// 
			this.btnEql.BackColor = System.Drawing.Color.Red;
			this.btnEql.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEql.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEql.Location = new System.Drawing.Point(146, 313);
			this.btnEql.Name = "btnEql";
			this.btnEql.Size = new System.Drawing.Size(53, 43);
			this.btnEql.TabIndex = 15;
			this.btnEql.Text = "=";
			this.btnEql.UseVisualStyleBackColor = false;
			this.btnEql.Click += new System.EventHandler(this.BtnEqlClick);
			// 
			// btn0
			// 
			this.btn0.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn0.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.Location = new System.Drawing.Point(79, 313);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(53, 43);
			this.btn0.TabIndex = 14;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = false;
			this.btn0.Click += new System.EventHandler(this.Btn0Click);
			// 
			// btnPnt
			// 
			this.btnPnt.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.btnPnt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPnt.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPnt.Location = new System.Drawing.Point(12, 313);
			this.btnPnt.Name = "btnPnt";
			this.btnPnt.Size = new System.Drawing.Size(53, 43);
			this.btnPnt.TabIndex = 13;
			this.btnPnt.Text = ".";
			this.btnPnt.UseVisualStyleBackColor = false;
			this.btnPnt.Click += new System.EventHandler(this.BtnPntClick);
			// 
			// btnC
			// 
			this.btnC.BackColor = System.Drawing.Color.Red;
			this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnC.Font = new System.Drawing.Font("Arial Black", 8F);
			this.btnC.Location = new System.Drawing.Point(146, 69);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(122, 27);
			this.btnC.TabIndex = 17;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = false;
			this.btnC.Click += new System.EventHandler(this.BtnCClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pictureBox1.Location = new System.Drawing.Point(-3, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(291, 115);
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// txtExp
			// 
			this.txtExp.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.txtExp.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold);
			this.txtExp.Location = new System.Drawing.Point(12, 69);
			this.txtExp.Name = "txtExp";
			this.txtExp.ReadOnly = true;
			this.txtExp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtExp.Size = new System.Drawing.Size(119, 36);
			this.txtExp.TabIndex = 19;
			this.txtExp.Text = "0";
			// 
			// frmCalculator
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(280, 370);
			this.Controls.Add(this.txtExp);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnEql);
			this.Controls.Add(this.btn0);
			this.Controls.Add(this.btnPnt);
			this.Controls.Add(this.btnSbt);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.btnMlt);
			this.Controls.Add(this.btn6);
			this.Controls.Add(this.btn5);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btnDvs);
			this.Controls.Add(this.btn9);
			this.Controls.Add(this.btn8);
			this.Controls.Add(this.btn7);
			this.Controls.Add(this.txtRst);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmCalculator";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GiaRosArt Calculator";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtExp;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnPnt;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btnEql;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btnSbt;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btnMlt;
		private System.Windows.Forms.Button btnDvs;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.TextBox txtRst;
	}
}
