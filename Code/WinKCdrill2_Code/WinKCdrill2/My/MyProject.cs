using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace winKCdrill2.My
{
	// Token: 0x02000004 RID: 4
	[HideModuleName]
	[StandardModule]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00032930 File Offset: 0x00030D30
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00032948 File Offset: 0x00030D48
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00032960 File Offset: 0x00030D60
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00032978 File Offset: 0x00030D78
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00032990 File Offset: 0x00030D90
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000C RID: 12 RVA: 0x000329A8 File Offset: 0x00030DA8
			// (set) Token: 0x06000011 RID: 17 RVA: 0x00032A5C File Offset: 0x00030E5C
			public FormSettings FormSettings
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_FormSettings = MyProject.MyForms.Create__Instance__<FormSettings>(this.m_FormSettings);
					return this.m_FormSettings;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_FormSettings)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<FormSettings>(ref this.m_FormSettings);
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000D RID: 13 RVA: 0x000329CC File Offset: 0x00030DCC
			// (set) Token: 0x06000012 RID: 18 RVA: 0x00032A84 File Offset: 0x00030E84
			public frmTestaApp frmTestaApp
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmTestaApp = MyProject.MyForms.Create__Instance__<frmTestaApp>(this.m_frmTestaApp);
					return this.m_frmTestaApp;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_frmTestaApp)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<frmTestaApp>(ref this.m_frmTestaApp);
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600000E RID: 14 RVA: 0x000329F0 File Offset: 0x00030DF0
			// (set) Token: 0x06000013 RID: 19 RVA: 0x00032AAC File Offset: 0x00030EAC
			public frmTestDrill frmTestDrill
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmTestDrill = MyProject.MyForms.Create__Instance__<frmTestDrill>(this.m_frmTestDrill);
					return this.m_frmTestDrill;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_frmTestDrill)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<frmTestDrill>(ref this.m_frmTestDrill);
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600000F RID: 15 RVA: 0x00032A14 File Offset: 0x00030E14
			// (set) Token: 0x06000014 RID: 20 RVA: 0x00032AD4 File Offset: 0x00030ED4
			public SplashScreenDrill SplashScreenDrill
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_SplashScreenDrill = MyProject.MyForms.Create__Instance__<SplashScreenDrill>(this.m_SplashScreenDrill);
					return this.m_SplashScreenDrill;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_SplashScreenDrill)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<SplashScreenDrill>(ref this.m_SplashScreenDrill);
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000010 RID: 16 RVA: 0x00032A38 File Offset: 0x00030E38
			// (set) Token: 0x06000015 RID: 21 RVA: 0x00032AFC File Offset: 0x00030EFC
			public TestarKom TestarKom
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_TestarKom = MyProject.MyForms.Create__Instance__<TestarKom>(this.m_TestarKom);
					return this.m_TestarKom;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value == this.m_TestarKom)
					{
						return;
					}
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.Dispose__Instance__<TestarKom>(ref this.m_TestarKom);
				}
			}

			// Token: 0x06000016 RID: 22 RVA: 0x00032B24 File Offset: 0x00030F24
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || Instance.IsDisposed)
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string BetterMessage = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(BetterMessage, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
					return Instance;
				}
				return Instance;
			}

			// Token: 0x06000017 RID: 23 RVA: 0x00032C30 File Offset: 0x00031030
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000018 RID: 24 RVA: 0x00032C58 File Offset: 0x00031058
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00032C60 File Offset: 0x00031060
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00032C7C File Offset: 0x0003107C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00032C90 File Offset: 0x00031090
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x0600001C RID: 28 RVA: 0x00032CA8 File Offset: 0x000310A8
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000006 RID: 6
			public FormSettings m_FormSettings;

			// Token: 0x04000007 RID: 7
			public frmTestaApp m_frmTestaApp;

			// Token: 0x04000008 RID: 8
			public frmTestDrill m_frmTestDrill;

			// Token: 0x04000009 RID: 9
			public SplashScreenDrill m_SplashScreenDrill;

			// Token: 0x0400000A RID: 10
			public TestarKom m_TestarKom;

			// Token: 0x0400000B RID: 11
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x0600001D RID: 29 RVA: 0x00032CBC File Offset: 0x000310BC
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600001E RID: 30 RVA: 0x00032CD8 File Offset: 0x000310D8
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600001F RID: 31 RVA: 0x00032CEC File Offset: 0x000310EC
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00032D04 File Offset: 0x00031104
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000021 RID: 33 RVA: 0x00032D18 File Offset: 0x00031118
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return Activator.CreateInstance<T>();
				}
				return instance;
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00032D34 File Offset: 0x00031134
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000023 RID: 35 RVA: 0x00032D50 File Offset: 0x00031150
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000024 RID: 36 RVA: 0x00032D58 File Offset: 0x00031158
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00032D80 File Offset: 0x00031180
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400000C RID: 12
			[ThreadStatic]
			[CompilerGenerated]
			private static T m_ThreadStaticValue;
		}
	}
}
