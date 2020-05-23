namespace EasyPlan
{
	partial class CreateWeekForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.WeekTitleTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.WeekHighlightCalendar = new System.Windows.Forms.MonthCalendar();
			this.label2 = new System.Windows.Forms.Label();
			this.AssignmentListBox = new System.Windows.Forms.ListBox();
			this.AddAssignmentButton = new System.Windows.Forms.Button();
			this.CreateWeekFinishButton = new System.Windows.Forms.Button();
			this.AssignmentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AssignmentContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// WeekTitleTextBox
			// 
			this.WeekTitleTextBox.Location = new System.Drawing.Point(11, 28);
			this.WeekTitleTextBox.Name = "WeekTitleTextBox";
			this.WeekTitleTextBox.Size = new System.Drawing.Size(224, 20);
			this.WeekTitleTextBox.TabIndex = 0;
			this.WeekTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Week Title";
			// 
			// WeekHighlightCalendar
			// 
			this.WeekHighlightCalendar.Location = new System.Drawing.Point(10, 84);
			this.WeekHighlightCalendar.MaxSelectionCount = 10;
			this.WeekHighlightCalendar.Name = "WeekHighlightCalendar";
			this.WeekHighlightCalendar.ShowTodayCircle = false;
			this.WeekHighlightCalendar.TabIndex = 2;
			this.WeekHighlightCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.WeekHighlightCalendar_DateSelected);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Week Duration";
			// 
			// AssignmentListBox
			// 
			this.AssignmentListBox.FormattingEnabled = true;
			this.AssignmentListBox.Location = new System.Drawing.Point(249, 58);
			this.AssignmentListBox.Name = "AssignmentListBox";
			this.AssignmentListBox.Size = new System.Drawing.Size(224, 186);
			this.AssignmentListBox.Sorted = true;
			this.AssignmentListBox.TabIndex = 4;
			this.AssignmentListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AssignmentListBox_MouseDown);
			// 
			// AddAssignmentButton
			// 
			this.AddAssignmentButton.Location = new System.Drawing.Point(249, 29);
			this.AddAssignmentButton.Name = "AddAssignmentButton";
			this.AddAssignmentButton.Size = new System.Drawing.Size(224, 23);
			this.AddAssignmentButton.TabIndex = 5;
			this.AddAssignmentButton.Text = "Add New Assignment";
			this.AddAssignmentButton.UseVisualStyleBackColor = true;
			this.AddAssignmentButton.Click += new System.EventHandler(this.AddAssignmentButton_Click);
			// 
			// CreateWeekFinishButton
			// 
			this.CreateWeekFinishButton.Location = new System.Drawing.Point(10, 258);
			this.CreateWeekFinishButton.Name = "CreateWeekFinishButton";
			this.CreateWeekFinishButton.Size = new System.Drawing.Size(463, 23);
			this.CreateWeekFinishButton.TabIndex = 6;
			this.CreateWeekFinishButton.Text = "Finish";
			this.CreateWeekFinishButton.UseVisualStyleBackColor = true;
			this.CreateWeekFinishButton.Click += new System.EventHandler(this.CreateWeekFinishButton_Click);
			// 
			// AssignmentContextMenu
			// 
			this.AssignmentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.AssignmentContextMenu.Name = "AssignmentContextMenu";
			this.AssignmentContextMenu.Size = new System.Drawing.Size(108, 48);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// CreateWeekForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 288);
			this.Controls.Add(this.CreateWeekFinishButton);
			this.Controls.Add(this.AddAssignmentButton);
			this.Controls.Add(this.AssignmentListBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.WeekHighlightCalendar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.WeekTitleTextBox);
			this.MaximizeBox = false;
			this.Name = "CreateWeekForm";
			this.Text = "EasyPlan - Create New Week";
			this.AssignmentContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox WeekTitleTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MonthCalendar WeekHighlightCalendar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox AssignmentListBox;
		private System.Windows.Forms.Button AddAssignmentButton;
		private System.Windows.Forms.Button CreateWeekFinishButton;
		private System.Windows.Forms.ContextMenuStrip AssignmentContextMenu;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
	}
}