using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EasyPlan
{
	public partial class WeekForm : Form
	{
		private Week week;
		private int totalDays;

		private Dictionary<int, List<Assignment>> workDates = new Dictionary<int, List<Assignment>>();
		private Dictionary<int, List<Assignment>> map = new Dictionary<int, List<Assignment>>();
		private Dictionary<int, List<Assignment>> final = new Dictionary<int, List<Assignment>>();

		private void AddToIndex(int index, Assignment assignment)
		{
			if (!final.ContainsKey(index))
			{
				final.Add(index, new List<Assignment>());
			}
			final[index].Add(assignment);
		}

		private void SetAssignmentBox(int index)
		{
			WeekAssignments.Items.Clear();
			if (workDates.ContainsKey(index) && workDates[index].Count > 0)
			{
				foreach (Assignment assignment in workDates[index])
				{
					WeekAssignments.Items.Add((assignment.complete ? "[COMPLETE] " : "") + assignment.title);
				}
			}
			else
			{
				WeekAssignments.Items.Add("No work today!");
			}
		}

		private int GetBestDay(int a)
		{
			int bestDay = -1;
			int count = int.MaxValue;
			for (int i = 0; i < (a == 1 ? totalDays : a); i++)
			{
				int curCount = final.ContainsKey(i) ? final[i].Count : 0;
				if (curCount < count)
				{
					count = curCount;
					bestDay = i;
				}
			}
			return bestDay;
		}

		private bool isAllWorkDone(int index)
		{
			if (workDates.ContainsKey(index))
			{
				foreach (Assignment assignment in workDates[index])
				{
					if (!assignment.complete) return false;
				}
				return true;
			}
			return false;
		}

		private float GetHoursOfWork()
		{
			float hours = 0;
			foreach (Assignment assignment in week.assignments) hours += assignment.timeToComplete;
			return hours;
		}

		public WeekForm(Week week)
		{
			InitializeComponent();

			/*Assignment[] assign =
			{
				new Assignment()
				{
					title = "Assignment1",
					notes = "Notes1",
					earlyDueDate = DateTime.Now.AddDays(3),
					timeToComplete = 3
				},
				new Assignment()
				{
					title = "Assignment2",
					notes = "Notes2",
					earlyDueDate = DateTime.Now.AddDays(1),
					timeToComplete = 5
				},
				new Assignment()
				{
					title = "Assignment3",
					notes = "Notes3",
					earlyDueDate = DateTime.Now.AddDays(1),
					timeToComplete = 1
				},
				new Assignment()
				{
					title = "Assignment4",
					notes = "Notes1",
					earlyDueDate = DateTime.Now.AddDays(3),
					timeToComplete = 3
				},
				new Assignment()
				{
					title = "Assignment5",
					notes = "Notes2",
					earlyDueDate = DateTime.Now.AddDays(3),
					timeToComplete = 5
				},
				new Assignment()
				{
					title = "Assignment6",
					notes = "Notes3",
					earlyDueDate = DateTime.Now.AddDays(1),
					timeToComplete = 1
				},
				new Assignment()
				{
					title = "Assignment7",
					notes = "Notes2",
					earlyDueDate = DateTime.Now.AddDays(3),
					timeToComplete = 5
				},
				new Assignment()
				{
					title = "Assignment8",
					notes = "Notes3",
					earlyDueDate = DateTime.Now.AddDays(4),
					timeToComplete = 1
				},
				new Assignment()
				{
					title = "Assignment9",
					notes = "Notes2",
					earlyDueDate = DateTime.Now.AddDays(4),
					timeToComplete = 5
				},
				new Assignment()
				{
					title = "Assignment10",
					notes = "Notes3",
					earlyDueDate = DateTime.Now.AddDays(5),
					timeToComplete = 1
				},
				new Assignment()
				{
					title = "Assignment11",
					notes = "Notes4",
					earlyDueDate = DateTime.Now.AddDays(7),
					timeToComplete = 2
				}
			};

			Week week = new Week()
			{
				title = "Test Week",
				endDate = DateTime.Now.AddDays(7),
				assignments = new List<Assignment>(assign)
			};*/

			this.week = week;

			Text = $"EasyPlan | {week.title} - Estimated {GetHoursOfWork()} hours of work remaining";

			totalDays = (week.endDate - DateTime.Today).Days + 1;

			foreach (Assignment a in week.assignments)
			{
				int dueIndex = (a.earlyDueDate - DateTime.Today).Days + 1;
				if (!map.ContainsKey(dueIndex))
				{
					map.Add(dueIndex, new List<Assignment>() { a });
				}
				else map[dueIndex].Add(a);
			}

			for (int i = 0; i < totalDays; i++)
			{
				if (map.ContainsKey(i))
				{
					for (int a = 0; a <= i; a++)
					{
						if (map[i].Count > 0)
						{
							AddToIndex(GetBestDay(i), map[i][0]);
							map[i].RemoveAt(0);
							if (a == i) a = 0;
						}
						else break;
					}
				}
			}

			for (int i = 0; i < final.Keys.Count; i++)
			{
				DateTime date = DateTime.Today.AddDays(final.ElementAt(i).Key);
				int index = (date - DateTime.Today).Days;
				if (!workDates.ContainsKey(index)) workDates.Add(index, new List<Assignment>());
				foreach (Assignment assignment in final[i])
				{
					workDates[index].Add(assignment);
				}
				if (!isAllWorkDone(index)) WeekCalendar.AddBoldedDate(date);
			}
			WeekCalendar.UpdateBoldedDates();
			SetAssignmentBox(0);
		}

		private void WeekCalendar_DateChanged(object sender, DateRangeEventArgs e)
		{
			SetAssignmentBox((e.Start - DateTime.Today).Days);
		}

		private void WeekAssignments_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right) return;
			int index = WeekAssignments.IndexFromPoint(e.X, e.Y);
			if (index != -1)
			{
				WeekAssignments.SelectedIndex = index;
				Assignment assignment = workDates[(WeekCalendar.SelectionEnd - DateTime.Today).Days][index];
				WeekAssignmentContextMenu.Items[0].Text = $"Mark {(!assignment.complete ? "Complete": "Incomplete")}";
				WeekAssignmentContextMenu.Show(Cursor.Position);
			}
		}

		private void markCompleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = (WeekCalendar.SelectionEnd - DateTime.Today).Days;
			Assignment assignment = workDates[index][WeekAssignments.SelectedIndex];
			assignment.complete = !assignment.complete;
			if (isAllWorkDone(index))
			{
				WeekCalendar.RemoveBoldedDate(WeekCalendar.SelectionEnd);
				WeekCalendar.UpdateBoldedDates();
			}
			else
			{
				WeekCalendar.AddBoldedDate(WeekCalendar.SelectionEnd);
				WeekCalendar.UpdateBoldedDates();
			}
			SetAssignmentBox(index);
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = (WeekCalendar.SelectionEnd - DateTime.Today).Days;
			DialogResult result = MessageBox.Show($"Are you sure you want to delete assignment {workDates[index][WeekAssignments.SelectedIndex].title}?", "Delete Assignment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				workDates[index].RemoveAt(WeekAssignments.SelectedIndex);
				SetAssignmentBox(index);
			}
			if (isAllWorkDone(index)) WeekCalendar.RemoveBoldedDate(WeekCalendar.SelectionEnd);
			WeekCalendar.UpdateBoldedDates();
		}

		private void WeekSaveButton_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.InitialDirectory = "c:\\";
				saveFileDialog.Filter = "Json files (*.json)|*.json"; ;
				saveFileDialog.FilterIndex = 2;
				saveFileDialog.RestoreDirectory = true;

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(week, Formatting.Indented));
				}
			}
		}
	}
}
