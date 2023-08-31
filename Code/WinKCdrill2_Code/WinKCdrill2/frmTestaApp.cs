using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x0200000E RID: 14
	public partial class frmTestaApp : Form
	{
		// Token: 0x06000223 RID: 547 RVA: 0x0002C858 File Offset: 0x0002AC58
		public frmTestaApp()
		{
			base.Load += this.frmTest_Load;
			base.KeyDown += this.frmTest_KeyDown;
			this.InitializeComponent();
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0002C8AC File Offset: 0x0002ACAC
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0002C8C0 File Offset: 0x0002ACC0
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

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000227 RID: 551 RVA: 0x0002C8CC File Offset: 0x0002ACCC
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0002C8E0 File Offset: 0x0002ACE0
		internal virtual NumericUpDown NumericUpDown1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown1 = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0002C8EC File Offset: 0x0002ACEC
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0002C900 File Offset: 0x0002AD00
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600022B RID: 555 RVA: 0x0002C90C File Offset: 0x0002AD0C
		// (set) Token: 0x0600022C RID: 556 RVA: 0x0002C920 File Offset: 0x0002AD20
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0002C92C File Offset: 0x0002AD2C
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0002C940 File Offset: 0x0002AD40
		internal virtual NumericUpDown NumericUpDown2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown2 = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600022F RID: 559 RVA: 0x0002C94C File Offset: 0x0002AD4C
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0002C960 File Offset: 0x0002AD60
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0002C96C File Offset: 0x0002AD6C
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0002C980 File Offset: 0x0002AD80
		internal virtual NumericUpDown NumericUpDown3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown3 = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000233 RID: 563 RVA: 0x0002C98C File Offset: 0x0002AD8C
		// (set) Token: 0x06000234 RID: 564 RVA: 0x0002C9A0 File Offset: 0x0002ADA0
		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0002C9AC File Offset: 0x0002ADAC
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0002C9C0 File Offset: 0x0002ADC0
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0002C9CC File Offset: 0x0002ADCC
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0002C9E0 File Offset: 0x0002ADE0
		internal virtual CheckBox CheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox2 = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0002C9EC File Offset: 0x0002ADEC
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0002CA00 File Offset: 0x0002AE00
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

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600023B RID: 571 RVA: 0x0002CA0C File Offset: 0x0002AE0C
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0002CA20 File Offset: 0x0002AE20
		internal virtual CheckBox CheckBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox3 = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0002CA2C File Offset: 0x0002AE2C
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0002CA40 File Offset: 0x0002AE40
		internal virtual CheckBox CheckBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox4 = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600023F RID: 575 RVA: 0x0002CA4C File Offset: 0x0002AE4C
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0002CA60 File Offset: 0x0002AE60
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000241 RID: 577 RVA: 0x0002CA6C File Offset: 0x0002AE6C
		// (set) Token: 0x06000242 RID: 578 RVA: 0x0002CA80 File Offset: 0x0002AE80
		internal virtual CheckBox CheckBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox5 = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0002CA8C File Offset: 0x0002AE8C
		// (set) Token: 0x06000244 RID: 580 RVA: 0x0002CAA0 File Offset: 0x0002AEA0
		internal virtual CheckBox CheckBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox6 = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0002CAAC File Offset: 0x0002AEAC
		// (set) Token: 0x06000246 RID: 582 RVA: 0x0002CAC0 File Offset: 0x0002AEC0
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0002CACC File Offset: 0x0002AECC
		// (set) Token: 0x06000248 RID: 584 RVA: 0x0002CAE0 File Offset: 0x0002AEE0
		internal virtual CheckBox CheckBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox7 = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0002CAEC File Offset: 0x0002AEEC
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0002CB00 File Offset: 0x0002AF00
		internal virtual CheckBox CheckBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox8 = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0002CB0C File Offset: 0x0002AF0C
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0002CB20 File Offset: 0x0002AF20
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Timer1 = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0002CB2C File Offset: 0x0002AF2C
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0002CB40 File Offset: 0x0002AF40
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0002CB4C File Offset: 0x0002AF4C
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0002CB60 File Offset: 0x0002AF60
		internal virtual GroupBox GroupBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox7 = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0002CB6C File Offset: 0x0002AF6C
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0002CB80 File Offset: 0x0002AF80
		internal virtual CheckBox CheckBox9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox9 = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0002CB8C File Offset: 0x0002AF8C
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0002CBA0 File Offset: 0x0002AFA0
		internal virtual CheckBox CheckBox10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox10 = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0002CBAC File Offset: 0x0002AFAC
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0002CBC0 File Offset: 0x0002AFC0
		internal virtual GroupBox GroupBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox8 = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0002CBCC File Offset: 0x0002AFCC
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0002CBE0 File Offset: 0x0002AFE0
		internal virtual CheckBox CheckBox11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox11 = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0002CBEC File Offset: 0x0002AFEC
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0002CC00 File Offset: 0x0002B000
		internal virtual CheckBox CheckBox12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox12 = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0002CC0C File Offset: 0x0002B00C
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0002CC20 File Offset: 0x0002B020
		internal virtual GroupBox GroupBox9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox9 = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0002CC2C File Offset: 0x0002B02C
		// (set) Token: 0x0600025E RID: 606 RVA: 0x0002CC40 File Offset: 0x0002B040
		internal virtual CheckBox CheckBox13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox13 = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0002CC4C File Offset: 0x0002B04C
		// (set) Token: 0x06000260 RID: 608 RVA: 0x0002CC60 File Offset: 0x0002B060
		internal virtual CheckBox CheckBox14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox14 = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0002CC6C File Offset: 0x0002B06C
		// (set) Token: 0x06000262 RID: 610 RVA: 0x0002CC80 File Offset: 0x0002B080
		internal virtual GroupBox GroupBox10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox10 = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0002CC8C File Offset: 0x0002B08C
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0002CCA0 File Offset: 0x0002B0A0
		internal virtual CheckBox CheckBox15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox15 = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0002CCAC File Offset: 0x0002B0AC
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0002CCC0 File Offset: 0x0002B0C0
		internal virtual CheckBox CheckBox16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox16 = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0002CCCC File Offset: 0x0002B0CC
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0002CCE0 File Offset: 0x0002B0E0
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

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000269 RID: 617 RVA: 0x0002CCEC File Offset: 0x0002B0EC
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0002CD00 File Offset: 0x0002B100
		internal virtual NumericUpDown NumericUpDown4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown4 = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0002CD0C File Offset: 0x0002B10C
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0002CD20 File Offset: 0x0002B120
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

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0002CD2C File Offset: 0x0002B12C
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0002CD40 File Offset: 0x0002B140
		internal virtual NumericUpDown NumericUpDown5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown5 = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0002CD4C File Offset: 0x0002B14C
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0002CD60 File Offset: 0x0002B160
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

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0002CD6C File Offset: 0x0002B16C
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0002CD80 File Offset: 0x0002B180
		internal virtual NumericUpDown NumericUpDown6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown6 = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0002CD8C File Offset: 0x0002B18C
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0002CDA0 File Offset: 0x0002B1A0
		internal virtual GroupBox GroupBox11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox11 = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000275 RID: 629 RVA: 0x0002CDAC File Offset: 0x0002B1AC
		// (set) Token: 0x06000276 RID: 630 RVA: 0x0002CDC0 File Offset: 0x0002B1C0
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

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0002CDCC File Offset: 0x0002B1CC
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0002CDE0 File Offset: 0x0002B1E0
		internal virtual NumericUpDown NumericUpDown7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown7 = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0002CDEC File Offset: 0x0002B1EC
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0002CE00 File Offset: 0x0002B200
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

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0002CE0C File Offset: 0x0002B20C
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0002CE20 File Offset: 0x0002B220
		internal virtual NumericUpDown NumericUpDown8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown8 = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0002CE2C File Offset: 0x0002B22C
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0002CE40 File Offset: 0x0002B240
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0002CE4C File Offset: 0x0002B24C
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0002CE60 File Offset: 0x0002B260
		internal virtual NumericUpDown NumericUpDown9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown9 = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0002CE6C File Offset: 0x0002B26C
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0002CE80 File Offset: 0x0002B280
		internal virtual GroupBox GroupBox12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox12 = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0002CE8C File Offset: 0x0002B28C
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0002CEA0 File Offset: 0x0002B2A0
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

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0002CEAC File Offset: 0x0002B2AC
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0002CEC0 File Offset: 0x0002B2C0
		internal virtual NumericUpDown NumericUpDown10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown10 = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0002CECC File Offset: 0x0002B2CC
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0002CEE0 File Offset: 0x0002B2E0
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

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0002CEEC File Offset: 0x0002B2EC
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0002CF00 File Offset: 0x0002B300
		internal virtual NumericUpDown NumericUpDown11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown11 = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0002CF0C File Offset: 0x0002B30C
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0002CF20 File Offset: 0x0002B320
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

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0002CF2C File Offset: 0x0002B32C
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0002CF40 File Offset: 0x0002B340
		internal virtual NumericUpDown NumericUpDown12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown12 = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0002CF4C File Offset: 0x0002B34C
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0002CF60 File Offset: 0x0002B360
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0002CF6C File Offset: 0x0002B36C
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0002CF80 File Offset: 0x0002B380
		internal virtual NumericUpDown NumericUpDown13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown13 = value;
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0002F52C File Offset: 0x0002D92C
		private void frmTest_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0002F530 File Offset: 0x0002D930
		private void frmTest_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 122)
			{
				if (!this.Visible)
				{
					this.Enabled = true;
					this.Visible = true;
				}
				else
				{
					this.Visible = false;
					this.Enabled = false;
				}
			}
		}

		// Token: 0x0400017D RID: 381
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x0400017E RID: 382
		[AccessedThroughProperty("NumericUpDown1")]
		private NumericUpDown _NumericUpDown1;

		// Token: 0x0400017F RID: 383
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000180 RID: 384
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000181 RID: 385
		[AccessedThroughProperty("NumericUpDown2")]
		private NumericUpDown _NumericUpDown2;

		// Token: 0x04000182 RID: 386
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000183 RID: 387
		[AccessedThroughProperty("NumericUpDown3")]
		private NumericUpDown _NumericUpDown3;

		// Token: 0x04000184 RID: 388
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x04000185 RID: 389
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x04000186 RID: 390
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		// Token: 0x04000187 RID: 391
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x04000188 RID: 392
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;

		// Token: 0x04000189 RID: 393
		[AccessedThroughProperty("CheckBox4")]
		private CheckBox _CheckBox4;

		// Token: 0x0400018A RID: 394
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x0400018B RID: 395
		[AccessedThroughProperty("CheckBox5")]
		private CheckBox _CheckBox5;

		// Token: 0x0400018C RID: 396
		[AccessedThroughProperty("CheckBox6")]
		private CheckBox _CheckBox6;

		// Token: 0x0400018D RID: 397
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x0400018E RID: 398
		[AccessedThroughProperty("CheckBox7")]
		private CheckBox _CheckBox7;

		// Token: 0x0400018F RID: 399
		[AccessedThroughProperty("CheckBox8")]
		private CheckBox _CheckBox8;

		// Token: 0x04000190 RID: 400
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000191 RID: 401
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x04000192 RID: 402
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x04000193 RID: 403
		[AccessedThroughProperty("CheckBox9")]
		private CheckBox _CheckBox9;

		// Token: 0x04000194 RID: 404
		[AccessedThroughProperty("CheckBox10")]
		private CheckBox _CheckBox10;

		// Token: 0x04000195 RID: 405
		[AccessedThroughProperty("GroupBox8")]
		private GroupBox _GroupBox8;

		// Token: 0x04000196 RID: 406
		[AccessedThroughProperty("CheckBox11")]
		private CheckBox _CheckBox11;

		// Token: 0x04000197 RID: 407
		[AccessedThroughProperty("CheckBox12")]
		private CheckBox _CheckBox12;

		// Token: 0x04000198 RID: 408
		[AccessedThroughProperty("GroupBox9")]
		private GroupBox _GroupBox9;

		// Token: 0x04000199 RID: 409
		[AccessedThroughProperty("CheckBox13")]
		private CheckBox _CheckBox13;

		// Token: 0x0400019A RID: 410
		[AccessedThroughProperty("CheckBox14")]
		private CheckBox _CheckBox14;

		// Token: 0x0400019B RID: 411
		[AccessedThroughProperty("GroupBox10")]
		private GroupBox _GroupBox10;

		// Token: 0x0400019C RID: 412
		[AccessedThroughProperty("CheckBox15")]
		private CheckBox _CheckBox15;

		// Token: 0x0400019D RID: 413
		[AccessedThroughProperty("CheckBox16")]
		private CheckBox _CheckBox16;

		// Token: 0x0400019E RID: 414
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400019F RID: 415
		[AccessedThroughProperty("NumericUpDown4")]
		private NumericUpDown _NumericUpDown4;

		// Token: 0x040001A0 RID: 416
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040001A1 RID: 417
		[AccessedThroughProperty("NumericUpDown5")]
		private NumericUpDown _NumericUpDown5;

		// Token: 0x040001A2 RID: 418
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040001A3 RID: 419
		[AccessedThroughProperty("NumericUpDown6")]
		private NumericUpDown _NumericUpDown6;

		// Token: 0x040001A4 RID: 420
		[AccessedThroughProperty("GroupBox11")]
		private GroupBox _GroupBox11;

		// Token: 0x040001A5 RID: 421
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040001A6 RID: 422
		[AccessedThroughProperty("NumericUpDown7")]
		private NumericUpDown _NumericUpDown7;

		// Token: 0x040001A7 RID: 423
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040001A8 RID: 424
		[AccessedThroughProperty("NumericUpDown8")]
		private NumericUpDown _NumericUpDown8;

		// Token: 0x040001A9 RID: 425
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x040001AA RID: 426
		[AccessedThroughProperty("NumericUpDown9")]
		private NumericUpDown _NumericUpDown9;

		// Token: 0x040001AB RID: 427
		[AccessedThroughProperty("GroupBox12")]
		private GroupBox _GroupBox12;

		// Token: 0x040001AC RID: 428
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040001AD RID: 429
		[AccessedThroughProperty("NumericUpDown10")]
		private NumericUpDown _NumericUpDown10;

		// Token: 0x040001AE RID: 430
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040001AF RID: 431
		[AccessedThroughProperty("NumericUpDown11")]
		private NumericUpDown _NumericUpDown11;

		// Token: 0x040001B0 RID: 432
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040001B1 RID: 433
		[AccessedThroughProperty("NumericUpDown12")]
		private NumericUpDown _NumericUpDown12;

		// Token: 0x040001B2 RID: 434
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040001B3 RID: 435
		[AccessedThroughProperty("NumericUpDown13")]
		private NumericUpDown _NumericUpDown13;
	}
}
