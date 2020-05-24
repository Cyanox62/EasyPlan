using System;

namespace EasyPlan
{
	public class Assignment
	{
		public string title;
		public DateTime earlyDueDate = DateTime.Today;
		public int timeToComplete;
		public string notes;
		public bool complete = false;
	}
}
