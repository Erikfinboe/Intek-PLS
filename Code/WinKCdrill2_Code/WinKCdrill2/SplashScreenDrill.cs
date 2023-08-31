using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using winKCdrill2.My;

namespace winKCdrill2
{
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public sealed partial class SplashScreenDrill : Form
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x0004401C File Offset: 0x0004241C
		[DebuggerNonUserCode]
		public SplashScreenDrill()
		{
			base.Load += this.SplashScreenDrill_Load;
			this.InitializeComponent();
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00044060 File Offset: 0x00042460
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00044074 File Offset: 0x00042474
		internal Label ApplicationTitle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ApplicationTitle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ApplicationTitle = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00044080 File Offset: 0x00042480
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00044094 File Offset: 0x00042494
		internal Label Version
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Version;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x000440A0 File Offset: 0x000424A0
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x000440B4 File Offset: 0x000424B4
		internal Label Copyright
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Copyright;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Copyright = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x000440C0 File Offset: 0x000424C0
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x000440D4 File Offset: 0x000424D4
		internal TableLayoutPanel MainLayoutPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MainLayoutPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MainLayoutPanel = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000440E0 File Offset: 0x000424E0
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000440F4 File Offset: 0x000424F4
		internal TableLayoutPanel DetailsLayoutPanel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DetailsLayoutPanel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DetailsLayoutPanel = value;
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0004465C File Offset: 0x00042A5C
		private void SplashScreenDrill_Load(object sender, EventArgs e)
		{
			if (Operators.CompareString(MyProject.Application.Info.Title, "", false) != 0)
			{
				this.ApplicationTitle.Text = MyProject.Application.Info.Title;
			}
			else
			{
				this.ApplicationTitle.Text = Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName);
			}
			int stor = MyProject.Application.Info.Version.Major;
			int liten = MyProject.Application.Info.Version.Minor;
			string Innehåll;
			if (liten < 10)
			{
				Innehåll = string.Concat(new string[]
				{
					" Version ",
					Conversions.ToString(MyProject.Application.Info.Version.Major),
					" .",
					Conversions.ToString(MyProject.Application.Info.Version.Minor),
					"0"
				});
			}
			else
			{
				Innehåll = " Version " + Conversions.ToString(MyProject.Application.Info.Version.Major) + " ." + Conversions.ToString(MyProject.Application.Info.Version.Minor);
			}
			this.Version.Text = Innehåll;
			this.Copyright.Text = MyProject.Application.Info.Copyright;
		}

		// Token: 0x040002BD RID: 701
		[AccessedThroughProperty("ApplicationTitle")]
		private Label _ApplicationTitle;

		// Token: 0x040002BE RID: 702
		[AccessedThroughProperty("Version")]
		private Label _Version;

		// Token: 0x040002BF RID: 703
		[AccessedThroughProperty("Copyright")]
		private Label _Copyright;

		// Token: 0x040002C0 RID: 704
		[AccessedThroughProperty("MainLayoutPanel")]
		private TableLayoutPanel _MainLayoutPanel;

		// Token: 0x040002C1 RID: 705
		[AccessedThroughProperty("DetailsLayoutPanel")]
		private TableLayoutPanel _DetailsLayoutPanel;
	}
}
