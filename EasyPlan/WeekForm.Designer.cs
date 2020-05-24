namespace EasyPlan
{
	partial class WeekForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekForm));
			this.WeekCalendar = new System.Windows.Forms.MonthCalendar();
			this.WeekAssignments = new System.Windows.Forms.ListBox();
			this.WeekAssignmentContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.WeekSaveButton = new System.Windows.Forms.Button();
			this.markCompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.WeekAssignmentContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// WeekCalendar
			// 
			this.WeekCalendar.Location = new System.Drawing.Point(18, 18);
			this.WeekCalendar.MaxSelectionCount = 1;
			this.WeekCalendar.Name = "WeekCalendar";
			this.WeekCalendar.ShowTodayCircle = false;
			this.WeekCalendar.TabIndex = 0;
			this.WeekCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.WeekCalendar_DateChanged);
			// 
			// WeekAssignments
			// 
			this.WeekAssignments.FormattingEnabled = true;
			this.WeekAssignments.Location = new System.Drawing.Point(257, 20);
			this.WeekAssignments.Name = "WeekAssignments";
			this.WeekAssignments.Size = new System.Drawing.Size(227, 160);
			this.WeekAssignments.TabIndex = 1;
			this.WeekAssignments.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WeekAssignments_MouseDown);
			// 
			// WeekAssignmentContextMenu
			// 
			this.WeekAssignmentContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markCompleteToolStripMenuItem,
            this.deleteToolStripMenuItem});
			this.WeekAssignmentContextMenu.Name = "WeekAssignmentContextMenu";
			this.WeekAssignmentContextMenu.Size = new System.Drawing.Size(157, 48);
			// 
			// WeekSaveButton
			// 
			this.WeekSaveButton.Location = new System.Drawing.Point(18, 185);
			this.WeekSaveButton.Name = "WeekSaveButton";
			this.WeekSaveButton.Size = new System.Drawing.Size(466, 23);
			this.WeekSaveButton.TabIndex = 2;
			this.WeekSaveButton.Text = "Save Week";
			this.WeekSaveButton.UseVisualStyleBackColor = true;
			this.WeekSaveButton.Click += new System.EventHandler(this.WeekSaveButton_Click);
			// 
			// markCompleteToolStripMenuItem
			// 
			this.markCompleteToolStripMenuItem.Image = global::EasyPlan.Properties.Resources.icons8_checkmark_24;
			this.markCompleteToolStripMenuItem.Name = "markCompleteToolStripMenuItem";
			this.markCompleteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.markCompleteToolStripMenuItem.Text = "Mark Complete";
			this.markCompleteToolStripMenuItem.Click += new System.EventHandler(this.markCompleteToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteToolStripMenuItem.Image = global::EasyPlan.Properties.Resources.trash;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// WeekForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 220);
			this.Controls.Add(this.WeekSaveButton);
			this.Controls.Add(this.WeekAssignments);
			this.Controls.Add(this.WeekCalendar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "WeekForm";
			this.Text = "Week";
			this.WeekAssignmentContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.MonthCalendar WeekCalendar;
		private System.Windows.Forms.ListBox WeekAssignments;
		private System.Windows.Forms.ContextMenuStrip WeekAssignmentContextMenu;
		private System.Windows.Forms.ToolStripMenuItem markCompleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.Button WeekSaveButton;
	}
}