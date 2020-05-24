using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace EasyPlan
{
	public partial class StartupForm : Form
	{
		public StartupForm()
		{
			InitializeComponent();

			//new WeekForm(null).Show();
		}

		private void CreateWeekButton_Click(object sender, EventArgs e)
		{
			Hide();
			new CreateWeekForm().Show();
		}

		private void LoadWeekButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "Json files (*.json)|*.json"; ;
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					var a = JsonConvert.DeserializeObject<Week>(File.ReadAllText(openFileDialog.FileName));
					Hide();
					new WeekForm(a).Show();
				}
			}
		}
	}
}
