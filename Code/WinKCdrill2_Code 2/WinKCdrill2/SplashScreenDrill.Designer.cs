namespace winKCdrill2
{
	// Token: 0x0200001B RID: 27
	//[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public sealed partial class SplashScreenDrill : global::System.Windows.Forms.Form
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x00044040 File Offset: 0x00042440
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00044100 File Offset: 0x00042500
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::winKCdrill2.SplashScreenDrill));
			this.MainLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.DetailsLayoutPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.Version = new global::System.Windows.Forms.Label();
			this.Copyright = new global::System.Windows.Forms.Label();
			this.ApplicationTitle = new global::System.Windows.Forms.Label();
			this.MainLayoutPanel.SuspendLayout();
			this.DetailsLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			this.MainLayoutPanel.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("MainLayoutPanel.BackgroundImage");
			this.MainLayoutPanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.MainLayoutPanel.ColumnCount = 2;
			this.MainLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 243f));
			this.MainLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 100f));
			this.MainLayoutPanel.Controls.Add(this.DetailsLayoutPanel, 1, 1);
			this.MainLayoutPanel.Controls.Add(this.ApplicationTitle, 1, 0);
			this.MainLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control mainLayoutPanel = this.MainLayoutPanel;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			mainLayoutPanel.Location = location;
			this.MainLayoutPanel.Name = "MainLayoutPanel";
			this.MainLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 218f));
			this.MainLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 38f));
			global::System.Windows.Forms.Control mainLayoutPanel2 = this.MainLayoutPanel;
			global::System.Drawing.Size size = new global::System.Drawing.Size(496, 361);
			mainLayoutPanel2.Size = size;
			this.MainLayoutPanel.TabIndex = 0;
			this.DetailsLayoutPanel.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.DetailsLayoutPanel.BackColor = global::System.Drawing.Color.Transparent;
			this.DetailsLayoutPanel.ColumnCount = 1;
			this.DetailsLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 247f));
			this.DetailsLayoutPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 142f));
			this.DetailsLayoutPanel.Controls.Add(this.Version, 0, 0);
			this.DetailsLayoutPanel.Controls.Add(this.Copyright, 0, 1);
			global::System.Windows.Forms.Control detailsLayoutPanel = this.DetailsLayoutPanel;
			location = new global::System.Drawing.Point(246, 250);
			detailsLayoutPanel.Location = location;
			this.DetailsLayoutPanel.Name = "DetailsLayoutPanel";
			this.DetailsLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33f));
			this.DetailsLayoutPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 33f));
			global::System.Windows.Forms.Control detailsLayoutPanel2 = this.DetailsLayoutPanel;
			size = new global::System.Drawing.Size(247, 79);
			detailsLayoutPanel2.Size = size;
			this.DetailsLayoutPanel.TabIndex = 1;
			this.Version.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.Version.BackColor = global::System.Drawing.Color.Transparent;
			this.Version.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Version.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			global::System.Windows.Forms.Control version = this.Version;
			location = new global::System.Drawing.Point(3, 9);
			version.Location = location;
			this.Version.Name = "Version";
			global::System.Windows.Forms.Control version2 = this.Version;
			size = new global::System.Drawing.Size(241, 20);
			version2.Size = size;
			this.Version.TabIndex = 1;
			this.Version.Text = "Version {1:01}";
			this.Copyright.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.Copyright.BackColor = global::System.Drawing.Color.Transparent;
			this.Copyright.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Copyright.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			global::System.Windows.Forms.Control copyright = this.Copyright;
			location = new global::System.Drawing.Point(3, 39);
			copyright.Location = location;
			this.Copyright.Name = "Copyright";
			global::System.Windows.Forms.Control copyright2 = this.Copyright;
			size = new global::System.Drawing.Size(241, 40);
			copyright2.Size = size;
			this.Copyright.TabIndex = 2;
			this.Copyright.Text = "Copyright Skanska Foundation Sweden";
			this.ApplicationTitle.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.ApplicationTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.ApplicationTitle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ApplicationTitle.ForeColor = global::System.Drawing.SystemColors.GradientActiveCaption;
			global::System.Windows.Forms.Control applicationTitle = this.ApplicationTitle;
			location = new global::System.Drawing.Point(246, 3);
			applicationTitle.Location = location;
			this.ApplicationTitle.Name = "ApplicationTitle";
			global::System.Windows.Forms.Control applicationTitle2 = this.ApplicationTitle;
			size = new global::System.Drawing.Size(247, 212);
			applicationTitle2.Size = size;
			this.ApplicationTitle.TabIndex = 0;
			this.ApplicationTitle.Text = "KC Drilling in rig";
			this.ApplicationTitle.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(496, 361);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.MainLayoutPanel);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SplashScreenDrill";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MainLayoutPanel.ResumeLayout(false);
			this.DetailsLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x040002C2 RID: 706
		private global::System.ComponentModel.IContainer components;
	}
}
