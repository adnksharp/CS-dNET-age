using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age
{
	public partial class Form1 : Form
	{
		string[] Month = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
		byte c;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "Calcular edad";
			label2.Text = "Fecha de nacimiento";
			label3.Text = "";
			for (c = 0; c < 122; c++)
				comboBox1.Items.Add( (2022 - c).ToString() );
			for (c = 0; c < Month.Length; c++)
				comboBox2.Items.Add(Month[c]);
		}

		private void CB1SIC(object sender, EventArgs e)
		{
			if (comboBox2.Enabled == false) comboBox2.Enabled = true;
			else SetMonth((byte)comboBox2.SelectedIndex, int.Parse(comboBox1.SelectedItem.ToString()));
		}

		private void CB2SIC(object sender, EventArgs e)
		{
			if (comboBox3.Enabled == false) comboBox3.Enabled = true;
			SetMonth((byte)comboBox2.SelectedIndex, int.Parse(comboBox1.SelectedItem.ToString()));
		}

		private void CB3SIC(object sender, EventArgs e)
		{
			GetOld(int.Parse(comboBox3.SelectedItem.ToString()), (int)comboBox2.SelectedIndex, int.Parse(comboBox1.SelectedItem.ToString()));
		}

		public void SetMonth(byte c, int d)
		{
			byte k = Days(c, d);
			comboBox3.Items.Clear();
			for (c = 0; c < k; c++)
				comboBox3.Items.Add(k - c);
		}

		public byte Days(byte j, int i)
		{
			byte md;
			if (j == 1)
				if (i % 4 == 0) md = 29;
				else md = 28;
			else if (j < 7)
			{
				if (j % 2 == 0)
					md = 31;
				else md = 30;
			}
			else
			{
				if (j % 2 == 1)
					md = 31;
				else
					md = 30;
			}
			return md;
		}

		public void GetOld ( int DD, int MM, int YYYY )
		{
			DD++; MM++;
			int d = 0;
			int[] Today = {
				int.Parse(DateTime.Today.ToString("dd")),
				int.Parse(DateTime.Today.ToString("MM")),
				int.Parse(DateTime.Today.ToString("yyyy"))
			}, 
			Age = { 0, 0, 0 };

			Age[2] += Today[2] - YYYY;

			Age[1] += Today[1] - MM;
			if (Age[1] < 1)
			{
			}

			Age[0] += Today[0] - DD;
			if (Age[0] < 0)
			{
				Age[0] += Days((byte)Today[1], int.Parse(comboBox1.SelectedItem.ToString()));
				Age[1]--;
				if (MM == 3)
					Age[0] -= 3;
				if (MM == 5 || MM == 7 || MM == 10 || MM == 12)
					Age[0]--;
			}

			if (Age[1] < 0)
			{
				Age[2]--;
				Age[1] += 12;
			}
			Age[0]++;

			label3.Text = Age[2].ToString() + " años, " + Age[1].ToString() + " meses y " + Age[0].ToString() + " días.";
			/*
			Today[2] = Today[2] - YYYY;

			for (c = 0; c <= MM; c++)
				d += Days(c, Today[2]);
			DD += d;
			d = 0;
			for (c = 0; c <= Today[1]; c++)
				d += Days(c, Today[2]);

			Today[0] += d;

			if (Today[1] > MM)
			{
				Today[1] -= MM;
			}
			else
			{
				Today[2]--;
				Today[1] = 12 + Today[1] - MM;
			}
			if (Today[0] > DD)
			{
				Today[0] -= DD;
				if (Today[1] == 1)
					Today[0] -= 2;
			}
			else
			{
				Today[0] += 2;
				if (int.Parse(DateTime.Today.ToString("yyyy")) % 4 == 0)
					Today[0] = 366 + Today[0] - DD;
				else
					Today[0] = 365 + Today[0] - DD;
			}
			for(c = 0; c < 12; c++)
			{
				if (Today[0] - Days(c, int.Parse(DateTime.Today.ToString("yyyy"))) > -1)
					Today[0] -= Days(c, int.Parse(DateTime.Today.ToString("yyyy")));
				else
					break;
			}
			label3.Text = Today[2].ToString() + " años, " + Today[1].ToString() + " meses y " + Today[0].ToString() + " días.";
			*/
		}
	}
}
