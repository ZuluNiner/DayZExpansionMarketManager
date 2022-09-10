namespace DayZExpansionMarketManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.categoryManagerButton = new System.Windows.Forms.Button();
			this.traderManagerButton = new System.Windows.Forms.Button();
			this.safezoneManagerButton = new System.Windows.Forms.Button();
			this.mapManagerButton = new System.Windows.Forms.Button();
			this.traderZoneManagerButton = new System.Windows.Forms.Button();
			this.settingsManagerButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 80);
			this.label1.TabIndex = 1;
			this.label1.Text = "DayZ Expansion Market Manager";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// categoryManagerButton
			// 
			this.categoryManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.categoryManagerButton.Location = new System.Drawing.Point(0, 80);
			this.categoryManagerButton.Name = "categoryManagerButton";
			this.categoryManagerButton.Size = new System.Drawing.Size(210, 23);
			this.categoryManagerButton.TabIndex = 2;
			this.categoryManagerButton.Text = "Category Manager";
			this.categoryManagerButton.UseVisualStyleBackColor = true;
			this.categoryManagerButton.Click += new System.EventHandler(this.categoryManagerButton_Click);
			// 
			// traderManagerButton
			// 
			this.traderManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.traderManagerButton.Location = new System.Drawing.Point(0, 103);
			this.traderManagerButton.Name = "traderManagerButton";
			this.traderManagerButton.Size = new System.Drawing.Size(210, 23);
			this.traderManagerButton.TabIndex = 3;
			this.traderManagerButton.Text = "Trader Manager";
			this.traderManagerButton.UseVisualStyleBackColor = true;
			this.traderManagerButton.Click += new System.EventHandler(this.traderManagerButton_Click);
			// 
			// safezoneManagerButton
			// 
			this.safezoneManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.safezoneManagerButton.Location = new System.Drawing.Point(0, 126);
			this.safezoneManagerButton.Name = "safezoneManagerButton";
			this.safezoneManagerButton.Size = new System.Drawing.Size(210, 23);
			this.safezoneManagerButton.TabIndex = 4;
			this.safezoneManagerButton.Text = "Safezone Manager";
			this.safezoneManagerButton.UseVisualStyleBackColor = true;
			this.safezoneManagerButton.Click += new System.EventHandler(this.safezoneManagerButton_Click);
			// 
			// mapManagerButton
			// 
			this.mapManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.mapManagerButton.Location = new System.Drawing.Point(0, 149);
			this.mapManagerButton.Name = "mapManagerButton";
			this.mapManagerButton.Size = new System.Drawing.Size(210, 23);
			this.mapManagerButton.TabIndex = 5;
			this.mapManagerButton.Text = "Map Manager";
			this.mapManagerButton.UseVisualStyleBackColor = true;
			this.mapManagerButton.Click += new System.EventHandler(this.mapManagerButton_Click);
			// 
			// traderZoneManagerButton
			// 
			this.traderZoneManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.traderZoneManagerButton.Location = new System.Drawing.Point(0, 172);
			this.traderZoneManagerButton.Name = "traderZoneManagerButton";
			this.traderZoneManagerButton.Size = new System.Drawing.Size(210, 23);
			this.traderZoneManagerButton.TabIndex = 6;
			this.traderZoneManagerButton.Text = "Trader Zone Manager";
			this.traderZoneManagerButton.UseVisualStyleBackColor = true;
			this.traderZoneManagerButton.Click += new System.EventHandler(this.traderZoneManagerButton_Click);
			// 
			// settingsManagerButton
			// 
			this.settingsManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.settingsManagerButton.Location = new System.Drawing.Point(0, 195);
			this.settingsManagerButton.Name = "settingsManagerButton";
			this.settingsManagerButton.Size = new System.Drawing.Size(210, 23);
			this.settingsManagerButton.TabIndex = 7;
			this.settingsManagerButton.Text = "Settings Manager";
			this.settingsManagerButton.UseVisualStyleBackColor = true;
			this.settingsManagerButton.Click += new System.EventHandler(this.settingsManagerButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(210, 230);
			this.Controls.Add(this.settingsManagerButton);
			this.Controls.Add(this.traderZoneManagerButton);
			this.Controls.Add(this.mapManagerButton);
			this.Controls.Add(this.safezoneManagerButton);
			this.Controls.Add(this.traderManagerButton);
			this.Controls.Add(this.categoryManagerButton);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "DZEMM";
			this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button removeMarketFilesButton;
        private Button categoryManagerButton;
        private Button traderManagerButton;
        private Button safezoneManagerButton;
        private Button mapManagerButton;
        private Button traderZoneManagerButton;
        private Button settingsManagerButton;
	}
}