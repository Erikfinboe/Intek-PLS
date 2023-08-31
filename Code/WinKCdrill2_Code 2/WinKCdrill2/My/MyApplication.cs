using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace winKCdrill2.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0003286C File Offset: 0x00030C6C
		[STAThread]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerHidden]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000328A4 File Offset: 0x00030CA4
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.ApplicationDefined)
		{
			this.IsSingleInstance = true;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000328CC File Offset: 0x00030CCC
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.TestarKom;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000328E0 File Offset: 0x00030CE0
		[DebuggerStepThrough]
		protected override void OnCreateSplashScreen()
		{
			this.SplashScreen = MyProject.Forms.SplashScreenDrill;
		}
	}
}
