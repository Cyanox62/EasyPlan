namespace EasyPlan
{
	partial class StartupForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
			this.CreateWeekButton = new System.Windows.Forms.Button();
			this.LoadWeekButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CreateWeekButton
			// 
			this.CreateWeekButton.Location = new System.Drawing.Point(13, 57);
			this.CreateWeekButton.Name = "CreateWeekButton";
			this.CreateWeekButton.Size = new System.Drawing.Size(183, 23);
			this.CreateWeekButton.TabIndex = 0;
			this.CreateWeekButton.Text = "Create New Week";
			this.CreateWeekButton.UseVisualStyleBackColor = true;
			this.CreateWeekButton.Click += new System.EventHandler(this.CreateWeekButton_Click);
			// 
			// LoadWeekButton
			// 
			this.LoadWeekButton.Location = new System.Drawing.Point(12, 86);
			this.LoadWeekButton.Name = "LoadWeekButton";
			this.LoadWeekButton.Size = new System.Drawing.Size(183, 23);
			this.LoadWeekButton.TabIndex = 1;
			this.LoadWeekButton.Text = "Load Week";
			this.LoadWeekButton.UseVisualStyleBackColor = true;
			this.LoadWeekButton.Click += new System.EventHandler(this.LoadWeekButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "EasyPlan";
			// 
			// StartupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(208, 117);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LoadWeekButton);
			this.Controls.Add(this.CreateWeekButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StartupForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EasyPlan";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CreateWeekButton;
		private System.Windows.Forms.Button LoadWeekButton;
		private System.Windows.Forms.Label label1;
	}
}

