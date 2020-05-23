using System;
using System.Windows.Forms;

namespace EasyPlan
{
	public partial class AssignmentForm : Form
	{
		public Assignment assignment { get; set; }

		public AssignmentForm(DateTime weekEndDate, Assignment a = null)
		{
			InitializeComponent();

			if (a != null)
			{
				AssignmentTitleTextBox.Text = a.title;
				TimeToCompleteNumeric.Value = a.timeToComplete;
				if (a.earlyDueDate.Date != weekEndDate.Date)
				{
					EarlyDueDateCheckBox.Checked = true;
					EarlyDueDateCalendar.SelectionStart = a.earlyDueDate;
				}
				AssignmentNotes.Text = a.notes;
			}
		}

		private void AssignmentFinishButton_Click(object sender, EventArgs e)
		{
			assignment = new Assignment()
			{
				title = AssignmentTitleTextBox.Text,
				notes = AssignmentNotes.Text,
				timeToComplete = (int)TimeToCompleteNumeric.Value,
				earlyDueDate = EarlyDueDateCheckBox.Checked ? EarlyDueDateCalendar.SelectionEnd : DateTime.Now // Set this to the end date of the week
			};
			Close();
		}

		private void EarlyDueDateCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			EarlyDueDateCalendar.Enabled = EarlyDueDateCheckBox.Checked;
		}
	}
}
