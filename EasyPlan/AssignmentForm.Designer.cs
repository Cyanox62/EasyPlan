namespace EasyPlan
{
	partial class AssignmentForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentForm));
			this.AssignmentTitleTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.EarlyDueDateCalendar = new System.Windows.Forms.MonthCalendar();
			this.EarlyDueDateCheckBox = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TimeToCompleteNumeric = new System.Windows.Forms.NumericUpDown();
			this.AssignmentNotes = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.AssignmentFinishButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TimeToCompleteNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// AssignmentTitleTextBox
			// 
			this.AssignmentTitleTextBox.Location = new System.Drawing.Point(12, 38);
			this.AssignmentTitleTextBox.Name = "AssignmentTitleTextBox";
			this.AssignmentTitleTextBox.Size = new System.Drawing.Size(227, 20);
			this.AssignmentTitleTextBox.TabIndex = 0;
			this.AssignmentTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Assignment Title";
			// 
			// EarlyDueDateCalendar
			// 
			this.EarlyDueDateCalendar.Enabled = false;
			this.EarlyDueDateCalendar.Location = new System.Drawing.Point(12, 104);
			this.EarlyDueDateCalendar.MaxSelectionCount = 1;
			this.EarlyDueDateCalendar.Name = "EarlyDueDateCalendar";
			this.EarlyDueDateCalendar.ShowTodayCircle = false;
			this.EarlyDueDateCalendar.TabIndex = 2;
			// 
			// EarlyDueDateCheckBox
			// 
			this.EarlyDueDateCheckBox.AutoSize = true;
			this.EarlyDueDateCheckBox.Location = new System.Drawing.Point(12, 79);
			this.EarlyDueDateCheckBox.Name = "EarlyDueDateCheckBox";
			this.EarlyDueDateCheckBox.Size = new System.Drawing.Size(98, 17);
			this.EarlyDueDateCheckBox.TabIndex = 3;
			this.EarlyDueDateCheckBox.Text = "Early Due Date";
			this.EarlyDueDateCheckBox.UseVisualStyleBackColor = true;
			this.EarlyDueDateCheckBox.CheckedChanged += new System.EventHandler(this.EarlyDueDateCheckBox_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(266, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Estimated Time to Complete (hours)";
			// 
			// TimeToCompleteNumeric
			// 
			this.TimeToCompleteNumeric.Location = new System.Drawing.Point(269, 40);
			this.TimeToCompleteNumeric.Name = "TimeToCompleteNumeric";
			this.TimeToCompleteNumeric.Size = new System.Drawing.Size(159, 20);
			this.TimeToCompleteNumeric.TabIndex = 5;
			// 
			// AssignmentNotes
			// 
			this.AssignmentNotes.Location = new System.Drawing.Point(265, 104);
			this.AssignmentNotes.Name = "AssignmentNotes";
			this.AssignmentNotes.Size = new System.Drawing.Size(174, 162);
			this.AssignmentNotes.TabIndex = 6;
			this.AssignmentNotes.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(335, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Notes";
			// 
			// AssignmentFinishButton
			// 
			this.AssignmentFinishButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AssignmentFinishButton.Location = new System.Drawing.Point(12, 278);
			this.AssignmentFinishButton.Name = "AssignmentFinishButton";
			this.AssignmentFinishButton.Size = new System.Drawing.Size(427, 23);
			this.AssignmentFinishButton.TabIndex = 8;
			this.AssignmentFinishButton.Text = "Finish";
			this.AssignmentFinishButton.UseVisualStyleBackColor = true;
			this.AssignmentFinishButton.Click += new System.EventHandler(this.AssignmentFinishButton_Click);
			// 
			// AssignmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 316);
			this.Controls.Add(this.AssignmentFinishButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AssignmentNotes);
			this.Controls.Add(this.TimeToCompleteNumeric);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.EarlyDueDateCheckBox);
			this.Controls.Add(this.EarlyDueDateCalendar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AssignmentTitleTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "AssignmentForm";
			this.Text = "EasyPlan | Add New Assignment";
			((System.ComponentModel.ISupportInitialize)(this.TimeToCompleteNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox AssignmentTitleTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MonthCalendar EarlyDueDateCalendar;
		private System.Windows.Forms.CheckBox EarlyDueDateCheckBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown TimeToCompleteNumeric;
		private System.Windows.Forms.RichTextBox AssignmentNotes;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button AssignmentFinishButton;
	}
}