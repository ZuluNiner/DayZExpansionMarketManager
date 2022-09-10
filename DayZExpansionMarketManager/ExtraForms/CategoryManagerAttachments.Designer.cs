namespace DayZExpansionMarketManager.ExtraForms
{
	partial class CategoryManagerAttachments
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.headerLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Location = new System.Drawing.Point(12, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(423, 397);
			this.panel1.TabIndex = 0;
			// 
			// headerLabel
			// 
			this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.headerLabel.Location = new System.Drawing.Point(0, 0);
			this.headerLabel.Name = "headerLabel";
			this.headerLabel.Size = new System.Drawing.Size(447, 27);
			this.headerLabel.TabIndex = 1;
			this.headerLabel.Text = "Attachments For...";
			this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CategoryManagerAttachments
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 450);
			this.Controls.Add(this.headerLabel);
			this.Controls.Add(this.panel1);
			this.Name = "CategoryManagerAttachments";
			this.Text = "CategoryManagerAttachments";
			this.Load += new System.EventHandler(this.CategoryManagerAttachments_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Label headerLabel;
	}
}