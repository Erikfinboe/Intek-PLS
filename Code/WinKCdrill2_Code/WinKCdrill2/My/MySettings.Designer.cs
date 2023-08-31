using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace winKCdrill2.My
{
	// Token: 0x02000012 RID: 18
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x06000380 RID: 896 RVA: 0x0002F5F0 File Offset: 0x0002D9F0
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0002F608 File Offset: 0x0002DA08
		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += MySettings.AutoSaveSettings;
							MySettings.addedHandler = true;
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0002F670 File Offset: 0x0002DA70
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0002F690 File Offset: 0x0002DA90
		[UserScopedSetting]
		[DefaultSettingValue("Driver no 1")]
		[DebuggerNonUserCode]
		public string Driver1
		{
			get
			{
				return Conversions.ToString(this["Driver1"]);
			}
			set
			{
				this["Driver1"] = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0002F6A0 File Offset: 0x0002DAA0
		// (set) Token: 0x06000385 RID: 901 RVA: 0x0002F6C0 File Offset: 0x0002DAC0
		[UserScopedSetting]
		[DefaultSettingValue("Driver no 2")]
		[DebuggerNonUserCode]
		public string Driver2
		{
			get
			{
				return Conversions.ToString(this["Driver2"]);
			}
			set
			{
				this["Driver2"] = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0002F6D0 File Offset: 0x0002DAD0
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0002F6F0 File Offset: 0x0002DAF0
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("Driver no 3")]
		public string Driver3
		{
			get
			{
				return Conversions.ToString(this["Driver3"]);
			}
			set
			{
				this["Driver3"] = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0002F700 File Offset: 0x0002DB00
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0002F720 File Offset: 0x0002DB20
		[DefaultSettingValue("Driver no 4")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Driver4
		{
			get
			{
				return Conversions.ToString(this["Driver4"]);
			}
			set
			{
				this["Driver4"] = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0002F730 File Offset: 0x0002DB30
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0002F750 File Offset: 0x0002DB50
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("1")]
		public int ValdDriver
		{
			get
			{
				return Conversions.ToInteger(this["ValdDriver"]);
			}
			set
			{
				this["ValdDriver"] = value;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0002F764 File Offset: 0x0002DB64
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0002F784 File Offset: 0x0002DB84
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("No Area Chosen")]
		public string Area
		{
			get
			{
				return Conversions.ToString(this["Area"]);
			}
			set
			{
				this["Area"] = value;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0002F794 File Offset: 0x0002DB94
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0002F7B4 File Offset: 0x0002DBB4
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("600")]
		public string Diameter
		{
			get
			{
				return Conversions.ToString(this["Diameter"]);
			}
			set
			{
				this["Diameter"] = value;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0002F7C4 File Offset: 0x0002DBC4
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0002F7E4 File Offset: 0x0002DBE4
		[DebuggerNonUserCode]
		[DefaultSettingValue("11")]
		[UserScopedSetting]
		public string LastColumn
		{
			get
			{
				return Conversions.ToString(this["LastColumn"]);
			}
			set
			{
				this["LastColumn"] = value;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0002F7F4 File Offset: 0x0002DBF4
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0002F814 File Offset: 0x0002DC14
		[DefaultSettingValue("COM1")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string ComPortVald
		{
			get
			{
				return Conversions.ToString(this["ComPortVald"]);
			}
			set
			{
				this["ComPortVald"] = value;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0002F824 File Offset: 0x0002DC24
		// (set) Token: 0x06000395 RID: 917 RVA: 0x0002F844 File Offset: 0x0002DC44
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("15")]
		public float HeightGround
		{
			get
			{
				return Conversions.ToSingle(this["HeightGround"]);
			}
			set
			{
				this["HeightGround"] = value;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0002F858 File Offset: 0x0002DC58
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0002F878 File Offset: 0x0002DC78
		[DefaultSettingValue("C:\\Project\\nr.csv")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string DjupFil
		{
			get
			{
				return Conversions.ToString(this["DjupFil"]);
			}
			set
			{
				this["DjupFil"] = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0002F888 File Offset: 0x0002DC88
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0002F8A8 File Offset: 0x0002DCA8
		[UserScopedSetting]
		[DefaultSettingValue("C:\\Project")]
		[DebuggerNonUserCode]
		public string ProjectBib
		{
			get
			{
				return Conversions.ToString(this["ProjectBib"]);
			}
			set
			{
				this["ProjectBib"] = value;
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0002F8B8 File Offset: 0x0002DCB8
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0002F8D8 File Offset: 0x0002DCD8
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("10")]
		public int Installer
		{
			get
			{
				return Conversions.ToInteger(this["Installer"]);
			}
			set
			{
				this["Installer"] = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0002F8EC File Offset: 0x0002DCEC
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0002F90C File Offset: 0x0002DD0C
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool Novatron
		{
			get
			{
				return Conversions.ToBoolean(this["Novatron"]);
			}
			set
			{
				this["Novatron"] = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0002F920 File Offset: 0x0002DD20
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0002F940 File Offset: 0x0002DD40
		[DebuggerNonUserCode]
		[DefaultSettingValue("COM4")]
		[UserScopedSetting]
		public string NovatronCom
		{
			get
			{
				return Conversions.ToString(this["NovatronCom"]);
			}
			set
			{
				this["NovatronCom"] = value;
			}
		}

		// Token: 0x04000253 RID: 595
		private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000254 RID: 596
		private static bool addedHandler;

		// Token: 0x04000255 RID: 597
		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
	}
}
