using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BaysideHighSchool
{
	public partial class frmReport : Form
	{
		public frmReport()
		{
			InitializeComponent();
		}
		public List<string> Pupil;
		public List<string> PupilDetails;

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Close();
			Form MoveToDataEnty = new frmDataEntry();
			MoveToDataEnty.Show();
		}

		private void btnViewAll_Click(object sender, EventArgs e)
		{
			ltvReports.Items.Clear();

			foreach (string line in Pupil)
			{
				if (string.IsNullOrWhiteSpace(line))
				{
					continue;
				}
				PupilDetails = line.Split('~').ToList();
				ltvReports.Items.Add(new ListViewItem(new[] { PupilDetails[0], PupilDetails[1], PupilDetails[2], PupilDetails[3], PupilDetails[4], PupilDetails[5], PupilDetails[6] }));
			}// this causes the list view to show all entries
		}

		private void frmReport_Load(object sender, EventArgs e)
		{
			if (File.Exists(@"Pupil info.txt"))
			{
				Pupil = File.ReadLines(@"Pupil info.txt").ToList();// reads the lines of the text file
			}
		}

		private void cbxReports_SelectedIndexChanged(object sender, EventArgs e)
		{
			ltvReports.Items.Clear();

			foreach (string line in Pupil)
			{
				if (string.IsNullOrWhiteSpace(line))
				{
					continue;
				}
				PupilDetails = line.Split('~').ToList();
				if (cbxReports.SelectedIndex == 0 && PupilDetails[6] == "advanced")
				{
					ltvReports.Items.Add(new ListViewItem(new[] { PupilDetails[0], PupilDetails[1], PupilDetails[2], PupilDetails[3], PupilDetails[4], PupilDetails[5], PupilDetails[6] }));
				}
				else if (cbxReports.SelectedIndex == 1 && PupilDetails[6] == "swimmer")// this causes the list view to only show data of people in the swimmer group
				{
					ltvReports.Items.Add(new ListViewItem(new[] { PupilDetails[0], PupilDetails[1], PupilDetails[2], PupilDetails[3], PupilDetails[4], PupilDetails[5], PupilDetails[6] }));
				}
				else if (cbxReports.SelectedIndex == 2 && PupilDetails[6] == "Non-swimmer")
				{
					ltvReports.Items.Add(new ListViewItem(new[] { PupilDetails[0], PupilDetails[1], PupilDetails[2], PupilDetails[3], PupilDetails[4], PupilDetails[5], PupilDetails[6] }));
				}
			}
		}

		private void cbxYearGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			ltvReports.Items.Clear();// makes sure that the new entries are not added ontop of old enteries

			foreach (string line in Pupil)
			{
				if (string.IsNullOrWhiteSpace(line))
				{
					continue;
				}
				PupilDetails = line.Split('~').ToList();
				if (cbxYearGroup.SelectedIndex == 0 && PupilDetails[2] == "11")
				{
					ltvReports.Items.Add(new ListViewItem(new[] { PupilDetails[0], PupilDetails[1], PupilDetails[2], PupilDetails[3], PupilDetails[4], PupilDetails[5], PupilDetails[6] }));
				}
				else if (cbxYearGroup.SelectedIndex == 1 && PupilDetails[2] == "12")
				{
					ltvReports.Items.Add(new ListViewItem(new[] { PupilDetails[0], PupilDetails[1], PupilDetails[2], PupilDetails[3], PupilDetails[4], PupilDetails[5], PupilDetails[6] }));
				}
				else if (cbxYearGroup.SelectedIndex == 2 && PupilDetails[2] == "13")// this causes the list view to only show data of people in year 13
				{
					ltvReports.Items.Add(new ListViewItem(new[] { PupilDetails[0], PupilDetails[1], PupilDetails[2], PupilDetails[3], PupilDetails[4], PupilDetails[5], PupilDetails[6] }));
				}
				else if (cbxYearGroup.SelectedIndex == 3 && PupilDetails[2] == "14")
				{
					ltvReports.Items.Add(new ListViewItem(new[] { PupilDetails[0], PupilDetails[1], PupilDetails[2], PupilDetails[3], PupilDetails[4], PupilDetails[5], PupilDetails[6] }));
				}
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("in this form you can see the details of the other users and you can filter the data by using the combo boxes");
		}
		private bool ascending = true;

		private void ltvReports_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			List<ListViewItem> sortedItems = ltvReports.Items.Cast<ListViewItem>().OrderBy(item => item.SubItems[e.Column].Text).ToList();
			if (!ascending) sortedItems.Reverse();// if the items are already in ascending order it will reverse them
			ltvReports.Items.Clear();
			ltvReports.Items.AddRange(sortedItems.ToArray());
			ascending = !ascending;
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("in this form you can see the details of the other users and you can filter the data by using the combo boxes");
		}
	}
}
