using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace winKCdrill2.My.Resources
{
	// Token: 0x02000011 RID: 17
	[StandardModule]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	[HideModuleName]
	[CompilerGenerated]
	internal sealed class Resources
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0002F564 File Offset: 0x0002D964
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager temp = new ResourceManager("winKCdrill2.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0002F5A4 File Offset: 0x0002D9A4
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0002F5B8 File Offset: 0x0002D9B8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000251 RID: 593
		private static ResourceManager resourceMan;

		// Token: 0x04000252 RID: 594
		private static CultureInfo resourceCulture;
	}
}
