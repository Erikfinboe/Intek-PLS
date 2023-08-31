using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace winKCdrill2.My
{
	// Token: 0x02000013 RID: 19
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[HideModuleName]
	[StandardModule]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0002F950 File Offset: 0x0002DD50
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
