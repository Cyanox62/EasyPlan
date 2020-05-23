using System;
using System.Windows.Forms;

namespace EasyPlan
{
	public partial class StartupForm : Form
	{
		public StartupForm()
		{
			InitializeComponent();

			new WeekForm(null).Show();
		}

		private void CreateWeekButton_Click(object sender, EventArgs e)
		{
			Hide();
			new CreateWeekForm().Show();
		}
	}
}
