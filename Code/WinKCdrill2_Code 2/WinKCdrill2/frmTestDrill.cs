using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using winKCdrill2.My;

namespace winKCdrill2
{
	// Token: 0x0200000F RID: 15
	//[DesignerGenerated]
	public partial class frmTestDrill : Form
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000298 RID: 664 RVA: 0x000401DC File Offset: 0x0003E5DC
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000401F0 File Offset: 0x0003E5F0
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000401FC File Offset: 0x0003E5FC
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00040210 File Offset: 0x0003E610
		public virtual TextBox txtSekunder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtSekunder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtSekunder = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0004021C File Offset: 0x0003E61C
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00040230 File Offset: 0x0003E630
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0004023C File Offset: 0x0003E63C
		// (set) Token: 0x0600029F RID: 671 RVA: 0x00040250 File Offset: 0x0003E650
		public virtual TextBox txtNotes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtNotes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtNotes_TextChanged);
				if (this._txtNotes != null)
				{
					this._txtNotes.TextChanged -= value2;
				}
				this._txtNotes = value;
				if (this._txtNotes != null)
				{
					this._txtNotes.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0004029C File Offset: 0x0003E69C
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x000402B0 File Offset: 0x0003E6B0
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x000402BC File Offset: 0x0003E6BC
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x000402D0 File Offset: 0x0003E6D0
		public virtual TextBox txtArea
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtArea;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtArea_TextChanged);
				if (this._txtArea != null)
				{
					this._txtArea.TextChanged -= value2;
				}
				this._txtArea = value;
				if (this._txtArea != null)
				{
					this._txtArea.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0004031C File Offset: 0x0003E71C
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x00040330 File Offset: 0x0003E730
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0004033C File Offset: 0x0003E73C
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x00040350 File Offset: 0x0003E750
		public virtual TextBox txtTotUt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTotUt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTotUt = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0004035C File Offset: 0x0003E75C
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00040370 File Offset: 0x0003E770
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0004037C File Offset: 0x0003E77C
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00040390 File Offset: 0x0003E790
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0004039C File Offset: 0x0003E79C
		// (set) Token: 0x060002AD RID: 685 RVA: 0x000403B0 File Offset: 0x0003E7B0
		public virtual TextBox txtStoppBvikt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtStoppBvikt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtStoppBvikt = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000403BC File Offset: 0x0003E7BC
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000403D0 File Offset: 0x0003E7D0
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000403DC File Offset: 0x0003E7DC
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x000403F0 File Offset: 0x0003E7F0
		public virtual TextBox txtStoppAvikt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtStoppAvikt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtStoppAvikt = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x000403FC File Offset: 0x0003E7FC
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00040410 File Offset: 0x0003E810
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0004041C File Offset: 0x0003E81C
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00040430 File Offset: 0x0003E830
		public virtual TextBox txtStartBvikt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtStartBvikt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtStartBvikt = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0004043C File Offset: 0x0003E83C
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00040450 File Offset: 0x0003E850
		internal virtual Label lblStartAVikt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblStartAVikt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblStartAVikt = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0004045C File Offset: 0x0003E85C
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00040470 File Offset: 0x0003E870
		public virtual TextBox txtStartAvikt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtStartAvikt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtStartAvikt = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0004047C File Offset: 0x0003E87C
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00040490 File Offset: 0x0003E890
		public virtual TextBox txtColNr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtColNr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txtColNr_TextChanged);
				if (this._txtColNr != null)
				{
					this._txtColNr.TextChanged -= value2;
				}
				this._txtColNr = value;
				if (this._txtColNr != null)
				{
					this._txtColNr.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000404DC File Offset: 0x0003E8DC
		// (set) Token: 0x060002BD RID: 701 RVA: 0x000404F0 File Offset: 0x0003E8F0
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000404FC File Offset: 0x0003E8FC
		// (set) Token: 0x060002BF RID: 703 RVA: 0x00040510 File Offset: 0x0003E910
		internal virtual Label lblBinder
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblBinder;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblBinder = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0004051C File Offset: 0x0003E91C
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00040530 File Offset: 0x0003E930
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0004053C File Offset: 0x0003E93C
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00040550 File Offset: 0x0003E950
		internal virtual Button KnappF3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KnappF3_Click);
				if (this._KnappF3 != null)
				{
					this._KnappF3.Click -= value2;
				}
				this._KnappF3 = value;
				if (this._KnappF3 != null)
				{
					this._KnappF3.Click += value2;
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0004059C File Offset: 0x0003E99C
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000405B0 File Offset: 0x0003E9B0
		internal virtual Button KnappF2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KnappF2_Click);
				if (this._KnappF2 != null)
				{
					this._KnappF2.Click -= value2;
				}
				this._KnappF2 = value;
				if (this._KnappF2 != null)
				{
					this._KnappF2.Click += value2;
				}
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000405FC File Offset: 0x0003E9FC
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00040610 File Offset: 0x0003EA10
		internal virtual Label lblDriver
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDriver;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDriver = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0004061C File Offset: 0x0003EA1C
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00040630 File Offset: 0x0003EA30
		internal virtual Button KnappF4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KnappF4_Click);
				if (this._KnappF4 != null)
				{
					this._KnappF4.Click -= value2;
				}
				this._KnappF4 = value;
				if (this._KnappF4 != null)
				{
					this._KnappF4.Click += value2;
				}
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0004067C File Offset: 0x0003EA7C
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00040690 File Offset: 0x0003EA90
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0004069C File Offset: 0x0003EA9C
		// (set) Token: 0x060002CD RID: 717 RVA: 0x000406B0 File Offset: 0x0003EAB0
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000406BC File Offset: 0x0003EABC
		// (set) Token: 0x060002CF RID: 719 RVA: 0x000406D0 File Offset: 0x0003EAD0
		internal virtual Button KnappF1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KnappF1_Click);
				if (this._KnappF1 != null)
				{
					this._KnappF1.Click -= value2;
				}
				this._KnappF1 = value;
				if (this._KnappF1 != null)
				{
					this._KnappF1.Click += value2;
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0004071C File Offset: 0x0003EB1C
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00040730 File Offset: 0x0003EB30
		public virtual TextBox txtStign
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtStign;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtStign = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x0004073C File Offset: 0x0003EB3C
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00040750 File Offset: 0x0003EB50
		internal virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x0004075C File Offset: 0x0003EB5C
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x00040770 File Offset: 0x0003EB70
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x0004077C File Offset: 0x0003EB7C
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x00040790 File Offset: 0x0003EB90
		public virtual TextBox txtBindOut
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtBindOut;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtBindOut = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0004079C File Offset: 0x0003EB9C
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000407B0 File Offset: 0x0003EBB0
		internal virtual Label lblClip
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblClip;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblClip = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000407BC File Offset: 0x0003EBBC
		// (set) Token: 0x060002DB RID: 731 RVA: 0x000407D0 File Offset: 0x0003EBD0
		internal virtual GroupBox GroupBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox6 = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000407DC File Offset: 0x0003EBDC
		// (set) Token: 0x060002DD RID: 733 RVA: 0x000407F0 File Offset: 0x0003EBF0
		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000407FC File Offset: 0x0003EBFC
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00040810 File Offset: 0x0003EC10
		internal virtual Label lblNoCom
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblNoCom;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblNoCom = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0004081C File Offset: 0x0003EC1C
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00040830 File Offset: 0x0003EC30
		internal virtual System.Windows.Forms.Timer tmrInSignaler
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tmrInSignaler;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tmrInSignaler_Tick);
				if (this._tmrInSignaler != null)
				{
					this._tmrInSignaler.Tick -= value2;
				}
				this._tmrInSignaler = value;
				if (this._tmrInSignaler != null)
				{
					this._tmrInSignaler.Tick += value2;
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0004087C File Offset: 0x0003EC7C
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00040890 File Offset: 0x0003EC90
		internal virtual GroupBox GroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x0004089C File Offset: 0x0003EC9C
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x000408B0 File Offset: 0x0003ECB0
		internal virtual System.Windows.Forms.Timer tmrPelare
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tmrPelare;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.tmrPelare_Tick);
				if (this._tmrPelare != null)
				{
					this._tmrPelare.Tick -= value2;
				}
				this._tmrPelare = value;
				if (this._tmrPelare != null)
				{
					this._tmrPelare.Tick += value2;
				}
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000408FC File Offset: 0x0003ECFC
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00040910 File Offset: 0x0003ED10
		internal virtual DataGrid DataGrid1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataGrid1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.dataGrid1_CurCellChange);
				EventHandler value3 = new EventHandler(this.DataGrid1_leave);
				if (this._DataGrid1 != null)
				{
					this._DataGrid1.CurrentCellChanged -= value2;
					this._DataGrid1.Leave -= value3;
				}
				this._DataGrid1 = value;
				if (this._DataGrid1 != null)
				{
					this._DataGrid1.CurrentCellChanged += value2;
					this._DataGrid1.Leave += value3;
				}
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00040980 File Offset: 0x0003ED80
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00040994 File Offset: 0x0003ED94
		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000409A0 File Offset: 0x0003EDA0
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000409B4 File Offset: 0x0003EDB4
		internal virtual Button KnappF5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KnappF5 = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000409C0 File Offset: 0x0003EDC0
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000409D4 File Offset: 0x0003EDD4
		internal virtual Label lblDjup
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblDjup;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblDjup = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000409E0 File Offset: 0x0003EDE0
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000409F4 File Offset: 0x0003EDF4
		internal virtual Label lblTempKomp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTempKomp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTempKomp = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00040A00 File Offset: 0x0003EE00
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x00040A14 File Offset: 0x0003EE14
		internal virtual Label lblFuktighet
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblFuktighet;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblFuktighet = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00040A20 File Offset: 0x0003EE20
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00040A34 File Offset: 0x0003EE34
		internal virtual Label lblTryckRör
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTryckRör;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTryckRör = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00040A40 File Offset: 0x0003EE40
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00040A54 File Offset: 0x0003EE54
		internal virtual PictureBox PicUtA8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtA8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtA8 = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00040A60 File Offset: 0x0003EE60
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00040A74 File Offset: 0x0003EE74
		internal virtual PictureBox PicUtA7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtA7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtA7 = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00040A80 File Offset: 0x0003EE80
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00040A94 File Offset: 0x0003EE94
		internal virtual PictureBox PicUtA6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtA6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtA6 = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00040AA0 File Offset: 0x0003EEA0
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00040AB4 File Offset: 0x0003EEB4
		internal virtual PictureBox PicUtA5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtA5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtA5 = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00040AC0 File Offset: 0x0003EEC0
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00040AD4 File Offset: 0x0003EED4
		internal virtual PictureBox PicBlåsUt1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBlåsUt1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicBlåsUt1 = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00040AE0 File Offset: 0x0003EEE0
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00040AF4 File Offset: 0x0003EEF4
		internal virtual PictureBox PicBlåsV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBlåsV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicBlåsV = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00040B00 File Offset: 0x0003EF00
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00040B14 File Offset: 0x0003EF14
		internal virtual PictureBox PicInB1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicInB1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicInB1 = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00040B20 File Offset: 0x0003EF20
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00040B34 File Offset: 0x0003EF34
		internal virtual Button KnappF10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KnappF10_Click);
				if (this._KnappF10 != null)
				{
					this._KnappF10.Click -= value2;
				}
				this._KnappF10 = value;
				if (this._KnappF10 != null)
				{
					this._KnappF10.Click += value2;
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00040B80 File Offset: 0x0003EF80
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00040B94 File Offset: 0x0003EF94
		internal virtual Button KnappF9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KnappF9 = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00040BA0 File Offset: 0x0003EFA0
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00040BB4 File Offset: 0x0003EFB4
		internal virtual Button KnappF8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KnappF8_Click);
				if (this._KnappF8 != null)
				{
					this._KnappF8.Click -= value2;
				}
				this._KnappF8 = value;
				if (this._KnappF8 != null)
				{
					this._KnappF8.Click += value2;
				}
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00040C00 File Offset: 0x0003F000
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00040C14 File Offset: 0x0003F014
		internal virtual System.Windows.Forms.Timer TimerCellmat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TimerCellmat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TimerCellmat = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00040C20 File Offset: 0x0003F020
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00040C34 File Offset: 0x0003F034
		internal virtual Label lblTeoUt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTeoUt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTeoUt = value;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00040C40 File Offset: 0x0003F040
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00040C54 File Offset: 0x0003F054
		internal virtual Button KnappF7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KnappF7_Click);
				if (this._KnappF7 != null)
				{
					this._KnappF7.Click -= value2;
				}
				this._KnappF7 = value;
				if (this._KnappF7 != null)
				{
					this._KnappF7.Click += value2;
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00040CA0 File Offset: 0x0003F0A0
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00040CB4 File Offset: 0x0003F0B4
		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00040CC0 File Offset: 0x0003F0C0
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00040CD4 File Offset: 0x0003F0D4
		internal virtual Label lblMättUt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblMättUt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblMättUt = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00040CE0 File Offset: 0x0003F0E0
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00040CF4 File Offset: 0x0003F0F4
		internal virtual PictureBox PicBlåsUt7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBlåsUt7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicBlåsUt7 = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00040D00 File Offset: 0x0003F100
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00040D14 File Offset: 0x0003F114
		internal virtual PictureBox PicUtB1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtB1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtB1 = value;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00040D20 File Offset: 0x0003F120
		// (set) Token: 0x06000317 RID: 791 RVA: 0x00040D34 File Offset: 0x0003F134
		internal virtual PictureBox PicBlåsUt6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBlåsUt6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicBlåsUt6 = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00040D40 File Offset: 0x0003F140
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00040D54 File Offset: 0x0003F154
		internal virtual PictureBox PicBlåsUt5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBlåsUt5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicBlåsUt5 = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00040D60 File Offset: 0x0003F160
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00040D74 File Offset: 0x0003F174
		internal virtual PictureBox PicBlåsUt4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBlåsUt4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicBlåsUt4 = value;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00040D80 File Offset: 0x0003F180
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00040D94 File Offset: 0x0003F194
		internal virtual PictureBox PicBlåsUt3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBlåsUt3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicBlåsUt3 = value;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00040DA0 File Offset: 0x0003F1A0
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00040DB4 File Offset: 0x0003F1B4
		internal virtual PictureBox PicBlåsUt2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBlåsUt2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicBlåsUt2 = value;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00040DC0 File Offset: 0x0003F1C0
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00040DD4 File Offset: 0x0003F1D4
		internal virtual PictureBox PicUtA4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtA4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtA4 = value;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00040DE0 File Offset: 0x0003F1E0
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00040DF4 File Offset: 0x0003F1F4
		internal virtual PictureBox PicUtA3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtA3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtA3 = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00040E00 File Offset: 0x0003F200
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00040E14 File Offset: 0x0003F214
		internal virtual PictureBox PicUtA2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtA2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtA2 = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00040E20 File Offset: 0x0003F220
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00040E34 File Offset: 0x0003F234
		internal virtual PictureBox PicUtA1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicUtA1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicUtA1 = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00040E40 File Offset: 0x0003F240
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00040E54 File Offset: 0x0003F254
		internal virtual PictureBox PicCompUt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicCompUt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicCompUt = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00040E60 File Offset: 0x0003F260
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00040E74 File Offset: 0x0003F274
		internal virtual PictureBox PicInA1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicInA1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicInA1 = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00040E80 File Offset: 0x0003F280
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00040E94 File Offset: 0x0003F294
		internal virtual PictureBox PicBorr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicBorr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.PicBorr_Paint);
				if (this._PicBorr != null)
				{
					this._PicBorr.Paint -= value2;
				}
				this._PicBorr = value;
				if (this._PicBorr != null)
				{
					this._PicBorr.Paint += value2;
				}
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00040EE0 File Offset: 0x0003F2E0
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00040EF4 File Offset: 0x0003F2F4
		internal virtual PictureBox PicMark
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PicMark;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PicMark = value;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00040F00 File Offset: 0x0003F300
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00040F14 File Offset: 0x0003F314
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.PictureBox2_Paint);
				if (this._PictureBox2 != null)
				{
					this._PictureBox2.Paint -= value2;
				}
				this._PictureBox2 = value;
				if (this._PictureBox2 != null)
				{
					this._PictureBox2.Paint += value2;
				}
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00040F60 File Offset: 0x0003F360
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00040F74 File Offset: 0x0003F374
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.PictureBox1_Paint);
				if (this._PictureBox1 != null)
				{
					this._PictureBox1.Paint -= value2;
				}
				this._PictureBox1 = value;
				if (this._PictureBox1 != null)
				{
					this._PictureBox1.Paint += value2;
				}
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00040FC0 File Offset: 0x0003F3C0
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00040FD4 File Offset: 0x0003F3D4
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00040FE0 File Offset: 0x0003F3E0
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00040FF4 File Offset: 0x0003F3F4
		internal virtual ToolTip ToolTip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00041000 File Offset: 0x0003F400
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00041014 File Offset: 0x0003F414
		internal virtual Label lblJunttan
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblJunttan;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblJunttan = value;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00041020 File Offset: 0x0003F420
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00041034 File Offset: 0x0003F434
		internal virtual Panel Panel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel2 = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00041040 File Offset: 0x0003F440
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00041054 File Offset: 0x0003F454
		internal virtual Button KnappF6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KnappF6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._KnappF6 = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00041060 File Offset: 0x0003F460
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00041074 File Offset: 0x0003F474
		internal virtual Label lblInfoFst
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblInfoFst;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblInfoFst = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00041080 File Offset: 0x0003F480
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00041094 File Offset: 0x0003F494
		public virtual TextBox txtToDepth
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtToDepth;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtToDepth = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000410A0 File Offset: 0x0003F4A0
		// (set) Token: 0x06000343 RID: 835 RVA: 0x000410B4 File Offset: 0x0003F4B4
		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000410C0 File Offset: 0x0003F4C0
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000410D4 File Offset: 0x0003F4D4
		internal virtual Label Label15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label15 = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000346 RID: 838 RVA: 0x000410E0 File Offset: 0x0003F4E0
		// (set) Token: 0x06000347 RID: 839 RVA: 0x000410F4 File Offset: 0x0003F4F4
		public virtual TextBox txtTeoLängd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtTeoLängd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtTeoLängd = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00041100 File Offset: 0x0003F500
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00041114 File Offset: 0x0003F514
		public virtual TextBox txtDjupHåkan
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtDjupHåkan;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtDjupHåkan = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00041120 File Offset: 0x0003F520
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00041134 File Offset: 0x0003F534
		internal virtual SerialPort SerieNovatron
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SerieNovatron;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SerieNovatron = value;
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00041140 File Offset: 0x0003F540
		public frmTestDrill()
		{
			base.KeyDown += this.frmTestDrill_KeyDown;
			base.Paint += this.frmTestDrill_Paint;
			base.VisibleChanged += this.frmHuvud_VisibleChanged;
			this.TankA = new RitaTank();
			this.TankB = new RitaTank();
			this.RörKompUt = new RitaRörH();
			this.VBlås = new Ventil();
			this.VBlåsTip = new ToolTip();
			this.RörInA = new RitaRörV();
			this.RörInB = new RitaRörV();
			this.RörUtA1 = new RitaKrökUV();
			this.RörUtA2 = new RitaRörV();
			this.RörUtA3 = new RitaKrökÖH();
			this.RörUtA4 = new RitaRörH();
			this.RörUtA5 = new RitaKrökÖV();
			this.RörUtA6 = new RitaRörV();
			this.RörUtA7 = new RitaKrökUV();
			this.RörUtA8 = new RitaRörH();
			this.RörUtB1 = new RitaRörH();
			this.BlåsUt1 = new RitaRörH();
			this.BlåsUt2 = new RitaKrökÖV();
			this.BlåsUt3 = new RitaRörV();
			this.BlåsUt4 = new RitaKrökUH();
			this.BlåsUt5 = new RitaRörH();
			this.BlåsUt6 = new RitaKrökUV();
			this.BlåsUt7 = new RitaRörV();
			this.Röret = new Borr();
			this.PelarenNormAvslut = false;
			this.iData = Clipboard.GetDataObject();
			this.TestForm = new frmTestaApp();
			this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad_Init = new StaticLocalInitFlag();
			this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt_Init = new StaticLocalInitFlag();
			this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt_Init = new StaticLocalInitFlag();
			this.InitializeComponent();
			this.TankA.Picbox = this.PictureBox1;
			this.TankB.ValvAvluftNamn = "V 204B";
			this.TankB.ValvInBindNamn = "HV 24";
			this.TankB.ValvUtBindNamn = "HV 25";
			this.TankB.ValvUtNamn = "V 201B";
			this.TankB.TankNamn = "B";
			this.TankB.Picbox = this.PictureBox2;
			this.RörKompUt.PicBox = this.PicCompUt;
			this.VBlåsTip.SetToolTip(this.PicBlåsV, "Initierad");
			Ventil vblås = this.VBlås;
			PictureBox picBlåsV = this.PicBlåsV;
			vblås.InitValve(ref picBlåsV, false, ref this.VBlåsTip, "V 202");
			this.PicBlåsV = picBlåsV;
			this.RörInA.PicBox = this.PicInA1;
			this.RörInB.PicBox = this.PicInB1;
			this.RörUtA1.PicBox = this.PicUtA1;
			this.RörUtA2.PicBox = this.PicUtA2;
			this.RörUtA3.PicBox = this.PicUtA3;
			this.RörUtA4.PicBox = this.PicUtA4;
			this.RörUtA5.PicBox = this.PicUtA5;
			this.RörUtA6.PicBox = this.PicUtA6;
			this.RörUtA7.PicBox = this.PicUtA7;
			this.RörUtA8.PicBox = this.PicUtA8;
			this.RörUtB1.PicBox = this.PicUtB1;
			this.BlåsUt1.PicBox = this.PicBlåsUt1;
			this.BlåsUt2.PicBox = this.PicBlåsUt2;
			this.BlåsUt3.PicBox = this.PicBlåsUt3;
			this.BlåsUt4.PicBox = this.PicBlåsUt4;
			this.BlåsUt5.PicBox = this.PicBlåsUt5;
			this.BlåsUt6.PicBox = this.PicBlåsUt6;
			this.BlåsUt7.PicBox = this.PicBlåsUt7;
			this.Röret.JordYta = checked(this.PicMark.Top - this.PicBorr.Top);
			this.Röret.PicBox = this.PicBorr;
			this.Röret.BorrLängd = 25f;
			this.Röret.JordBotten = 25f;
			this.Text = " Application for soil mixing Version: " + MyProject.Application.Info.Version.ToString();
			MyProject.Application.Info.Version.ToString();
			this.DoubleBuffered = true;
			this.DjupFilopen();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00041564 File Offset: 0x0003F964
		public void DjupFilopen()
		{
			this.DjupUppgift = false;
			checked
			{
				if (MyProject.Computer.FileSystem.FileExists(MySettingsProperty.Settings.DjupFil))
				{
					StreamReader sr = new StreamReader(MySettingsProperty.Settings.DjupFil);
					int[] pos = new int[13];
					string Rad;
					string[] rader = null;
					try
					{
						do
						{
							Rad = sr.ReadLine();
							int i = 0;
							rader = (string[])Utils.CopyArray((Array)rader, new string[i + 1]);
							rader[i] = Rad;
							i++;
						}
						while (Rad != null);
					}
					catch (Exception ex)
					{
						Interaction.MsgBox("The Dayreport-file could not be opened", MsgBoxStyle.OkOnly, null);
						Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
						this.DjupUppgift = false;
						return;
					}
					int antal = Information.UBound(rader, 1) - 1;
					this.VektNr = new int[antal + 1];
					this.VektX = new double[antal + 1];
					this.VektY = new double[antal + 1];
					this.VektDjup = new float[antal + 1];
					this.DjupUppgift = true;
					try
					{
						int num = 1;
						int num2 = antal;
						for (int j = num; j <= num2; j++)
						{
							if (Operators.CompareString(rader[j], "", false) == 0)
							{
								break;
							}
							int k = 1;
							int num3 = 1;
							int num4 = Strings.Len(rader[j]);
							for (int i = num3; i <= num4; i++)
							{
								Rad = rader[j];
								if (Operators.CompareString(Strings.Mid(Rad, i, 1), ",", false) == 0)
								{
									pos[k] = i;
									k++;
								}
							}
							this.VektNr[j - 1] = Conversions.ToInteger(Strings.Mid(Rad, 1, pos[1] - 1));
							this.VektX[j - 1] = Conversions.ToDouble(Strings.Mid(Rad, pos[1] + 1, pos[2] - (pos[1] + 1)));
							this.VektY[j - 1] = Conversions.ToDouble(Strings.Mid(Rad, pos[2] + 1, pos[3] - (pos[2] + 1)));
							this.VektDjup[j - 1] = Conversions.ToSingle(Strings.Mid(Rad, pos[3] + 1, Strings.Len(Rad) - pos[3]));
						}
					}
					catch (Exception ex2)
					{
						this.DjupUppgift = false;
						int j = 0;
						string meddel = " Kan inte läsa Nr/djup filen helt fel på rad " + Conversions.ToString(j + 1);
						Interaction.MsgBox(meddel + ex2.Message, MsgBoxStyle.OkOnly, null);
					}
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (set) Token: 0x0600034E RID: 846 RVA: 0x000417DC File Offset: 0x0003FBDC
		public FestoCom InSignal
		{
			set
			{
				this.mSignaler = value;
				this.tmrInSignaler.Enabled = true;
				this.tmrInSignaler.Interval = 1000;
			}
		}

		// Token: 0x1700019E RID: 414
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00041804 File Offset: 0x0003FC04
		public clsPelare AktPelare
		{
			set
			{
				this.Pelare = value;
				this.Pelare.PicBoxMark = this.PicMark;
				this.Pelare.LabelDjup = this.lblDjup;
				this.Pelare.LabelMättUt = this.lblMättUt;
				this.Pelare.LabelTeoUt = this.lblTeoUt;
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0004185C File Offset: 0x0003FC5C
		private void sättPCx()
		{
			Point punkt = new Point();
			punkt.X = 100;
			punkt.Y = 100;
			if (!this.STATIC_sättPCx_2001_Borr)
			{
				this.WindowState = FormWindowState.Normal;
				this.Location = punkt;
				this.Width = 100;
				this.Height = 100;
				this.STATIC_sättPCx_2001_Borr = true;
				return;
			}
			if (this.STATIC_sättPCx_2001_Borr)
			{
				this.Width = 101;
				this.WindowState = FormWindowState.Maximized;
				this.STATIC_sättPCx_2001_Borr = false;
				Clipboard.SetDataObject("JUNTTAN10:KCD;94");
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000418D4 File Offset: 0x0003FCD4
		private void PressureKomp(float Pressure)
		{
			this.RörKompUt.tryck = Pressure;
			this.RörInA.tryck = Pressure;
			this.RörInB.tryck = Pressure;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x000418FC File Offset: 0x0003FCFC
		private void PressureRör(float Pressure)
		{
			this.lblTryckRör.Text = Strings.Format(Pressure, "0.00");
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0004191C File Offset: 0x0003FD1C
		private void PressureSvivel(float Pressure)
		{
			this.RörUtA1.tryck = Pressure;
			this.RörUtA2.tryck = Pressure;
			this.RörUtA3.tryck = Pressure;
			this.RörUtA4.tryck = Pressure;
			this.RörUtA5.tryck = Pressure;
			this.RörUtA6.tryck = Pressure;
			this.RörUtA7.tryck = Pressure;
			this.RörUtA8.tryck = Pressure;
			this.RörUtB1.tryck = Pressure;
			this.BlåsUt1.tryck = Pressure;
			this.BlåsUt2.tryck = Pressure;
			this.BlåsUt3.tryck = Pressure;
			this.BlåsUt4.tryck = Pressure;
			this.BlåsUt5.tryck = Pressure;
			this.BlåsUt6.tryck = Pressure;
			this.BlåsUt7.tryck = Pressure;
			this.Röret.Tryck(Pressure);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000419F8 File Offset: 0x0003FDF8
		private void TankVäxla()
		{
			if (this.TankA.Aktiv & this.TankB.Aktiv)
			{
				this.TankB.Aktiv = false;
				this.Pelare.ViktBUt = false;
				return;
			}
			if (this.TankA.Aktiv & !this.TankB.Aktiv)
			{
				this.TankA.Aktiv = false;
				this.Pelare.ViktAUt = false;
				this.TankB.Aktiv = true;
				this.Pelare.ViktBUt = true;
				return;
			}
			if (!this.TankA.Aktiv & this.TankB.Aktiv)
			{
				this.TankA.Aktiv = true;
				this.Pelare.ViktAUt = true;
				this.TankB.Aktiv = true;
				this.Pelare.ViktBUt = true;
				return;
			}
			this.Invalidate();
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00041AD8 File Offset: 0x0003FED8
		private void Fuktighet(float RH)
		{
			this.lblFuktighet.Text = Strings.Format(RH, "0.0") + " RH";
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00041B00 File Offset: 0x0003FF00
		private void TempKomp(float Temp)
		{
			this.lblTempKomp.Text = Strings.Format(Temp, "0.0") + " C";
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00041B28 File Offset: 0x0003FF28
		private void Nolla()
		{
			this.mSignaler.IPCnolla = true;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00041B38 File Offset: 0x0003FF38
		private void StartPelare()
		{
			if (!this.KnappF3.Enabled)
			{
				return;
			}
			int num = 0;
			checked
			{
				int num2 = this.Pelare.Tabell.Rows.Count - 1;
				for (int i = num; i <= num2; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(this.Pelare.Tabell.Rows[i][2], this.txtColNr.Text, false))
					{
						Interaction.MsgBox("  Same number used  ", MsgBoxStyle.OkOnly, "  Change number");
						return;
					}
				}
				this.PelarenNormAvslut = false;
				if (Conversions.ToSingle(this.mSignaler.MätDjup) < Conversions.ToSingle(this.mSignaler.PelStoppDjup))
				{
					Interaction.MsgBox(" Depth must bee more than Autostopp depth ", MsgBoxStyle.OkOnly, null);
					return;
				}
				this.lblInfoFst.Text = "";
				this.KnappF3.Enabled = false;
				this.KnappF4.Enabled = true;
				this.mSignaler.IPCpelStart = true;
				this.Pelare.NyPelareStart();
				this.tmrPelare.Enabled = true;
				float Djup = (float)(Conversions.ToDouble(this.mSignaler.MätDjup) / 1000.0);
				string strDjup = Strings.Format(Djup, "0.000");
				string DjupSträng = "JUNTTAN10:KCD;98," + strDjup;
				Clipboard.SetDataObject(DjupSträng);
				if (MySettingsProperty.Settings.Novatron)
				{
					string K = ",";
					string svar = string.Concat(new string[]
					{
						"DRILL",
						K,
						this.NovatronPelNr,
						K,
						"Start",
						K,
						strDjup,
						K,
						this.Tid(),
						"\r\n"
					});
					this.SerieNovatron.Write(svar);
				}
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00041CFC File Offset: 0x000400FC
		private void StoppPelare()
		{
			if (!this.KnappF4.Enabled)
			{
				return;
			}
			this.mSignaler.IPCpelStopp = true;
			this.tmrPelare.Enabled = false;
			this.Pelare.PelareFärdig();
			this.KnappF4.Enabled = false;
			this.KnappF3.Enabled = true;
			float Djup = (float)(Conversions.ToDouble(this.mSignaler.MätDjup) / 1000.0);
			string strDjup = Strings.Format(Djup, "0.000");
			if (this.PelarenNormAvslut)
			{
				string DjupSträng = "JUNTTAN10:KCD;96," + strDjup;
				Clipboard.SetDataObject(DjupSträng);
			}
			else
			{
				string DjupSträng = "JUNTTAN10:KCD;95," + strDjup;
				Clipboard.SetDataObject(DjupSträng);
			}
			this.Röret.JordBotten = 25f;
			this.ProdIdag();
			if (this.mAreaChange)
			{
				MySettingsProperty.Settings.Area = this.txtArea.Text;
			}
			MySettingsProperty.Settings.Save();
			this.txtNotes.Text = "None";
			if (this.DjupUppgift)
			{
				string FileXY = string.Concat(new string[]
				{
					MySettingsProperty.Settings.ProjectBib,
					"\\",
					this.Pelare.Datum,
					"KC",
					this.Pelare.Installer,
					".xyz"
				});
				StreamWriter swXY = new StreamWriter(FileXY, true);
				string i = ",";
				try
				{
					swXY.WriteLine(string.Concat(new string[]
					{
						Conversions.ToString(this.VektNr[this.VektAktIndex]),
						i,
						Strings.Format(this.VektX[this.VektAktIndex], "0.000"),
						i,
						Strings.Format(this.VektY[this.VektAktIndex], "0.000"),
						i,
						Strings.Format(MySettingsProperty.Settings.HeightGround, "0.000"),
						i,
						Strings.Format(this.AktDeltaX, "0.000"),
						i,
						Strings.Format(this.AktdeltaY, "0.000"),
						i,
						Strings.Format(this.AktDeltaPich, "0.000"),
						i,
						Strings.Format(this.AktdeltaRoll, "0.000")
					}));
					swXY.Close();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox(ex.ToString() + " Not possible to save XY file ", MsgBoxStyle.OkOnly, " File system warning ");
					swXY.Close();
				}
			}
			if (MySettingsProperty.Settings.Novatron)
			{
				string K = ",";
				string svar = string.Concat(new string[]
				{
					"DRILL",
					K,
					this.NovatronPelNr,
					K,
					"Ready",
					K,
					strDjup,
					K,
					this.Tid(),
					"\r\n"
				});
				this.SerieNovatron.Write(svar);
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00042064 File Offset: 0x00040464
		private void ProdIdag()
		{
			this.DataGrid1.DataSource = this.Pelare.Tabell;
			if (!this.STATIC_ProdIdag_2001_boolGjort)
			{
				string col = this.Pelare.Tabell.Columns[0].ColumnName;
				string col2 = this.Pelare.Tabell.Columns[2].ColumnName;
				string colA = this.Pelare.Tabell.Columns[10].ColumnName;
				string col3 = this.Pelare.Tabell.Columns[3].ColumnName;
				string col4 = this.Pelare.Tabell.Columns[4].ColumnName;
				string col5 = this.Pelare.Tabell.Columns[5].ColumnName;
				string col6 = this.Pelare.Tabell.Columns[7].ColumnName;
				DataGridTableStyle StilDagRapp = new DataGridTableStyle();
				StilDagRapp.MappingName = "DagRapport";
				StilDagRapp.RowHeadersVisible = false;
				DataGridTextBoxColumn NrIdag = new DataGridTextBoxColumn();
				NrIdag.MappingName = col;
				NrIdag.HeaderText = "nos :";
				NrIdag.Width = 40;
				NrIdag.ReadOnly = true;
				NrIdag.Alignment = HorizontalAlignment.Right;
				StilDagRapp.GridColumnStyles.Add(NrIdag);
				DataGridTextBoxColumn ColNr = new DataGridTextBoxColumn();
				ColNr.MappingName = col2;
				ColNr.HeaderText = "Col no :";
				ColNr.Width = 75;
				ColNr.ReadOnly = false;
				ColNr.Alignment = HorizontalAlignment.Right;
				StilDagRapp.GridColumnStyles.Add(ColNr);
				DataGridTextBoxColumn Area = new DataGridTextBoxColumn();
				Area.MappingName = colA;
				Area.HeaderText = "Area :";
				Area.Width = 75;
				Area.ReadOnly = false;
				Area.Alignment = HorizontalAlignment.Right;
				StilDagRapp.GridColumnStyles.Add(Area);
				DataGridTextBoxColumn Djup = new DataGridTextBoxColumn();
				Djup.MappingName = col3;
				Djup.HeaderText = "Depth :";
				Djup.Width = 55;
				Djup.ReadOnly = true;
				Djup.Alignment = HorizontalAlignment.Right;
				StilDagRapp.GridColumnStyles.Add(Djup);
				DataGridTextBoxColumn EffLängd = new DataGridTextBoxColumn();
				EffLängd.MappingName = col4;
				EffLängd.HeaderText = "Stop :";
				EffLängd.Width = 55;
				EffLängd.ReadOnly = true;
				EffLängd.Alignment = HorizontalAlignment.Right;
				StilDagRapp.GridColumnStyles.Add(EffLängd);
				this.DataGrid1.TableStyles.Add(StilDagRapp);
				DataGridTextBoxColumn MedelB = new DataGridTextBoxColumn();
				MedelB.MappingName = col5;
				MedelB.HeaderText = "kg/m :";
				MedelB.Width = 55;
				MedelB.ReadOnly = true;
				MedelB.Alignment = HorizontalAlignment.Right;
				StilDagRapp.GridColumnStyles.Add(MedelB);
				DataGridTextBoxColumn Notes = new DataGridTextBoxColumn();
				Notes.MappingName = col6;
				Notes.HeaderText = "Notes";
				Notes.Width = 90;
				Notes.ReadOnly = false;
				Notes.Alignment = HorizontalAlignment.Left;
				StilDagRapp.GridColumnStyles.Add(Notes);
				this.DataGrid1.TableStyles.Add(StilDagRapp);
				this.STATIC_ProdIdag_2001_boolGjort = true;
			}
			DataGridCell plats = new DataGridCell();
			plats.ColumnNumber = 0;
			plats.RowNumber = this.Pelare.Tabell.Rows.Count;
			checked
			{
				if (plats.RowNumber >= 1)
				{
					plats.RowNumber--;
				}
				this.DataGrid1.CurrentCell = plats;
				this.txtColNr.Focus();
				if (this.Pelare.AntalPel >= 1)
				{
					this.GroupBox3.Text = string.Concat(new string[]
					{
						"Columns Today = ",
						Conversions.ToString(this.Pelare.AntalPel),
						" st,  ",
						Strings.Format(this.Pelare.TotBorrat, "# ##0"),
						" m,  ",
						Strings.Format(this.Pelare.TotMBinder, "# ##0"),
						" m and ",
						Strings.Format(this.Pelare.DagTotKg, "## ##0"),
						" kg"
					});
				}
				else
				{
					this.GroupBox3.Text = "Columns Today = None";
				}
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x000424A8 File Offset: 0x000408A8
		private void VäxlaTillSignal()
		{
			MyProject.Forms.TestarKom.Visible = true;
			this.Visible = false;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x000424C4 File Offset: 0x000408C4
		private void Avsluta()
		{
			if (this.mAreaChange)
			{
				MySettingsProperty.Settings.Area = this.txtArea.Text;
			}
			Application.Exit();
		}

		// Token: 0x0600035D RID: 861 RVA: 0x000424E8 File Offset: 0x000408E8
		private void DataGrid1_leave(object sender, EventArgs e)
		{
			if (this.Pelare.AntalPel > 1)
			{
				DataGridCell cell = new DataGridCell();
				cell.ColumnNumber = 0;
				cell.RowNumber = checked(this.Pelare.AntalPel - 1);
				this.DataGrid1.CurrentCell = cell;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0004252C File Offset: 0x0004092C
		private void dataGrid1_CurCellChange(object sender, EventArgs e)
		{
			if (this.STATIC_dataGrid1_CurCellChange_20211C1265_Ändrat)
			{
				this.STATIC_dataGrid1_CurCellChange_20211C1265_Ändrat = false;
				return;
			}
			if (!this.STATIC_dataGrid1_CurCellChange_20211C1265_Första)
			{
				this.STATIC_dataGrid1_CurCellChange_20211C1265_Cellen = this.DataGrid1.CurrentCell;
				this.STATIC_dataGrid1_CurCellChange_20211C1265_CellVärde = Conversions.ToString(this.DataGrid1[this.STATIC_dataGrid1_CurCellChange_20211C1265_Cellen]);
				this.STATIC_dataGrid1_CurCellChange_20211C1265_Första = true;
				return;
			}
			DataGridCell testCell = this.DataGrid1.CurrentCell;
			if (Operators.ConditionalCompareObjectNotEqual(this.DataGrid1[this.STATIC_dataGrid1_CurCellChange_20211C1265_Cellen], this.STATIC_dataGrid1_CurCellChange_20211C1265_CellVärde, false))
			{
				MsgBoxResult msg = Interaction.MsgBox("Do yuo want to change this value ?", MsgBoxStyle.OkCancel, "Value of a cell is changed!");
				if (msg == MsgBoxResult.Ok)
				{
					this.Pelare.SparaOmDagRapp();
				}
				if (msg == MsgBoxResult.Cancel)
				{
					this.DataGrid1[this.STATIC_dataGrid1_CurCellChange_20211C1265_Cellen] = this.STATIC_dataGrid1_CurCellChange_20211C1265_CellVärde;
					this.STATIC_dataGrid1_CurCellChange_20211C1265_Cellen = this.DataGrid1.CurrentCell;
					this.STATIC_dataGrid1_CurCellChange_20211C1265_CellVärde = Conversions.ToString(this.DataGrid1[this.STATIC_dataGrid1_CurCellChange_20211C1265_Cellen]);
					this.STATIC_dataGrid1_CurCellChange_20211C1265_Ändrat = true;
					return;
				}
			}
			checked
			{
				if (this.DataGrid1.CurrentRowIndex > this.Pelare.AntalPel - 1)
				{
					this.DataGrid1.CurrentRowIndex = this.Pelare.AntalPel - 1;
				}
				this.STATIC_dataGrid1_CurCellChange_20211C1265_Cellen = this.DataGrid1.CurrentCell;
				this.STATIC_dataGrid1_CurCellChange_20211C1265_CellVärde = Conversions.ToString(this.DataGrid1[this.STATIC_dataGrid1_CurCellChange_20211C1265_Cellen]);
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00042684 File Offset: 0x00040A84
		private void KnappF1_Click(object sender, EventArgs e)
		{
			this.sättPCx();
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0004268C File Offset: 0x00040A8C
		private void KnappF2_Click(object sender, EventArgs e)
		{
			this.Nolla();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00042694 File Offset: 0x00040A94
		private void KnappF3_Click(object sender, EventArgs e)
		{
			this.StartPelare();
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0004269C File Offset: 0x00040A9C
		private void KnappF4_Click(object sender, EventArgs e)
		{
			this.StoppPelare();
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000426A4 File Offset: 0x00040AA4
		private void KnappF7_Click(object sender, EventArgs e)
		{
			this.VäxlaTillSignal();
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000426AC File Offset: 0x00040AAC
		private void KnappF8_Click(object sender, EventArgs e)
		{
			this.TankVäxla();
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000426B4 File Offset: 0x00040AB4
		private void KnappF10_Click(object sender, EventArgs e)
		{
			this.Avsluta();
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000426BC File Offset: 0x00040ABC
		private void frmTestDrill_Paint(object sender, PaintEventArgs e)
		{
			if (!this.mSignaler.ComÄrUppDat)
			{
				return;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000426CC File Offset: 0x00040ACC
		private void frmHuvud_VisibleChanged(object sender, EventArgs e)
		{
			MyProject.Forms.SplashScreenDrill.Visible = false;
			Monitor.Enter(this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad_Init);
			try
			{
				if (this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad_Init.State == 0)
				{
					this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad_Init.State = 2;
					this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad = false;
				}
				else if (this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad_Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad_Init.State = 1;
				Monitor.Exit(this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad_Init);
			}
			if (this.Visible)
			{
				this.txtNotes.Text = "None";
				if (!this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad)
				{
					this.STATIC_frmHuvud_VisibleChanged_20211C1265_Startad = true;
				}
				this.txtArea.Text = MySettingsProperty.Settings.Area;
				this.txtColNr.Text = MySettingsProperty.Settings.LastColumn;
				this.mAreaChange = false;
				this.lblBinder.Text = Conversions.ToString(checked((int)Math.Round(Conversions.ToDouble(this.mSignaler.PelTeoHg) / 10.0))) + " kg / m";
				switch (MySettingsProperty.Settings.ValdDriver)
				{
				case 1:
					this.lblDriver.Text = MySettingsProperty.Settings.Driver1;
					break;
				case 2:
					this.lblDriver.Text = MySettingsProperty.Settings.Driver2;
					break;
				case 3:
					this.lblDriver.Text = MySettingsProperty.Settings.Driver3;
					break;
				case 4:
					this.lblDriver.Text = MySettingsProperty.Settings.Driver4;
					break;
				default:
					this.lblDriver.Text = MySettingsProperty.Settings.Driver1;
					break;
				}
				this.ProdIdag();
				if (MySettingsProperty.Settings.Novatron & !this.SerieNovatron.IsOpen)
				{
					this.SerieNovatron.PortName = MySettingsProperty.Settings.NovatronCom;
					this.SerieNovatron.BaudRate = 9600;
					this.SerieNovatron.DataBits = 8;
					this.SerieNovatron.StopBits = StopBits.One;
					this.SerieNovatron.RtsEnable = true;
					this.SerieNovatron.DtrEnable = true;
					this.SerieNovatron.Parity = Parity.None;
					this.SerieNovatron.DiscardNull = true;
					this.SerieNovatron.NewLine = "\r\n";
					this.SerieNovatron.Open();
					this.SerieNovatron.DataReceived += this.TeckenAnläntNova;
				}
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00042944 File Offset: 0x00040D44
		private void TeckenAnläntNova(object source, SerialDataReceivedEventArgs e)
		{
			string value = "\r\n";
			string rValue;
			try
			{
				rValue = this.SerieNovatron.ReadTo(value);
			}
			catch (Exception ex)
			{
				Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				return;
			}
			this.ThreadProcSafe(rValue);
			this.FixaMess(this.NovatronMess);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000429A8 File Offset: 0x00040DA8
		private void ThreadProcSafe(string txt)
		{
			frmTestDrill.SetTextCallback d = new frmTestDrill.SetTextCallback(this.SetText);
			this.Invoke(d, new object[]
			{
				txt + ""
			});
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000429E4 File Offset: 0x00040DE4
		private void SetText(string text)
		{
			this.NovatronMess = text;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000429F0 File Offset: 0x00040DF0
		private void FixaMess(string txt)
		{
			string[] Meddelande = new string[1];
			string a = "";
			int pek = 0;
			int num = 1;
			int num2 = Strings.Len(txt);
			checked
			{
				for (int i = num; i <= num2; i++)
				{
					if (Operators.CompareString(Strings.Mid(txt, i, 1), ",", false) == 0 | i == Strings.Len(txt))
					{
						if (i == Strings.Len(txt))
						{
							a += Strings.Mid(txt, i, 1);
						}
						if (pek == 0)
						{
							Meddelande[0] = a;
						}
						else
						{
							Meddelande = (string[])Utils.CopyArray((Array)Meddelande, new string[pek + 1]);
							Meddelande[pek] = a;
						}
						pek++;
						a = "";
					}
					else
					{
						a += Strings.Mid(txt, i, 1);
					}
				}
				if (pek == 7 && Operators.CompareString(Meddelande[0], "GPS", false) == 0)
				{
					this.NovatronPelNr = Meddelande[1];
					this.NovatronX = Meddelande[2];
					this.NovatronY = Meddelande[3];
					this.NovatronZ = Meddelande[4];
					this.NovatronV = Meddelande[5];
					this.NovatronTid = Meddelande[6];
					string K = ",";
					string svar = string.Concat(new string[]
					{
						"DRILL",
						K,
						this.NovatronPelNr,
						K,
						this.Tid(),
						"\r\n"
					});
					this.SerieNovatron.Write(svar);
					this.NovatronStartSvar = false;
					this.NovatronSlutSvar = false;
					this.txtColNr.Text = this.NovatronPelNr;
				}
				if (pek == 4)
				{
					this.NovatronStartSvar = true;
				}
				if (pek == 5)
				{
					this.NovatronSlutSvar = true;
				}
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00042B80 File Offset: 0x00040F80
		private string Tid()
		{
			string h = Strings.Format(DateAndTime.Now.Hour, "00");
			string i = Strings.Format(DateAndTime.Now.Minute, "00");
			string s = Strings.Format(DateAndTime.Now.Second, "00");
			return string.Concat(new string[]
			{
				h,
				":",
				i,
				":",
				s
			});
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00042C1C File Offset: 0x0004101C
		private void tmrInSignaler_Tick(object sender, EventArgs e)
		{
			if (this.TestForm.Visible && decimal.Compare(this.TestForm.NumericUpDown1.Value, 0m) == 0)
			{
				this.TestForm.NumericUpDown1.Value = 2000m;
				this.TestForm.NumericUpDown6.Value = 1500m;
				this.TestForm.NumericUpDown10.Value = 1.7m;
			}
			string UrklipptSträng = "";
			bool ÄrDetTextiClipBordet = false;
			bool ÄrTextenLångNog = false;
			if (this.iData.GetDataPresent(DataFormats.Text))
			{
				ÄrDetTextiClipBordet = true;
				UrklipptSträng = Conversions.ToString(this.iData.GetData(DataFormats.Text));
				if (Strings.Len(UrklipptSträng) > 14)
				{
					ÄrTextenLångNog = true;
				}
			}
			checked
			{
				if (ÄrDetTextiClipBordet && ÄrTextenLångNog)
				{
					string PelarNr = "";
					if (Operators.CompareString(Strings.Mid(UrklipptSträng, 1, 14), "JUNTTAN10:PCX;", false) == 0)
					{
						string MeddelandeNr = "";
						if (Strings.Len(UrklipptSträng) > 15)
						{
							MeddelandeNr = Strings.Mid(UrklipptSträng, 15, 2);
						}
						if (Operators.CompareString(MeddelandeNr, "00", false) == 0)
						{
							this.Show();
						}
						if (Operators.CompareString(MeddelandeNr, "01", false) == 0)
						{
							int[] Pos = new int[5];
							int StartPos = 17;
							if (Strings.Len(UrklipptSträng) > StartPos)
							{
								int num = StartPos;
								int num2 = Strings.Len(UrklipptSträng);
								bool Kontroll = false;
								for (int i = num; i <= num2; i++)
								{
									if (Operators.CompareString(Strings.Mid(UrklipptSträng, i, 1), ",", false) == 0)
									{
										int j = 0;
										Pos[j] = i;
										j++;
										if (j == 4)
										{
											Kontroll = true;
										}
									}
								}
								if (Kontroll)
								{
									int[] StPos = new int[6];
									int[] LenPos = new int[6];
									StPos[0] = Pos[0] + 1;
									LenPos[0] = Pos[1] - 1 - Pos[0];
									StPos[1] = Pos[1] + 1;
									LenPos[1] = Pos[2] - 1 - Pos[1];
									StPos[2] = Pos[2] + 1;
									LenPos[2] = Pos[3] - 1 - Pos[2];
									StPos[3] = Pos[3] + 1;
									LenPos[3] = Pos[4] - 1 - Pos[3];
									StPos[4] = Pos[4] + 1;
									LenPos[4] = Strings.Len(UrklipptSträng) - Pos[4];
									if (Pos[1] > Pos[0] + 1)
									{
										PelarNr = Strings.Mid(UrklipptSträng, StPos[0], LenPos[0]);
									}
									string dNorr = "0";
									string dÖst = "0";
									string dPich = "0";
									string dRoll = "0";
									if (Pos[2] > Pos[1] + 1)
									{
										dNorr = Strings.Mid(UrklipptSträng, StPos[1], LenPos[1]);
									}
									if (Pos[3] > Pos[2] + 1)
									{
										dÖst = Strings.Mid(UrklipptSträng, StPos[2], LenPos[2]);
									}
									if (Pos[4] > Pos[3] + 1)
									{
										dPich = Strings.Mid(UrklipptSträng, StPos[3], LenPos[3]);
									}
									if (Strings.Len(UrklipptSträng) > Pos[4] + 1)
									{
										dRoll = Strings.Mid(UrklipptSträng, StPos[4], LenPos[4]);
									}
									float DeltaNorr;
									float DeltaÖst;
									float DeltaPich;
									float DeltaRoll;
									try
									{
										DeltaNorr = Conversions.ToSingle(dNorr);
										DeltaÖst = Conversions.ToSingle(dÖst);
										DeltaPich = Conversions.ToSingle(dPich);
										DeltaRoll = Conversions.ToSingle(dRoll);
									}
									catch (Exception ex)
									{
										DeltaNorr = 0f;
										DeltaÖst = 0f;
										DeltaPich = 0f;
										DeltaRoll = 0f;
									}
									this.STATIC_tmrInSignaler_Tick_20211C1265_RäknaGånger++;
									this.lblClip.Text = string.Concat(new string[]
									{
										PelarNr,
										" ",
										Conversions.ToString(DeltaNorr),
										" ",
										Conversions.ToString(DeltaÖst),
										" ",
										Conversions.ToString(DeltaPich),
										" ",
										Conversions.ToString(DeltaRoll),
										" ",
										Conversions.ToString(this.STATIC_tmrInSignaler_Tick_20211C1265_RäknaGånger)
									});
									this.txtColNr.Text = PelarNr;
									Monitor.Enter(this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt_Init);
									try
									{
										if (this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt_Init.State == 0)
										{
											this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt_Init.State = 2;
											this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt = "Tom";
										}
										else if (this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt_Init.State == 2)
										{
											throw new IncompleteInitialization();
										}
									}
									finally
									{
										this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt_Init.State = 1;
										Monitor.Exit(this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt_Init);
									}
									if (this.DjupUppgift && Operators.CompareString(this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt, PelarNr, false) != 0)
									{
										int num3 = 0;
										int num4 = Information.UBound(this.VektNr, 1);
										for (int a = num3; a <= num4; a++)
										{
											if (this.VektNr[a] == Conversions.ToInteger(PelarNr))
											{
												this.VektAktIndex = a;
												this.AktDeltaX = DeltaNorr;
												this.AktdeltaY = DeltaÖst;
												this.AktDeltaPich = DeltaPich;
												this.AktdeltaRoll = DeltaRoll;
											}
										}
										this.STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt = PelarNr;
										this.Label14.Visible = true;
										this.Label15.Visible = true;
										this.txtToDepth.Visible = true;
										this.txtTeoLängd.Visible = true;
										this.txtToDepth.Text = Strings.Format(this.VektDjup[this.VektAktIndex], "0.00");
										this.txtTeoLängd.Text = Conversions.ToString(unchecked(MySettingsProperty.Settings.HeightGround - this.VektDjup[this.VektAktIndex]));
									}
								}
							}
						}
						Clipboard.SetDataObject("Empty");
					}
				}
				if (this.TestForm.Visible)
				{
					FestoCom festoCom = this.mSignaler;
					festoCom.MätViktAhg = Convert.ToInt32(decimal.Multiply(this.TestForm.NumericUpDown1.Value, 10m));
					this.TankA.tryck = Convert.ToSingle(this.TestForm.NumericUpDown2.Value);
					this.TankA.tryck = Convert.ToSingle(this.TestForm.NumericUpDown3.Value);
					this.TankA.BinderInValve(this.TestForm.CheckBox2.Checked, this.TestForm.CheckBox1.Checked);
					this.TankA.MaterialUtValve(this.TestForm.CheckBox5.Checked, this.TestForm.CheckBox6.Checked);
					this.TankA.MaterialUtValv(this.TestForm.CheckBox3.Checked, this.TestForm.CheckBox4.Checked);
					this.TankA.AvluftValve(this.TestForm.CheckBox7.Checked, this.TestForm.CheckBox8.Checked);
					festoCom.MätViktBhg = Convert.ToInt32(decimal.Multiply(this.TestForm.NumericUpDown6.Value, 10m));
					this.TankB.tryck = Convert.ToSingle(this.TestForm.NumericUpDown5.Value);
					this.TankB.CellFart = Convert.ToSingle(this.TestForm.NumericUpDown4.Value);
					this.TankB.BinderInValve(this.TestForm.CheckBox15.Checked, this.TestForm.CheckBox16.Checked);
					this.TankB.MaterialUtValve(this.TestForm.CheckBox11.Checked, this.TestForm.CheckBox12.Checked);
					this.TankB.MaterialUtValv(this.TestForm.CheckBox14.Checked, this.TestForm.CheckBox13.Checked);
					this.TankB.AvluftValve(this.TestForm.CheckBox9.Checked, this.TestForm.CheckBox10.Checked);
					this.PressureKomp(Convert.ToSingle(this.TestForm.NumericUpDown7.Value));
					this.PressureRör(Convert.ToSingle(this.TestForm.NumericUpDown8.Value));
					this.PressureSvivel(Convert.ToSingle(this.TestForm.NumericUpDown9.Value));
					festoCom.MätDjup = Conversions.ToString(Convert.ToInt32(decimal.Multiply(this.TestForm.NumericUpDown10.Value, 1000m)));
					this.Röret.JordBotten = Convert.ToSingle(this.TestForm.NumericUpDown11.Value);
					this.Röret.Rotation = Convert.ToInt32(this.TestForm.NumericUpDown12.Value);
					this.Röret.BorrLängd = Convert.ToSingle(this.TestForm.NumericUpDown13.Value);
				}
				if (Strings.InStr(MyProject.Forms.TestarKom.TextIPCver.Text, "FESTO", CompareMethod.Binary) == 0)
				{
					this.lblNoCom.Visible = true;
				}
				else
				{
					this.lblNoCom.Visible = false;
				}
				if (this.mSignaler.ComÄrUppDat | this.TestForm.Visible)
				{
					bool[] boolStatusBitar = new bool[16];
					int intStatusOrd = (int)Conversions.ToShort(this.mSignaler.MätLuftVstatus);
					if (intStatusOrd < 0)
					{
						boolStatusBitar[15] = true;
						intStatusOrd += 32768;
					}
					else
					{
						boolStatusBitar[15] = false;
					}
					int intTvåPotens = 16384;
					int k = 14;
					do
					{
						if (k < 14)
						{
							intTvåPotens = (int)Math.Round((double)intTvåPotens / 2.0);
						}
						if (intStatusOrd >= intTvåPotens)
						{
							boolStatusBitar[k] = true;
							intStatusOrd -= intTvåPotens;
						}
						else
						{
							boolStatusBitar[k] = false;
						}
						k += -1;
					}
					while (k >= 0);
					bool[] boolStatusBitarF = new bool[16];
					int intStatusOrdF = (int)Conversions.ToShort(this.mSignaler.MätStatusBitar);
					if (intStatusOrdF < 0)
					{
						boolStatusBitarF[15] = true;
						intStatusOrdF += 32768;
					}
					else
					{
						boolStatusBitarF[15] = false;
					}
					int intTvåPotensF = 16384;
					k = 14;
					do
					{
						if (k < 14)
						{
							intTvåPotensF = (int)Math.Round((double)intTvåPotensF / 2.0);
						}
						if (intStatusOrdF >= intTvåPotensF)
						{
							boolStatusBitarF[k] = true;
							intStatusOrdF -= intTvåPotensF;
						}
						else
						{
							boolStatusBitarF[k] = false;
						}
						k += -1;
					}
					while (k >= 0);
					if (this.tmrPelare.Enabled)
					{
						if (boolStatusBitarF[9])
						{
							this.Pelare.ViktAUt = true;
						}
						else
						{
							this.Pelare.ViktAUt = false;
						}
						if (boolStatusBitarF[10])
						{
							this.Pelare.ViktBUt = true;
						}
						else
						{
							this.Pelare.ViktBUt = false;
						}
						if (this.Pelare.ViktAUt & !this.Pelare.ViktBUt)
						{
							this.lblInfoFst.Text = " Tank A Active ";
						}
						if (!this.Pelare.ViktAUt & this.Pelare.ViktBUt)
						{
							this.lblInfoFst.Text = " Tank B Active ";
						}
						if (this.Pelare.ViktAUt & this.Pelare.ViktBUt)
						{
							this.lblInfoFst.Text = " Tank A + B Active ";
						}
						if (!this.Pelare.ViktAUt & !this.Pelare.ViktBUt)
						{
							this.lblInfoFst.Text = " No Tank Active ";
						}
						if (!boolStatusBitarF[13])
						{
							this.STATIC_tmrInSignaler_Tick_20211C1265_AvslutRäkn++;
							if (this.STATIC_tmrInSignaler_Tick_20211C1265_AvslutRäkn > 6)
							{
								this.StoppPelare();
								this.lblInfoFst.Text = " Stoped Col from IPC ";
							}
						}
						else
						{
							this.STATIC_tmrInSignaler_Tick_20211C1265_AvslutRäkn = 0;
						}
					}
					else
					{
						this.STATIC_tmrInSignaler_Tick_20211C1265_AvslutRäkn = 0;
						if (Strings.InStr(this.lblInfoFst.Text, "Active", CompareMethod.Binary) > 0)
						{
							this.lblInfoFst.Text = "";
						}
					}
					if (boolStatusBitarF[15])
					{
						this.lblInfoFst.Text = "Error in fst call to Rolle";
					}
					else if (Strings.InStr(this.lblInfoFst.Text, "Error", CompareMethod.Binary) > 0)
					{
						this.lblInfoFst.Text = "";
					}
					bool BlåsÖ;
					bool BlåsS;
					if (boolStatusBitarF[2])
					{
						BlåsÖ = true;
						BlåsS = false;
					}
					else
					{
						BlåsÖ = false;
						BlåsS = true;
					}
					this.VBlås.Lägen(BlåsÖ, BlåsS);
					FestoCom festoCom2 = this.mSignaler;
					this.TankA.TankVikt = (float)((int)Math.Round((double)festoCom2.MätViktAhg / 10.0));
					this.TankA.tryck = (float)((double)Conversions.ToInteger(festoCom2.MätTtankA) / 1000.0);
					this.TankA.CellFart = (float)Conversions.ToInteger(festoCom2.MätVarvCellA);
					this.TankA.Temp = (float)((double)Conversions.ToInteger(festoCom2.MätTempLuftA) / 100.0);
					this.TankA.BinderInValve(boolStatusBitar[1], boolStatusBitar[0]);
					this.TankA.MaterialUtValve(boolStatusBitar[13], boolStatusBitar[12]);
					this.TankA.MaterialUtValv(boolStatusBitar[5], boolStatusBitar[4]);
					this.TankA.AvluftValve(boolStatusBitar[9], boolStatusBitar[8]);
					this.TankB.TankVikt = (float)((int)Math.Round((double)festoCom2.MätViktBhg / 10.0));
					this.TankB.tryck = (float)((double)Conversions.ToInteger(festoCom2.MätTtankB) / 1000.0);
					this.TankB.Temp = (float)((double)Conversions.ToInteger(festoCom2.MätTempLuftB) / 100.0);
					this.TankB.CellFart = (float)Conversions.ToInteger(festoCom2.MätVarvCellB);
					this.TankB.BinderInValve(boolStatusBitar[3], boolStatusBitar[2]);
					this.TankB.MaterialUtValve(boolStatusBitar[15], boolStatusBitar[14]);
					this.TankB.MaterialUtValv(boolStatusBitar[7], boolStatusBitar[6]);
					this.TankB.AvluftValve(boolStatusBitar[11], boolStatusBitar[10]);
					if (Operators.CompareString(festoCom2.MätInstaller, "1337", false) == 0 & Operators.CompareString(this.Pelare.Installer, "10", false) != 0)
					{
						this.Pelare.Installer = "10";
					}
					if (Operators.CompareString(festoCom2.MätInstaller, "1472", false) == 0 & Operators.CompareString(this.Pelare.Installer, "13", false) != 0)
					{
						this.Pelare.Installer = "13";
					}
					if (Conversions.ToInteger(this.Pelare.Installer) != MySettingsProperty.Settings.Installer)
					{
						MySettingsProperty.Settings.Installer = Conversions.ToInteger(this.Pelare.Installer);
						MySettingsProperty.Settings.Save();
					}
					this.PressureKomp(Convert.ToSingle(this.TestForm.NumericUpDown7.Value));
					this.PressureRör((float)((double)Conversions.ToInteger(festoCom2.MätTslang) / 1000.0));
					this.PressureSvivel((float)((double)Conversions.ToInteger(festoCom2.MätTsvivel) / 1000.0));
					this.Fuktighet((float)((double)Conversions.ToInteger(festoCom2.MätLuftFukt) / 100.0));
					this.TempKomp((float)((double)Conversions.ToInteger(festoCom2.MätTempKompr) / 100.0));
					this.Röret.Djupet = Conversions.ToSingle(festoCom2.MätDjup) / 1000f;
					this.Röret.Rotation = Conversions.ToInteger(festoCom2.MätVarvBorr);
					this.txtDjupHåkan.Text = Strings.Format((double)Conversions.ToInteger(festoCom2.MätDjup) / 1000.0, "0.00");
					this.Invalidate();
				}
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00043B4C File Offset: 0x00041F4C
		private void tmrPelare_Tick(object sender, EventArgs e)
		{
			this.Pelare.AdderaSekund();
			if (Conversions.ToSingle(this.mSignaler.MätDjup) <= Conversions.ToSingle(this.mSignaler.PelStoppDjup))
			{
				this.PelarenNormAvslut = true;
				this.StoppPelare();
			}
			if (this.TestForm.Visible)
			{
				this.TestForm.NumericUpDown10.Value = new decimal(Convert.ToDouble(this.TestForm.NumericUpDown10.Value) - 0.05);
				this.TestForm.NumericUpDown1.Value = decimal.Subtract(this.TestForm.NumericUpDown1.Value, 1m);
				this.TestForm.NumericUpDown6.Value = decimal.Subtract(this.TestForm.NumericUpDown6.Value, 1m);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00043C2C File Offset: 0x0004202C
		private void frmTestDrill_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 112)
			{
				this.sättPCx();
			}
			if (e.KeyValue == 113)
			{
				this.Nolla();
			}
			if (e.KeyValue == 114)
			{
				this.StartPelare();
			}
			if (e.KeyValue == 115)
			{
				this.StoppPelare();
			}
			if (e.KeyValue == 118)
			{
				this.VäxlaTillSignal();
			}
			if (e.KeyValue == 119)
			{
				this.TankVäxla();
			}
			if (e.KeyValue == 122)
			{
				if (!this.TestForm.Visible)
				{
					this.TestForm.Enabled = true;
					this.TestForm.Visible = true;
				}
				else
				{
					this.TestForm.Visible = false;
					this.TestForm.Enabled = false;
				}
			}
			if (e.KeyValue == 120)
			{
				float Djup = (float)(Conversions.ToDouble(this.mSignaler.MätDjup) / 1000.0);
				string strDjup = Strings.Format(Djup, "0.000");
				string DjupSträng = "JUNTTAN10:KCD;96," + strDjup;
				Clipboard.SetDataObject(DjupSträng);
			}
			if (e.KeyValue == 121)
			{
				this.Avsluta();
			}
			if (e.KeyValue == 123)
			{
				if (!this.STATIC_frmTestDrill_KeyDown_20211C1275_PcxFocus)
				{
					MyProject.Forms.TestarKom.WindowState = FormWindowState.Minimized;
					this.WindowState = FormWindowState.Minimized;
					Clipboard.SetDataObject("JUNTTAN10:KCD;99");
					this.STATIC_frmTestDrill_KeyDown_20211C1275_PcxFocus = true;
					return;
				}
				if (this.STATIC_frmTestDrill_KeyDown_20211C1275_PcxFocus)
				{
					this.WindowState = FormWindowState.Maximized;
					Clipboard.SetDataObject("JUNTTAN10:KCD;00");
					this.Show();
				}
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00043D98 File Offset: 0x00042198
		private void PictureBox1_Paint(object sender, PaintEventArgs e)
		{
			this.TankA.RitaOm();
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00043DA8 File Offset: 0x000421A8
		private void PicBorr_Paint(object sender, PaintEventArgs e)
		{
			this.Röret.Rita();
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00043DB8 File Offset: 0x000421B8
		private void PictureBox2_Paint(object sender, PaintEventArgs e)
		{
			this.TankB.RitaOm();
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00043DC8 File Offset: 0x000421C8
		protected override void OnPaint(PaintEventArgs e)
		{
			this.Röret.Rita();
			this.TankA.RitaOm();
			this.TankB.RitaOm();
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00043DEC File Offset: 0x000421EC
		private void txtArea_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.txtArea.Text, MySettingsProperty.Settings.Area, false) != 0)
			{
				this.mAreaChange = true;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00043E14 File Offset: 0x00042214
		private void txtColNr_TextChanged(object sender, EventArgs e)
		{
			MySettingsProperty.Settings.LastColumn = this.txtColNr.Text;
			if (!MySettingsProperty.Settings.Novatron)
			{
				return;
			}
			Monitor.Enter(this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt_Init);
			try
			{
				if (this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt_Init.State == 0)
				{
					this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt_Init.State = 2;
					this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt = "Tom";
				}
				else if (this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt_Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt_Init.State = 1;
				Monitor.Exit(this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt_Init);
			}
			string Nr = this.txtColNr.Text;
			if (this.DjupUppgift && (Operators.CompareString(this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt, Nr, false) != 0 & Strings.Len(Nr) > 0))
			{
				string NRtxt = "";
				int num = 1;
				int num2 = Strings.Len(this.txtColNr.Text);
				checked
				{
					for (int i = num; i <= num2; i++)
					{
						if (Strings.Asc(Strings.Mid(Nr, i, 1)) > 47 & Strings.Asc(Strings.Mid(Nr, i, 1)) < 58)
						{
							NRtxt += Strings.Mid(Nr, i, 1);
						}
					}
					if (Operators.CompareString(NRtxt, "", false) == 0)
					{
						return;
					}
					int PelarNr = Conversions.ToInteger(NRtxt);
					int num3 = 0;
					int num4 = Information.UBound(this.VektNr, 1);
					for (int a = num3; a <= num4; a++)
					{
						if (this.VektNr[a] == PelarNr)
						{
							this.VektAktIndex = a;
						}
					}
					this.STATIC_txtColNr_TextChanged_20211C1265_Sistasökt = Conversions.ToString(PelarNr);
					this.Label14.Visible = true;
					this.Label15.Visible = true;
					this.txtToDepth.Visible = true;
					this.txtTeoLängd.Visible = true;
					this.txtToDepth.Text = Strings.Format(this.VektDjup[this.VektAktIndex], "0.00");
				}
				this.txtTeoLängd.Text = Conversions.ToString(MySettingsProperty.Settings.HeightGround - this.VektDjup[this.VektAktIndex]);
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00044018 File Offset: 0x00042418
		private void txtNotes_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x040001B5 RID: 437
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040001B6 RID: 438
		[AccessedThroughProperty("txtSekunder")]
		private TextBox _txtSekunder;

		// Token: 0x040001B7 RID: 439
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040001B8 RID: 440
		[AccessedThroughProperty("txtNotes")]
		private TextBox _txtNotes;

		// Token: 0x040001B9 RID: 441
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040001BA RID: 442
		[AccessedThroughProperty("txtArea")]
		private TextBox _txtArea;

		// Token: 0x040001BB RID: 443
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040001BC RID: 444
		[AccessedThroughProperty("txtTotUt")]
		private TextBox _txtTotUt;

		// Token: 0x040001BD RID: 445
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040001BE RID: 446
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040001BF RID: 447
		[AccessedThroughProperty("txtStoppBvikt")]
		private TextBox _txtStoppBvikt;

		// Token: 0x040001C0 RID: 448
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040001C1 RID: 449
		[AccessedThroughProperty("txtStoppAvikt")]
		private TextBox _txtStoppAvikt;

		// Token: 0x040001C2 RID: 450
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040001C3 RID: 451
		[AccessedThroughProperty("txtStartBvikt")]
		private TextBox _txtStartBvikt;

		// Token: 0x040001C4 RID: 452
		[AccessedThroughProperty("lblStartAVikt")]
		private Label _lblStartAVikt;

		// Token: 0x040001C5 RID: 453
		[AccessedThroughProperty("txtStartAvikt")]
		private TextBox _txtStartAvikt;

		// Token: 0x040001C6 RID: 454
		[AccessedThroughProperty("txtColNr")]
		private TextBox _txtColNr;

		// Token: 0x040001C7 RID: 455
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040001C8 RID: 456
		[AccessedThroughProperty("lblBinder")]
		private Label _lblBinder;

		// Token: 0x040001C9 RID: 457
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040001CA RID: 458
		[AccessedThroughProperty("KnappF3")]
		private Button _KnappF3;

		// Token: 0x040001CB RID: 459
		[AccessedThroughProperty("KnappF2")]
		private Button _KnappF2;

		// Token: 0x040001CC RID: 460
		[AccessedThroughProperty("lblDriver")]
		private Label _lblDriver;

		// Token: 0x040001CD RID: 461
		[AccessedThroughProperty("KnappF4")]
		private Button _KnappF4;

		// Token: 0x040001CE RID: 462
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040001CF RID: 463
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040001D0 RID: 464
		[AccessedThroughProperty("KnappF1")]
		private Button _KnappF1;

		// Token: 0x040001D1 RID: 465
		[AccessedThroughProperty("txtStign")]
		private TextBox _txtStign;

		// Token: 0x040001D2 RID: 466
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x040001D3 RID: 467
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040001D4 RID: 468
		[AccessedThroughProperty("txtBindOut")]
		private TextBox _txtBindOut;

		// Token: 0x040001D5 RID: 469
		[AccessedThroughProperty("lblClip")]
		private Label _lblClip;

		// Token: 0x040001D6 RID: 470
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x040001D7 RID: 471
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040001D8 RID: 472
		[AccessedThroughProperty("lblNoCom")]
		private Label _lblNoCom;

		// Token: 0x040001D9 RID: 473
		[AccessedThroughProperty("tmrInSignaler")]
		private System.Windows.Forms.Timer _tmrInSignaler;

		// Token: 0x040001DA RID: 474
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x040001DB RID: 475
		[AccessedThroughProperty("tmrPelare")]
		private System.Windows.Forms.Timer _tmrPelare;

		// Token: 0x040001DC RID: 476
		[AccessedThroughProperty("DataGrid1")]
		private DataGrid _DataGrid1;

		// Token: 0x040001DD RID: 477
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x040001DE RID: 478
		[AccessedThroughProperty("KnappF5")]
		private Button _KnappF5;

		// Token: 0x040001DF RID: 479
		[AccessedThroughProperty("lblDjup")]
		private Label _lblDjup;

		// Token: 0x040001E0 RID: 480
		[AccessedThroughProperty("lblTempKomp")]
		private Label _lblTempKomp;

		// Token: 0x040001E1 RID: 481
		[AccessedThroughProperty("lblFuktighet")]
		private Label _lblFuktighet;

		// Token: 0x040001E2 RID: 482
		[AccessedThroughProperty("lblTryckRör")]
		private Label _lblTryckRör;

		// Token: 0x040001E3 RID: 483
		[AccessedThroughProperty("PicUtA8")]
		private PictureBox _PicUtA8;

		// Token: 0x040001E4 RID: 484
		[AccessedThroughProperty("PicUtA7")]
		private PictureBox _PicUtA7;

		// Token: 0x040001E5 RID: 485
		[AccessedThroughProperty("PicUtA6")]
		private PictureBox _PicUtA6;

		// Token: 0x040001E6 RID: 486
		[AccessedThroughProperty("PicUtA5")]
		private PictureBox _PicUtA5;

		// Token: 0x040001E7 RID: 487
		[AccessedThroughProperty("PicBlåsUt1")]
		private PictureBox _PicBlåsUt1;

		// Token: 0x040001E8 RID: 488
		[AccessedThroughProperty("PicBlåsV")]
		private PictureBox _PicBlåsV;

		// Token: 0x040001E9 RID: 489
		[AccessedThroughProperty("PicInB1")]
		private PictureBox _PicInB1;

		// Token: 0x040001EA RID: 490
		[AccessedThroughProperty("KnappF10")]
		private Button _KnappF10;

		// Token: 0x040001EB RID: 491
		[AccessedThroughProperty("KnappF9")]
		private Button _KnappF9;

		// Token: 0x040001EC RID: 492
		[AccessedThroughProperty("KnappF8")]
		private Button _KnappF8;

		// Token: 0x040001ED RID: 493
		[AccessedThroughProperty("TimerCellmat")]
		private System.Windows.Forms.Timer _TimerCellmat;

		// Token: 0x040001EE RID: 494
		[AccessedThroughProperty("lblTeoUt")]
		private Label _lblTeoUt;

		// Token: 0x040001EF RID: 495
		[AccessedThroughProperty("KnappF7")]
		private Button _KnappF7;

		// Token: 0x040001F0 RID: 496
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x040001F1 RID: 497
		[AccessedThroughProperty("lblMättUt")]
		private Label _lblMättUt;

		// Token: 0x040001F2 RID: 498
		[AccessedThroughProperty("PicBlåsUt7")]
		private PictureBox _PicBlåsUt7;

		// Token: 0x040001F3 RID: 499
		[AccessedThroughProperty("PicUtB1")]
		private PictureBox _PicUtB1;

		// Token: 0x040001F4 RID: 500
		[AccessedThroughProperty("PicBlåsUt6")]
		private PictureBox _PicBlåsUt6;

		// Token: 0x040001F5 RID: 501
		[AccessedThroughProperty("PicBlåsUt5")]
		private PictureBox _PicBlåsUt5;

		// Token: 0x040001F6 RID: 502
		[AccessedThroughProperty("PicBlåsUt4")]
		private PictureBox _PicBlåsUt4;

		// Token: 0x040001F7 RID: 503
		[AccessedThroughProperty("PicBlåsUt3")]
		private PictureBox _PicBlåsUt3;

		// Token: 0x040001F8 RID: 504
		[AccessedThroughProperty("PicBlåsUt2")]
		private PictureBox _PicBlåsUt2;

		// Token: 0x040001F9 RID: 505
		[AccessedThroughProperty("PicUtA4")]
		private PictureBox _PicUtA4;

		// Token: 0x040001FA RID: 506
		[AccessedThroughProperty("PicUtA3")]
		private PictureBox _PicUtA3;

		// Token: 0x040001FB RID: 507
		[AccessedThroughProperty("PicUtA2")]
		private PictureBox _PicUtA2;

		// Token: 0x040001FC RID: 508
		[AccessedThroughProperty("PicUtA1")]
		private PictureBox _PicUtA1;

		// Token: 0x040001FD RID: 509
		[AccessedThroughProperty("PicCompUt")]
		private PictureBox _PicCompUt;

		// Token: 0x040001FE RID: 510
		[AccessedThroughProperty("PicInA1")]
		private PictureBox _PicInA1;

		// Token: 0x040001FF RID: 511
		[AccessedThroughProperty("PicBorr")]
		private PictureBox _PicBorr;

		// Token: 0x04000200 RID: 512
		[AccessedThroughProperty("PicMark")]
		private PictureBox _PicMark;

		// Token: 0x04000201 RID: 513
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x04000202 RID: 514
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000203 RID: 515
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000204 RID: 516
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		// Token: 0x04000205 RID: 517
		[AccessedThroughProperty("lblJunttan")]
		private Label _lblJunttan;

		// Token: 0x04000206 RID: 518
		[AccessedThroughProperty("Panel2")]
		private Panel _Panel2;

		// Token: 0x04000207 RID: 519
		[AccessedThroughProperty("KnappF6")]
		private Button _KnappF6;

		// Token: 0x04000208 RID: 520
		[AccessedThroughProperty("lblInfoFst")]
		private Label _lblInfoFst;

		// Token: 0x04000209 RID: 521
		[AccessedThroughProperty("txtToDepth")]
		private TextBox _txtToDepth;

		// Token: 0x0400020A RID: 522
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x0400020B RID: 523
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x0400020C RID: 524
		[AccessedThroughProperty("txtTeoLängd")]
		private TextBox _txtTeoLängd;

		// Token: 0x0400020D RID: 525
		[AccessedThroughProperty("txtDjupHåkan")]
		private TextBox _txtDjupHåkan;

		// Token: 0x0400020E RID: 526
		[AccessedThroughProperty("SerieNovatron")]
		private SerialPort _SerieNovatron;

		// Token: 0x0400020F RID: 527
		private RitaTank TankA;

		// Token: 0x04000210 RID: 528
		private RitaTank TankB;

		// Token: 0x04000211 RID: 529
		private RitaRörH RörKompUt;

		// Token: 0x04000212 RID: 530
		private Ventil VBlås;

		// Token: 0x04000213 RID: 531
		private ToolTip VBlåsTip;

		// Token: 0x04000214 RID: 532
		private RitaRörV RörInA;

		// Token: 0x04000215 RID: 533
		private RitaRörV RörInB;

		// Token: 0x04000216 RID: 534
		private RitaKrökUV RörUtA1;

		// Token: 0x04000217 RID: 535
		private RitaRörV RörUtA2;

		// Token: 0x04000218 RID: 536
		private RitaKrökÖH RörUtA3;

		// Token: 0x04000219 RID: 537
		private RitaRörH RörUtA4;

		// Token: 0x0400021A RID: 538
		private RitaKrökÖV RörUtA5;

		// Token: 0x0400021B RID: 539
		private RitaRörV RörUtA6;

		// Token: 0x0400021C RID: 540
		private RitaKrökUV RörUtA7;

		// Token: 0x0400021D RID: 541
		private RitaRörH RörUtA8;

		// Token: 0x0400021E RID: 542
		private RitaRörH RörUtB1;

		// Token: 0x0400021F RID: 543
		private RitaRörH BlåsUt1;

		// Token: 0x04000220 RID: 544
		private RitaKrökÖV BlåsUt2;

		// Token: 0x04000221 RID: 545
		private RitaRörV BlåsUt3;

		// Token: 0x04000222 RID: 546
		private RitaKrökUH BlåsUt4;

		// Token: 0x04000223 RID: 547
		private RitaRörH BlåsUt5;

		// Token: 0x04000224 RID: 548
		private RitaKrökUV BlåsUt6;

		// Token: 0x04000225 RID: 549
		private RitaRörV BlåsUt7;

		// Token: 0x04000226 RID: 550
		public Borr Röret;

		// Token: 0x04000227 RID: 551
		private FestoCom mSignaler;

		// Token: 0x04000228 RID: 552
		private clsPelare Pelare;

		// Token: 0x04000229 RID: 553
		private bool PelarenNormAvslut;

		// Token: 0x0400022A RID: 554
		public object ClipData;

		// Token: 0x0400022B RID: 555
		public IDataObject iData;

		// Token: 0x0400022C RID: 556
		private frmTestaApp TestForm;

		// Token: 0x0400022D RID: 557
		private int[] VektNr;

		// Token: 0x0400022E RID: 558
		private double[] VektX;

		// Token: 0x0400022F RID: 559
		private double[] VektY;

		// Token: 0x04000230 RID: 560
		private float[] VektDjup;

		// Token: 0x04000231 RID: 561
		private bool DjupUppgift;

		// Token: 0x04000232 RID: 562
		private int VektAktIndex;

		// Token: 0x04000233 RID: 563
		private float AktDeltaX;

		// Token: 0x04000234 RID: 564
		private float AktdeltaY;

		// Token: 0x04000235 RID: 565
		private float AktDeltaPich;

		// Token: 0x04000236 RID: 566
		private float AktdeltaRoll;

		// Token: 0x04000237 RID: 567
		private string Port;

		// Token: 0x04000238 RID: 568
		private string NovatronMess;

		// Token: 0x04000239 RID: 569
		private string NovatronPelNr;

		// Token: 0x0400023A RID: 570
		private string NovatronX;

		// Token: 0x0400023B RID: 571
		private string NovatronY;

		// Token: 0x0400023C RID: 572
		private string NovatronZ;

		// Token: 0x0400023D RID: 573
		private string NovatronV;

		// Token: 0x0400023E RID: 574
		private string NovatronTid;

		// Token: 0x0400023F RID: 575
		private bool NovatronStartSvar;

		// Token: 0x04000240 RID: 576
		private bool NovatronSlutSvar;

		// Token: 0x04000241 RID: 577
		private bool mAreaChange;

		// Token: 0x04000242 RID: 578
		private string STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt;

		// Token: 0x04000243 RID: 579
		private string STATIC_txtColNr_TextChanged_20211C1265_Sistasökt;

		// Token: 0x04000244 RID: 580
		private bool STATIC_frmHuvud_VisibleChanged_20211C1265_Startad;

		// Token: 0x04000245 RID: 581
		private int STATIC_tmrInSignaler_Tick_20211C1265_RäknaGånger;

		// Token: 0x04000246 RID: 582
		private StaticLocalInitFlag STATIC_frmHuvud_VisibleChanged_20211C1265_Startad_Init;

		// Token: 0x04000247 RID: 583
		private bool STATIC_sättPCx_2001_Borr;

		// Token: 0x04000248 RID: 584
		private bool STATIC_ProdIdag_2001_boolGjort;

		// Token: 0x04000249 RID: 585
		private StaticLocalInitFlag STATIC_tmrInSignaler_Tick_20211C1265_Sistasökt_Init;

		// Token: 0x0400024A RID: 586
		private StaticLocalInitFlag STATIC_txtColNr_TextChanged_20211C1265_Sistasökt_Init;

		// Token: 0x0400024B RID: 587
		private bool STATIC_dataGrid1_CurCellChange_20211C1265_Första;

		// Token: 0x0400024C RID: 588
		private DataGridCell STATIC_dataGrid1_CurCellChange_20211C1265_Cellen;

		// Token: 0x0400024D RID: 589
		private string STATIC_dataGrid1_CurCellChange_20211C1265_CellVärde;

		// Token: 0x0400024E RID: 590
		private int STATIC_tmrInSignaler_Tick_20211C1265_AvslutRäkn;

		// Token: 0x0400024F RID: 591
		private bool STATIC_frmTestDrill_KeyDown_20211C1275_PcxFocus;

		// Token: 0x04000250 RID: 592
		private bool STATIC_dataGrid1_CurCellChange_20211C1265_Ändrat;

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x0600037A RID: 890
		public delegate void SetTextCallback(string text);
	}
}
