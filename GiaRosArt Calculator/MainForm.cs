/*
 * Created by SharpDevelop.
 * User: GiaRosArt
 * Date: 05/07/2023
 * Time: 20:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GiaRosArt_Calculator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmCalculator : Form
	{
		string nmb1 = "";
		string nmb2 = "";
		bool scd = false;
		int type = 0;
		
		public frmCalculator()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			txtRst.Text = "0";
			txtExp.Text = "";
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCClick(object sender, EventArgs e)
		{
			nmb1 = "";
			nmb2 = "";
			scd = false;
			type = 0;
			txtRst.Text = "0";
			txtExp.Text = "";
		}
		
		void Btn1Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "1";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "1";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn2Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "2";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "2";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn3Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "3";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "3";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn4Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "4";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "4";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn5Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "5";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "5";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn6Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "6";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "6";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn7Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "7";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "7";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn8Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "8";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "8";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn9Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "9";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "9";
				txtRst.Text = nmb2;
			}
		}
		
		void Btn0Click(object sender, EventArgs e)
		{
			if (!scd)
			{
				nmb1 += "0";
				txtRst.Text = nmb1;
			}
			else
			{
				nmb2 += "0";
				txtRst.Text = nmb2;
			}
		}
		
		void BtnPntClick(object sender, EventArgs e)
		{
			if (!scd)
			{
				if (nmb1 != "")
				{
					nmb1 += ",";
					txtRst.Text = nmb1;
				}
				else
				{
					nmb1 += "0,";
					txtRst.Text = nmb1;
				}
			}
			else
			{
				if (nmb2 != "")
				{
					nmb2 += ",";
					txtRst.Text = nmb2;
				}
				else
				{
					nmb2 += "0,";
					txtRst.Text = nmb2;
				}
			}
		}
		
		void BtnEqlClick(object sender, EventArgs e)
		{ 
			if(nmb1 != "" && nmb2 != "")
			{
				switch(type)
				{
					case 1:
						txtExp.Text = nmb1 + "+" + nmb2 + "=" + (float.Parse(nmb1) + float.Parse(nmb2)).ToString();
						txtRst.Text = (float.Parse(nmb1) + float.Parse(nmb2)).ToString();
						nmb1 = (float.Parse(nmb1) + float.Parse(nmb2)).ToString();
						break;
					case 2:
						txtExp.Text = nmb1 + "-" + nmb2 + "=" + (float.Parse(nmb1) - float.Parse(nmb2)).ToString();
						txtRst.Text = (float.Parse(nmb1) - float.Parse(nmb2)).ToString();
						nmb1 = (float.Parse(nmb1) - float.Parse(nmb2)).ToString();
						break;
					case 3:
						txtExp.Text = nmb1 + "×" + nmb2 + "=" + (float.Parse(nmb1) * float.Parse(nmb2)).ToString();
						txtRst.Text = (float.Parse(nmb1) * float.Parse(nmb2)).ToString();
						nmb1 = (float.Parse(nmb1) * float.Parse(nmb2)).ToString();
						break;
					case 4:
						txtExp.Text = nmb1 + "÷" + nmb2 + "=" + (float.Parse(nmb1) / float.Parse(nmb2)).ToString();
						txtRst.Text = (float.Parse(nmb1) / float.Parse(nmb2)).ToString();
						nmb1 = (float.Parse(nmb1) / float.Parse(nmb2)).ToString();
						break;
				}
			}
		}
		
		void BtnDvsClick(object sender, EventArgs e)
		{
			if(nmb1 != "")
			{
				scd = true;
				type = 4;
				txtRst.Text = "÷";
				nmb2 = "";
			}
		}
		
		void BtnMltClick(object sender, EventArgs e)
		{
			if(nmb1 != "")
			{
				scd = true;
				type = 3;
				txtRst.Text = "×";
				nmb2 = "";
			}
		}
		
		void BtnSbtClick(object sender, EventArgs e)
		{
			if(nmb1 != "")
			{
				scd = true;
				type = 2;
				txtRst.Text = "-";
				nmb2 = "";
			}
		}
		
		void BtnAddClick(object sender, EventArgs e)
		{
			if(nmb1 != "")
			{
				scd = true;
				type = 1;
				txtRst.Text = "+";
				nmb2 = "";
			}
		}
	}
}
