using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
	public partial class Caculators : Form
	{
		public Caculators()
		{
			InitializeComponent();
		}
		float data1, data2;
		string pheptinh;
		private void button4_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "0";
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "0";

		}

		private void btn1_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "1";
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "2";
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "3";
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "5";
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "6";
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "7";
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "8";
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			textHienThi1.Text = textHienThi1.Text + "9";
		}

		private void btnCong_Click(object sender, EventArgs e)
		{
			pheptinh = "Cong";
			data1=float.Parse(textHienThi1.Text);
			textHienThi1.Clear();
		}

		private void btnBang_Click(object sender, EventArgs e)
		{
			if(pheptinh=="Cong")
			{
				data2=data1+float.Parse(textHienThi1.Text);
				textHienThi2.Text = data1.ToString() + " + " + float.Parse(textHienThi1.Text) + " = ";
				textHienThi1.Text=data2.ToString();
			}
			if (pheptinh == "Tru")
			{
				data2 = data1 - float.Parse(textHienThi1.Text);
				textHienThi2.Text = data1.ToString() + " - " + float.Parse(textHienThi1.Text) + " = ";
				textHienThi1.Text = data2.ToString();
			}
			if (pheptinh == "Nhan")
			{
				data2 = data1 * float.Parse(textHienThi1.Text);
				textHienThi2.Text = data1.ToString() + " * " + float.Parse(textHienThi1.Text) + " = ";
				textHienThi1.Text = data2.ToString();
			}
			if (pheptinh == "Chia")
			{
				if (float.Parse(textHienThi1.Text) == 0)
				{
					textHienThi1.Text = "Không chia được";
				}
				else
				{
					data2 = data1 / float.Parse(textHienThi1.Text);
					textHienThi2.Text = data1.ToString() + " / " + float.Parse(textHienThi1.Text) + " = ";
					textHienThi1.Text = data2.ToString();
				}
			}
		}

		private void btnTru_Click(object sender, EventArgs e)
		{
			{
				pheptinh = "Tru";
				data1 = float.Parse(textHienThi1.Text);
				textHienThi1.Clear();
			}
		}

		private void btnNhan_Click(object sender, EventArgs e)
		{
			{
				pheptinh = "Nhan";
				data1 = float.Parse(textHienThi1.Text);
				textHienThi1.Clear();
			}
		}

		private void btnChiak_Click(object sender, EventArgs e)
		{
			{
				pheptinh = "Chia";
				data1 = float.Parse(textHienThi1.Text);
				textHienThi1.Clear();
			}
		}

		private void Caculators_Load(object sender, EventArgs e)
		{

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			textHienThi1.Clear();
			textHienThi2.Clear();
		}
	}
}
