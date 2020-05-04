using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR3_1_2_WF
{
	public partial class practic3 : Form
	{
		public practic3()
		{
			InitializeComponent();
		}
		double length(double x1, double y1, double x2, double y2)
		{
			return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
		}
		double max(double a, double b)
		{
			return (a > b) ? a : b;
		}
		private void calculate_Click(object sender, EventArgs e)
		{
			double x1 = Convert.ToDouble(X1.Text);
			double y1 = Convert.ToDouble(Y1.Text);
			double x2 = Convert.ToDouble(X2.Text);
			double y2 = Convert.ToDouble(Y2.Text);
			double len1 = length(0, 0, x1, y1);
			length1.Text = len1.ToString();
			double len2 = length(0, 0, x2, y2);
			length2.Text = len2.ToString();
			if (max(len1, len2) == len1) dot.Text = "(" + x1.ToString() + ";" + y1.ToString() + ")";
			else dot.Text = "(" + x2.ToString() + ";" + y2.ToString() + ")";
		}

		private void X1_KeyPress(object sender, KeyPressEventArgs e)
		{
			char number = e.KeyChar;
			if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
			{
				e.Handled = true;
			}
		}
		double function(double x)
		{
			double y = 0;
			if (x > 0) y = x;
			if (-1 <= x && x <= 0) y = 0;
			if (x < -1) y = x * x;
			return y;
		}
		private void calculate2_Click(object sender, EventArgs e)
		{
			double a = Convert.ToDouble(border1.Text);
			double b = Convert.ToDouble(border2.Text);
			double h = Convert.ToDouble(step.Text);
			if (h <= 0) MessageBox.Show("Некорректное значение шага");
			else
			{
				string rez = "";
				for (double i = a; i <= b; i += h)
				{
					rez += "y(" + i.ToString() + ") = " + function(i).ToString() + "\n";
				}
				tabel.Text = rez;
			}
			
		}
	}
}
