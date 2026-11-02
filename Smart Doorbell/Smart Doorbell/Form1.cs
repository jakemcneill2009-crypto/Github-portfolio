using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Doorbell
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public int time;
		DateTime[] TimeOfRing = new DateTime[10];
		public bool valid = false;
		public int emptySlot;
		public string Object = "human";
		private void timer1_Tick(object sender, EventArgs e)
		{
			time = DateTime.Now.Hour;
		}

		private void btnRing_Click(object sender, EventArgs e)
		{
			if (time > 8 && time <22 && Object == "human")
			{
				MessageBox.Show("Ring");
			}
			else
			{
				valid = false;
				MessageBox.Show("Don't Ring");
				for (int i = 0; i < TimeOfRing.Length - 1; i++)
				{
					if(TimeOfRing[i] == null)
					{
						valid = true;
					}
					if(valid == true)
					{
						emptySlot = i;
						TimeOfRing[i] = DateTime.Now;
						break;
					}
				}
				
			}
		}
	}
}
