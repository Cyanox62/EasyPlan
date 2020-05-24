using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyPlan
{
	public partial class CreateWeekForm : Form
	{
		private Dictionary<int, Assignment> assignments;

		internal DateTime weekEndDate;

		public CreateWeekForm()
		{
			InitializeComponent();

			assignments = new Dictionary<int, Assignment>();
		}

		private void WeekHighlightCalendar_DateSelected(object sender, DateRangeEventArgs e)
		{
			WeekHighlightCalendar.SelectionRange = new SelectionRange(WeekHighlightCalendar.TodayDate, e.End);
			weekEndDate = e.End;
		}

		private void AddAssignmentButton_Click(object sender, EventArgs e)
		{
			using (var form = new AssignmentForm(weekEndDate))
			{
				if (form.ShowDialog() == DialogResult.OK)
				{
					if (!AssignmentListBox.Items.Contains(form.assignment.title))
					{
						assignments.Add(AssignmentListBox.Items.Add(form.assignment.title), form.assignment);
					}
					else
					{
						MessageBox.Show("Assignment with that name already exists!", "Error Addding Assignment", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void CreateWeekFinishButton_Click(object sender, EventArgs e)
		{
			Week week = new Week()
			{
				title = WeekTitleTextBox.Text,
				endDate = WeekHighlightCalendar.SelectionEnd,
				assignments = new List<Assignment>(assignments.Values)
			};
			Close();
			new WeekForm(week).Show();
		}

		private void AssignmentListBox_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right) return;
			int index = AssignmentListBox.IndexFromPoint(e.X, e.Y);
			if (index != -1)
			{
				AssignmentListBox.SelectedIndex = index;
				AssignmentContextMenu.Show(Cursor.Position);
			}
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = AssignmentListBox.SelectedIndex;
			if (index != -1)
			{
				using (var form = new AssignmentForm(weekEndDate, assignments[index]))
				{
					if (form.ShowDialog() == DialogResult.OK)
					{
						AssignmentListBox.Items[index] = form.assignment.title;
						assignments[index] = form.assignment;
					}
				}
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = AssignmentListBox.SelectedIndex;
			if (index != -1)
			{
				AssignmentListBox.Items.RemoveAt(index);
				assignments.Remove(index);
			}
		}
	}
}
