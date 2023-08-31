using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using winKCdrill2.My;

namespace winKCdrill2
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class TestarKom : Form
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0003A9DC File Offset: 0x00038DDC
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0003A9F0 File Offset: 0x00038DF0
		internal virtual System.Windows.Forms.Timer KntrlComPort
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KntrlComPort;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KntrlComPort_Tick);
				if (this._KntrlComPort != null)
				{
					this._KntrlComPort.Tick -= value2;
				}
				this._KntrlComPort = value;
				if (this._KntrlComPort != null)
				{
					this._KntrlComPort.Tick += value2;
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0003AA3C File Offset: 0x00038E3C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0003AA50 File Offset: 0x00038E50
		internal virtual GroupBox GroupBoxStatus
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBoxStatus;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBoxStatus = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000158 RID: 344 RVA: 0x0003AA5C File Offset: 0x00038E5C
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0003AA70 File Offset: 0x00038E70
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0003AA7C File Offset: 0x00038E7C
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0003AA90 File Offset: 0x00038E90
		internal virtual TextBox TextIPCver
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextIPCver;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextIPCver = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0003AA9C File Offset: 0x00038E9C
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0003AAB0 File Offset: 0x00038EB0
		internal virtual TextBox TextByteSek
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextByteSek;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextByteSek = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0003AABC File Offset: 0x00038EBC
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0003AAD0 File Offset: 0x00038ED0
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0003AADC File Offset: 0x00038EDC
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0003AAF0 File Offset: 0x00038EF0
		internal virtual TextBox TextUppdatesSek
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextUppdatesSek;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextUppdatesSek = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0003AAFC File Offset: 0x00038EFC
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0003AB10 File Offset: 0x00038F10
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0003AB1C File Offset: 0x00038F1C
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0003AB30 File Offset: 0x00038F30
		internal virtual TextBox TextComRestarts
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextComRestarts;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextComRestarts = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0003AB3C File Offset: 0x00038F3C
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0003AB50 File Offset: 0x00038F50
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0003AB5C File Offset: 0x00038F5C
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0003AB70 File Offset: 0x00038F70
		internal virtual TextBox TextMottagsFel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextMottagsFel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextMottagsFel = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0003AB7C File Offset: 0x00038F7C
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0003AB90 File Offset: 0x00038F90
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0003AB9C File Offset: 0x00038F9C
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0003ABB0 File Offset: 0x00038FB0
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0003ABBC File Offset: 0x00038FBC
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0003ABD0 File Offset: 0x00038FD0
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0003ABDC File Offset: 0x00038FDC
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0003ABF0 File Offset: 0x00038FF0
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0003ABFC File Offset: 0x00038FFC
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0003AC10 File Offset: 0x00039010
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0003AC1C File Offset: 0x0003901C
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0003AC30 File Offset: 0x00039030
		internal virtual GroupBox GroupMätVärden
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupMätVärden;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GroupMätVärden_DoubleClick);
				if (this._GroupMätVärden != null)
				{
					this._GroupMätVärden.DoubleClick -= value2;
				}
				this._GroupMätVärden = value;
				if (this._GroupMätVärden != null)
				{
					this._GroupMätVärden.DoubleClick += value2;
				}
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0003AC7C File Offset: 0x0003907C
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0003AC90 File Offset: 0x00039090
		internal virtual TextBox TextTankBTryck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankBTryck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankBTryck = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0003AC9C File Offset: 0x0003909C
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0003ACB0 File Offset: 0x000390B0
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0003ACBC File Offset: 0x000390BC
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0003ACD0 File Offset: 0x000390D0
		internal virtual TextBox TextTankATryck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankATryck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankATryck = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0003ACDC File Offset: 0x000390DC
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0003ACF0 File Offset: 0x000390F0
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0003ACFC File Offset: 0x000390FC
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0003AD10 File Offset: 0x00039110
		internal virtual TextBox TextSlangTryck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextSlangTryck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextSlangTryck = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0003AD1C File Offset: 0x0003911C
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0003AD30 File Offset: 0x00039130
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0003AD3C File Offset: 0x0003913C
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0003AD50 File Offset: 0x00039150
		internal virtual TextBox TextSvivelTryck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextSvivelTryck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextSvivelTryck = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0003AD5C File Offset: 0x0003915C
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0003AD70 File Offset: 0x00039170
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0003AD7C File Offset: 0x0003917C
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0003AD90 File Offset: 0x00039190
		internal virtual TextBox TextTankBerror
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankBerror;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankBerror = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0003AD9C File Offset: 0x0003919C
		// (set) Token: 0x06000189 RID: 393 RVA: 0x0003ADB0 File Offset: 0x000391B0
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0003ADBC File Offset: 0x000391BC
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0003ADD0 File Offset: 0x000391D0
		internal virtual TextBox TextTankBViktL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankBViktL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankBViktL = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0003ADDC File Offset: 0x000391DC
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0003ADF0 File Offset: 0x000391F0
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0003ADFC File Offset: 0x000391FC
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0003AE10 File Offset: 0x00039210
		internal virtual TextBox TextTankAError
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankAError;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankAError = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0003AE1C File Offset: 0x0003921C
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0003AE30 File Offset: 0x00039230
		internal virtual Label Label16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0003AE3C File Offset: 0x0003923C
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0003AE50 File Offset: 0x00039250
		internal virtual TextBox TextTankAViktL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankAViktL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankAViktL = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0003AE5C File Offset: 0x0003925C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x0003AE70 File Offset: 0x00039270
		internal virtual Label Label17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label17 = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0003AE7C File Offset: 0x0003927C
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0003AE90 File Offset: 0x00039290
		internal virtual TextBox TextBorrDjup
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBorrDjup;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBorrDjup = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0003AE9C File Offset: 0x0003929C
		// (set) Token: 0x06000199 RID: 409 RVA: 0x0003AEB0 File Offset: 0x000392B0
		internal virtual Label Label18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label18 = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600019A RID: 410 RVA: 0x0003AEBC File Offset: 0x000392BC
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0003AED0 File Offset: 0x000392D0
		internal virtual TextBox TextCellBSpeed
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextCellBSpeed;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextCellBSpeed = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0003AEDC File Offset: 0x000392DC
		// (set) Token: 0x0600019D RID: 413 RVA: 0x0003AEF0 File Offset: 0x000392F0
		internal virtual Label Label19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label19 = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600019E RID: 414 RVA: 0x0003AEFC File Offset: 0x000392FC
		// (set) Token: 0x0600019F RID: 415 RVA: 0x0003AF10 File Offset: 0x00039310
		internal virtual TextBox TextCellASpeed
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextCellASpeed;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextCellASpeed = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0003AF1C File Offset: 0x0003931C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0003AF30 File Offset: 0x00039330
		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0003AF3C File Offset: 0x0003933C
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x0003AF50 File Offset: 0x00039350
		internal virtual TextBox TextBorrSpeed
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBorrSpeed;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBorrSpeed = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0003AF5C File Offset: 0x0003935C
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x0003AF70 File Offset: 0x00039370
		internal virtual Label Label21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label21 = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0003AF7C File Offset: 0x0003937C
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0003AF90 File Offset: 0x00039390
		internal virtual TextBox TextTankBViktH
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankBViktH;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankBViktH = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0003AF9C File Offset: 0x0003939C
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0003AFB0 File Offset: 0x000393B0
		internal virtual Label Label22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label22 = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0003AFBC File Offset: 0x000393BC
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0003AFD0 File Offset: 0x000393D0
		internal virtual TextBox TextKomprTemp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextKomprTemp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextKomprTemp = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0003AFDC File Offset: 0x000393DC
		// (set) Token: 0x060001AD RID: 429 RVA: 0x0003AFF0 File Offset: 0x000393F0
		internal virtual Label Label23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label23 = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0003AFFC File Offset: 0x000393FC
		// (set) Token: 0x060001AF RID: 431 RVA: 0x0003B010 File Offset: 0x00039410
		internal virtual TextBox TextTankBTemp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankBTemp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankBTemp = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0003B01C File Offset: 0x0003941C
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0003B030 File Offset: 0x00039430
		internal virtual Label Label24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label24 = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0003B03C File Offset: 0x0003943C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0003B050 File Offset: 0x00039450
		internal virtual TextBox TextTankATemp
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankATemp;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankATemp = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0003B05C File Offset: 0x0003945C
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0003B070 File Offset: 0x00039470
		internal virtual Label Label25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label25 = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0003B07C File Offset: 0x0003947C
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0003B090 File Offset: 0x00039490
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0003B09C File Offset: 0x0003949C
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0003B0B0 File Offset: 0x000394B0
		internal virtual Label Label26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label26 = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0003B0BC File Offset: 0x000394BC
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0003B0D0 File Offset: 0x000394D0
		internal virtual Label Label27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label27 = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0003B0DC File Offset: 0x000394DC
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0003B0F0 File Offset: 0x000394F0
		internal virtual Label Label28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label28 = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0003B0FC File Offset: 0x000394FC
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0003B110 File Offset: 0x00039510
		internal virtual Label Label29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label29 = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0003B11C File Offset: 0x0003951C
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0003B130 File Offset: 0x00039530
		internal virtual TextBox TextStatusVärden
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextStatusVärden;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextStatusVärden = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0003B13C File Offset: 0x0003953C
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0003B150 File Offset: 0x00039550
		internal virtual Label Label30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label30 = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0003B15C File Offset: 0x0003955C
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0003B170 File Offset: 0x00039570
		internal virtual TextBox TextUtCellB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextUtCellB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextUtCellB = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0003B17C File Offset: 0x0003957C
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0003B190 File Offset: 0x00039590
		internal virtual Label Label31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label31 = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0003B19C File Offset: 0x0003959C
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0003B1B0 File Offset: 0x000395B0
		internal virtual TextBox TextUtCellA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextUtCellA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextUtCellA = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0003B1BC File Offset: 0x000395BC
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0003B1D0 File Offset: 0x000395D0
		internal virtual Label Label32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label32 = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0003B1DC File Offset: 0x000395DC
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0003B1F0 File Offset: 0x000395F0
		internal virtual TextBox TextUtRotation
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextUtRotation;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextUtRotation = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0003B1FC File Offset: 0x000395FC
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0003B210 File Offset: 0x00039610
		internal virtual Label Label33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label33 = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0003B21C File Offset: 0x0003961C
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0003B230 File Offset: 0x00039630
		internal virtual TextBox TextUtUppNer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextUtUppNer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextUtUppNer = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0003B23C File Offset: 0x0003963C
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0003B250 File Offset: 0x00039650
		internal virtual Label Label34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label34 = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0003B25C File Offset: 0x0003965C
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0003B270 File Offset: 0x00039670
		internal virtual TextBox TextINPotB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextINPotB;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextINPotB = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0003B27C File Offset: 0x0003967C
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0003B290 File Offset: 0x00039690
		internal virtual Label Label35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label35 = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0003B29C File Offset: 0x0003969C
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0003B2B0 File Offset: 0x000396B0
		internal virtual TextBox TextInPotA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextInPotA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextInPotA = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0003B2BC File Offset: 0x000396BC
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0003B2D0 File Offset: 0x000396D0
		internal virtual Label Label36
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label36;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label36 = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0003B2DC File Offset: 0x000396DC
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0003B2F0 File Offset: 0x000396F0
		internal virtual TextBox TextLuftFukt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextLuftFukt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextLuftFukt = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0003B2FC File Offset: 0x000396FC
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0003B310 File Offset: 0x00039710
		internal virtual Label Label37
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label37;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label37 = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0003B31C File Offset: 0x0003971C
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0003B330 File Offset: 0x00039730
		internal virtual TextBox TextStatusAirValves
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextStatusAirValves;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextStatusAirValves = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0003B33C File Offset: 0x0003973C
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0003B350 File Offset: 0x00039750
		internal virtual Label Label38
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label38;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label38 = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0003B35C File Offset: 0x0003975C
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x0003B370 File Offset: 0x00039770
		internal virtual TextBox TextCarrier
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextCarrier;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextCarrier = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0003B37C File Offset: 0x0003977C
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0003B390 File Offset: 0x00039790
		internal virtual Label Label39
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label39;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label39 = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0003B39C File Offset: 0x0003979C
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x0003B3B0 File Offset: 0x000397B0
		internal virtual TextBox TextInstaller
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextInstaller;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextInstaller = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0003B3BC File Offset: 0x000397BC
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0003B3D0 File Offset: 0x000397D0
		internal virtual Label Label40
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label40;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label40 = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0003B3DC File Offset: 0x000397DC
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0003B3F0 File Offset: 0x000397F0
		internal virtual TextBox TextTankAViktH
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankAViktH;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankAViktH = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0003B3FC File Offset: 0x000397FC
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0003B410 File Offset: 0x00039810
		internal virtual Label Label41
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label41;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label41 = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x0003B41C File Offset: 0x0003981C
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0003B430 File Offset: 0x00039830
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				if (this._Button1 != null)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				if (this._Button1 != null)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0003B47C File Offset: 0x0003987C
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0003B490 File Offset: 0x00039890
		internal virtual TextBox TextTankAhg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankAhg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankAhg = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0003B49C File Offset: 0x0003989C
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0003B4B0 File Offset: 0x000398B0
		internal virtual TextBox TextTankBgh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextTankBgh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextTankBgh = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0003B4BC File Offset: 0x000398BC
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0003B4D0 File Offset: 0x000398D0
		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				if (this._Button2 != null)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				if (this._Button2 != null)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0003B51C File Offset: 0x0003991C
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0003B530 File Offset: 0x00039930
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0003B53C File Offset: 0x0003993C
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0003B550 File Offset: 0x00039950
		internal virtual RadioButton RadioDriver4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioDriver4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioDriver4_CheckedChanged);
				if (this._RadioDriver4 != null)
				{
					this._RadioDriver4.CheckedChanged -= value2;
				}
				this._RadioDriver4 = value;
				if (this._RadioDriver4 != null)
				{
					this._RadioDriver4.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0003B59C File Offset: 0x0003999C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x0003B5B0 File Offset: 0x000399B0
		internal virtual TextBox TextDriver4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextDriver4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextDriver4_TextChanged);
				if (this._TextDriver4 != null)
				{
					this._TextDriver4.TextChanged -= value2;
				}
				this._TextDriver4 = value;
				if (this._TextDriver4 != null)
				{
					this._TextDriver4.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0003B5FC File Offset: 0x000399FC
		// (set) Token: 0x060001FF RID: 511 RVA: 0x0003B610 File Offset: 0x00039A10
		internal virtual RadioButton RadioDriver3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioDriver3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioDriver3_CheckedChanged);
				if (this._RadioDriver3 != null)
				{
					this._RadioDriver3.CheckedChanged -= value2;
				}
				this._RadioDriver3 = value;
				if (this._RadioDriver3 != null)
				{
					this._RadioDriver3.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0003B65C File Offset: 0x00039A5C
		// (set) Token: 0x06000201 RID: 513 RVA: 0x0003B670 File Offset: 0x00039A70
		internal virtual TextBox TextDriver3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextDriver3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextDriver3_TextChanged);
				if (this._TextDriver3 != null)
				{
					this._TextDriver3.TextChanged -= value2;
				}
				this._TextDriver3 = value;
				if (this._TextDriver3 != null)
				{
					this._TextDriver3.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0003B6BC File Offset: 0x00039ABC
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0003B6D0 File Offset: 0x00039AD0
		internal virtual RadioButton RadioDriver2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioDriver2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioDriver2_CheckedChanged);
				if (this._RadioDriver2 != null)
				{
					this._RadioDriver2.CheckedChanged -= value2;
				}
				this._RadioDriver2 = value;
				if (this._RadioDriver2 != null)
				{
					this._RadioDriver2.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0003B71C File Offset: 0x00039B1C
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0003B730 File Offset: 0x00039B30
		internal virtual TextBox TextDriver2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextDriver2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextDriver2_TextChanged);
				if (this._TextDriver2 != null)
				{
					this._TextDriver2.TextChanged -= value2;
				}
				this._TextDriver2 = value;
				if (this._TextDriver2 != null)
				{
					this._TextDriver2.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0003B77C File Offset: 0x00039B7C
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0003B790 File Offset: 0x00039B90
		internal virtual RadioButton RadioDriver1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RadioDriver1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RadioDriver1_CheckedChanged);
				if (this._RadioDriver1 != null)
				{
					this._RadioDriver1.CheckedChanged -= value2;
				}
				this._RadioDriver1 = value;
				if (this._RadioDriver1 != null)
				{
					this._RadioDriver1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0003B7DC File Offset: 0x00039BDC
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0003B7F0 File Offset: 0x00039BF0
		internal virtual TextBox TextDriver1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextDriver1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TextDriver1_TextChanged);
				if (this._TextDriver1 != null)
				{
					this._TextDriver1.TextChanged -= value2;
				}
				this._TextDriver1 = value;
				if (this._TextDriver1 != null)
				{
					this._TextDriver1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600020A RID: 522 RVA: 0x0003B83C File Offset: 0x00039C3C
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0003B850 File Offset: 0x00039C50
		internal virtual ComboBox ComboBoxports
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBoxports;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ComboBoxports_SelectedIndexChanged);
				MouseEventHandler value3 = new MouseEventHandler(this.ComboBoxports_MouseDoubleClick);
				if (this._ComboBoxports != null)
				{
					this._ComboBoxports.SelectedIndexChanged -= value2;
					this._ComboBoxports.MouseDoubleClick -= value3;
				}
				this._ComboBoxports = value;
				if (this._ComboBoxports != null)
				{
					this._ComboBoxports.SelectedIndexChanged += value2;
					this._ComboBoxports.MouseDoubleClick += value3;
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600020C RID: 524 RVA: 0x0003B8C0 File Offset: 0x00039CC0
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0003B8D4 File Offset: 0x00039CD4
		internal virtual NumericUpDown NUpGround
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NUpGround;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NUpGround = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0003B8E0 File Offset: 0x00039CE0
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0003B8F4 File Offset: 0x00039CF4
		internal virtual CheckBox chkNovatron
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkNovatron;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkNovatron = value;
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0003B900 File Offset: 0x00039D00
		private void KntrlComPort_Tick(object sender, EventArgs e)
		{
			if (!this.Signaler.ComÄrUppDat)
			{
				this.TextIPCver.Text = "No Communikation";
			}
			else
			{
				this.TextIPCver.Text = this.Signaler.IPCversion;
			}
			if (this.Visible)
			{
				this.TextByteSek.Text = this.Signaler.AntalTknSek;
				if (this.Signaler.ComÄrUppDat)
				{
					this.TextIPCver.BackColor = this.TextByteSek.BackColor;
					this.TextIPCver.Text = this.Signaler.IPCversion;
				}
				else
				{
					this.TextIPCver.BackColor = Color.LightPink;
					this.TextIPCver.Text = "No Communikation";
				}
				this.TextUppdatesSek.Text = Conversions.ToString(this.Signaler.DjupViktLäst);
				this.TextComRestarts.Text = Conversions.ToString(this.Signaler.ComRestarts);
				this.TextMottagsFel.Text = Conversions.ToString(this.Signaler.MottagsFelRäknare);
				this.Label2.Text = Conversions.ToString(this.Signaler.Väntar);
				this.Label3.Text = Conversions.ToString(this.Signaler.AntalTkn);
				this.Label4.Text = Conversions.ToString(this.Signaler.Sekunder);
				this.Label5.Text = this.Signaler.Meddelande;
				this.TextSvivelTryck.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätTsvivel) / 1000.0, "0.000");
				this.TextSlangTryck.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätTslang) / 1000.0, "0.000");
				this.TextTankATryck.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätTtankA) / 1000.0, "0.000");
				this.TextTankBTryck.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätTtankB) / 1000.0, "0.000");
				this.TextBorrDjup.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätDjup) / 1000.0, "0.000");
				this.TextTankAViktL.Text = this.Signaler.MätViktAl;
				this.TextTankAViktH.Text = this.Signaler.MätViktAh;
				this.TextTankAError.Text = this.Signaler.MätFelkodA;
				this.TextTankBViktL.Text = this.Signaler.MätViktBl;
				this.TextTankBViktH.Text = this.Signaler.MätViktBh;
				this.TextTankBerror.Text = this.Signaler.MätFelkodB;
				this.TextTankAhg.Text = Strings.Format((double)this.Signaler.MätViktAhg / 10.0, "0.0") + "  kg";
				this.TextTankBgh.Text = Strings.Format((double)this.Signaler.MätViktBhg / 10.0, "0.0") + "  kg";
				this.TextBorrSpeed.Text = this.Signaler.MätVarvBorr;
				this.TextCellASpeed.Text = this.Signaler.MätVarvCellA;
				this.TextCellBSpeed.Text = this.Signaler.MätVarvCellB;
				this.TextTankATemp.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätTempLuftA) / 100.0, "0.0");
				this.TextTankBTemp.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätTempLuftB) / 100.0, "0.0");
				this.TextKomprTemp.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätTempKompr) / 100.0, "0.0");
				this.TextInstaller.Text = this.Signaler.MätInstaller;
				this.TextCarrier.Text = this.Signaler.Carrier;
				this.TextStatusAirValves.Text = this.Signaler.MätLuftVstatus;
				this.HuvudForm.Label2.Text = "serial no " + this.Signaler.MätInstaller;
				this.HuvudForm.lblJunttan.Text = "Junttan DS15";
				if (Operators.CompareString(this.Signaler.MätInstaller, "1337", false) == 0)
				{
					this.HuvudForm.lblJunttan.Text = "Junttan DS18";
				}
				if (Operators.CompareString(this.Signaler.MätInstaller, "1472", false) == 0)
				{
					this.HuvudForm.lblJunttan.Text = "Junttan DS18";
				}
				if (Operators.CompareString(this.Signaler.MätInstaller, "1163", false) == 0)
				{
					this.HuvudForm.lblJunttan.Text = "Junttan DS15";
				}
				if (Operators.CompareString(this.Signaler.MätInstaller, "1193", false) == 0)
				{
					this.HuvudForm.lblJunttan.Text = "Junttan DS25";
				}
				this.TextLuftFukt.Text = Strings.Format((double)Conversions.ToInteger(this.Signaler.MätLuftFukt) / 100.0, "0.00");
				this.TextInPotA.Text = this.Signaler.MätPotCellA;
				this.TextINPotB.Text = this.Signaler.MätPotCellB;
				this.TextUtUppNer.Text = this.Signaler.MätUtUNer;
				this.TextUtRotation.Text = this.Signaler.MätUtRot;
				this.TextUtCellA.Text = this.Signaler.MätUtCellA;
				this.TextUtCellB.Text = this.Signaler.MätUtCellB;
				this.TextStatusVärden.Text = this.Signaler.MätStatusBitar;
				Monitor.Enter(this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia_Init);
				try
				{
					if (this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia_Init.State == 0)
					{
						this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia_Init.State = 2;
						this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia = this.Signaler.VillÄndraiSettings;
					}
					else if (this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia_Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia_Init.State = 1;
					Monitor.Exit(this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia_Init);
				}
				if (this.Signaler.VillÄndraiSettings != this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia)
				{
					if (this.Signaler.VillÄndraiSettings)
					{
						this.GroupMätVärden.Text = "Measured Values do not Update (changing settings values)";
						this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia = this.Signaler.VillÄndraiSettings;
					}
					else
					{
						this.GroupMätVärden.Text = "Measured Values Updates Normaly";
						this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia = this.Signaler.VillÄndraiSettings;
					}
				}
			}
			FestoCom signaler = this.Signaler;
			checked
			{
				signaler.Sekunder++;
				this.Signaler.ViktDjupPerSek = this.Signaler.DjupViktLäst;
				this.Signaler.DjupViktLäst = 0;
				Monitor.Enter(this.STATIC_KntrlComPort_Tick_20211C1265_Startat_Init);
				try
				{
					if (this.STATIC_KntrlComPort_Tick_20211C1265_Startat_Init.State == 0)
					{
						this.STATIC_KntrlComPort_Tick_20211C1265_Startat_Init.State = 2;
						this.STATIC_KntrlComPort_Tick_20211C1265_Startat = false;
					}
					else if (this.STATIC_KntrlComPort_Tick_20211C1265_Startat_Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.STATIC_KntrlComPort_Tick_20211C1265_Startat_Init.State = 1;
					Monitor.Exit(this.STATIC_KntrlComPort_Tick_20211C1265_Startat_Init);
				}
				if (!this.STATIC_KntrlComPort_Tick_20211C1265_Startat)
				{
					this.Signaler.AntalTkn = 0;
					this.STATIC_KntrlComPort_Tick_20211C1265_Antaltecken = 0;
					this.Signaler.Sekunder = 0;
					this.Signaler.ComÄrUppDat = false;
					this.Signaler.ReStartaCom();
					this.STATIC_KntrlComPort_Tick_20211C1265_Startat = true;
					return;
				}
				Monitor.Enter(this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens_Init);
				try
				{
					if (this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens_Init.State == 0)
					{
						this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens_Init.State = 2;
						this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens = false;
					}
					else if (this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens_Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens_Init.State = 1;
					Monitor.Exit(this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens_Init);
				}
				if (this.Signaler.ComÄrUppDat & !this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens)
				{
					this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens = true;
					this.Visible = false;
					this.HuvudForm.Visible = true;
					this.HuvudForm.Focus();
				}
				if (this.Signaler.AntalTkn > this.STATIC_KntrlComPort_Tick_20211C1265_Antaltecken)
				{
					this.STATIC_KntrlComPort_Tick_20211C1265_Antaltecken = this.Signaler.AntalTkn;
					return;
				}
				if (this.Signaler.AntalTkn <= this.STATIC_KntrlComPort_Tick_20211C1265_Antaltecken)
				{
					this.Signaler.AntalTkn = 0;
					this.STATIC_KntrlComPort_Tick_20211C1265_Antaltecken = 0;
					this.Signaler.Sekunder = 0;
					this.Signaler.ComÄrUppDat = false;
					this.Signaler.ReStartaCom();
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0003C230 File Offset: 0x0003A630
		public TestarKom()
		{
			base.FormClosing += this.TestarKom_FormClosing;
			base.KeyDown += this.TestarKom_KeyDown;
			this.STATIC_KntrlComPort_Tick_20211C1265_StartSekvens_Init = new StaticLocalInitFlag();
			this.STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia_Init = new StaticLocalInitFlag();
			this.STATIC_KntrlComPort_Tick_20211C1265_Startat_Init = new StaticLocalInitFlag();
			this.InitializeComponent();
			string[] SerieArr = SerialPort.GetPortNames();
			SerialPort Port = new SerialPort();
			int num = 0;
			int num2 = Information.UBound(SerieArr, 1);
			checked
			{
				bool FinnsPort = false;
				for (int i = num; i <= num2; i++)
				{
					if (Operators.CompareString(SerieArr[i], MySettingsProperty.Settings.ComPortVald, false) == 0)
					{
						FinnsPort = true;
					}
				}
				this.ComboBoxports.DataSource = SerieArr;
				if (FinnsPort)
				{
					this.ComboBoxports.SelectedItem = MySettingsProperty.Settings.ComPortVald;
				}
				bool Annanport = false;
				if (!FinnsPort)
				{
					int num3 = 0;
					int num4 = Information.UBound(SerieArr, 1);
					for (int i = num3; i <= num4; i++)
					{
						Port.PortName = SerieArr[i];
						if (!Port.IsOpen)
						{
							MySettingsProperty.Settings.ComPortVald = SerieArr[i];
							Annanport = true;
							this.ComboBoxports.SelectedItem = MySettingsProperty.Settings.ComPortVald;
							break;
						}
					}
				}
				if (!FinnsPort & !Annanport)
				{
					Interaction.MsgBox(" No Com Port avalible application closes", MsgBoxStyle.OkOnly, null);
					Application.Exit();
				}
				string Bibliotek = MySettingsProperty.Settings.ProjectBib;
				if (!MyProject.Computer.FileSystem.DirectoryExists(Bibliotek))
				{
					try
					{
						MyProject.Computer.FileSystem.CreateDirectory(Bibliotek);
						Interaction.MsgBox(" New Direktory are maid " + Bibliotek, MsgBoxStyle.OkOnly, " File system Info ");
					}
					catch (Exception ex)
					{
						Interaction.MsgBox(ex.ToString() + "Application closes", MsgBoxStyle.OkOnly, " Not Possible to create directory ");
						Application.Exit();
					}
				}
				this.StartComboPort = true;
				this.Signaler = new FestoCom();
				this.Text = " Communication with IPC version " + this.Signaler.Version;
				this.AktuellPelare = new clsPelare();
				this.frmSettings = new FormSettings();
				this.HuvudForm = new frmTestDrill();
				this.HuvudForm.Visible = false;
				this.Signaler.SättingsForm = this.frmSettings;
				this.HuvudForm.InSignal = this.Signaler;
				this.HuvudForm.AktPelare = this.AktuellPelare;
				this.HuvudForm.Visible = false;
				MySettingsProperty.Settings.Reload();
				this.TextDriver1.Text = MySettingsProperty.Settings.Driver1;
				this.TextDriver2.Text = MySettingsProperty.Settings.Driver2;
				this.TextDriver3.Text = MySettingsProperty.Settings.Driver3;
				this.TextDriver4.Text = MySettingsProperty.Settings.Driver4;
				switch (MySettingsProperty.Settings.ValdDriver)
				{
				case 1:
					this.RadioDriver1.Checked = true;
					break;
				case 2:
					this.RadioDriver2.Checked = true;
					break;
				case 3:
					this.RadioDriver3.Checked = true;
					break;
				case 4:
					this.RadioDriver4.Checked = true;
					break;
				}
				this.NUpGround.Value = new decimal(MySettingsProperty.Settings.HeightGround);
				this.Visible = true;
				this.KntrlComPort.Enabled = true;
				Control.CheckForIllegalCrossThreadCalls = false;
				if (MySettingsProperty.Settings.Novatron)
				{
					this.chkNovatron.Checked = true;
				}
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0003C588 File Offset: 0x0003A988
		private void VäxlaTillSättings()
		{
			if (!this.Signaler.ComÄrUppDat)
			{
				Interaction.MsgBox(" The communication are not uppdated with the IPC so there are no values to change ", MsgBoxStyle.OkOnly, " No Connection ");
				return;
			}
			this.frmSettings.Visible = true;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0003C5B8 File Offset: 0x0003A9B8
		private void VäxlaTillDrill()
		{
			if (MySettingsProperty.Settings.HeightGround != Convert.ToSingle(this.NUpGround.Value))
			{
				MsgBoxResult svar = Interaction.MsgBox(" Change Ground level ? ", MsgBoxStyle.OkCancel, " Change has been made in Ground level ");
				if (svar == MsgBoxResult.Ok)
				{
					MySettingsProperty.Settings.HeightGround = Convert.ToSingle(this.NUpGround.Value);
				}
				else
				{
					this.NUpGround.Value = new decimal(MySettingsProperty.Settings.HeightGround);
				}
			}
			MySettingsProperty.Settings.Driver1 = this.TextDriver1.Text;
			MySettingsProperty.Settings.Driver2 = this.TextDriver2.Text;
			MySettingsProperty.Settings.Driver3 = this.TextDriver3.Text;
			MySettingsProperty.Settings.Driver4 = this.TextDriver4.Text;
			if (this.RadioDriver1.Checked)
			{
				MySettingsProperty.Settings.ValdDriver = 1;
			}
			if (this.RadioDriver2.Checked)
			{
				MySettingsProperty.Settings.ValdDriver = 2;
			}
			if (this.RadioDriver3.Checked)
			{
				MySettingsProperty.Settings.ValdDriver = 3;
			}
			if (this.RadioDriver4.Checked)
			{
				MySettingsProperty.Settings.ValdDriver = 4;
			}
			MySettingsProperty.Settings.Save();
			if (this.chkNovatron.Checked)
			{
				MySettingsProperty.Settings.Novatron = true;
			}
			else
			{
				MySettingsProperty.Settings.Novatron = false;
			}
			this.Visible = false;
			this.HuvudForm.Visible = true;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0003C724 File Offset: 0x0003AB24
		private void Button1_Click(object sender, EventArgs e)
		{
			this.VäxlaTillSättings();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0003C72C File Offset: 0x0003AB2C
		private void TestarKom_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				this.VäxlaTillDrill();
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0003C744 File Offset: 0x0003AB44
		private void TestarKom_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 117)
			{
				this.VäxlaTillSättings();
			}
			if (e.KeyValue == 118)
			{
				this.VäxlaTillDrill();
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0003C768 File Offset: 0x0003AB68
		private void Button2_Click(object sender, EventArgs e)
		{
			this.VäxlaTillDrill();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0003C770 File Offset: 0x0003AB70
		private void RadioDriver1_CheckedChanged(object sender, EventArgs e)
		{
			this.mDriverChange = true;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0003C77C File Offset: 0x0003AB7C
		private void RadioDriver2_CheckedChanged(object sender, EventArgs e)
		{
			this.mDriverChange = true;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0003C788 File Offset: 0x0003AB88
		private void RadioDriver3_CheckedChanged(object sender, EventArgs e)
		{
			this.mDriverChange = true;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0003C794 File Offset: 0x0003AB94
		private void RadioDriver4_CheckedChanged(object sender, EventArgs e)
		{
			this.mDriverChange = true;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0003C7A0 File Offset: 0x0003ABA0
		private void TextDriver1_TextChanged(object sender, EventArgs e)
		{
			this.mDriverChange = true;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0003C7AC File Offset: 0x0003ABAC
		private void TextDriver2_TextChanged(object sender, EventArgs e)
		{
			this.mDriverChange = true;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0003C7B8 File Offset: 0x0003ABB8
		private void TextDriver3_TextChanged(object sender, EventArgs e)
		{
			this.mDriverChange = true;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0003C7C4 File Offset: 0x0003ABC4
		private void TextDriver4_TextChanged(object sender, EventArgs e)
		{
			this.mDriverChange = true;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0003C7D0 File Offset: 0x0003ABD0
		private void ComboBoxports_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.ComboBoxports.Enabled = true;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0003C7E0 File Offset: 0x0003ABE0
		private void ComboBoxports_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!this.StartComboPort)
			{
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(this.ComboBoxports.SelectedItem, MySettingsProperty.Settings.ComPortVald, false))
			{
				return;
			}
			MsgBoxResult Svar = Interaction.MsgBox("Change port ? If OK you have to restart application", MsgBoxStyle.OkCancel, null);
			if (Svar == MsgBoxResult.Cancel)
			{
				this.ComboBoxports.SelectedItem = MySettingsProperty.Settings.ComPortVald;
			}
			else
			{
				MySettingsProperty.Settings.ComPortVald = Conversions.ToString(this.ComboBoxports.SelectedItem);
				MySettingsProperty.Settings.Save();
				Application.Exit();
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0003C868 File Offset: 0x0003AC68
		private void GroupMätVärden_DoubleClick(object sender, EventArgs e)
		{
			if (this.ComboBoxports.Enabled)
			{
				this.ComboBoxports.Enabled = false;
			}
			else
			{
				this.ComboBoxports.Enabled = true;
			}
		}

		// Token: 0x04000111 RID: 273
		[AccessedThroughProperty("KntrlComPort")]
		private System.Windows.Forms.Timer _KntrlComPort;

		// Token: 0x04000112 RID: 274
		[AccessedThroughProperty("GroupBoxStatus")]
		private GroupBox _GroupBoxStatus;

		// Token: 0x04000113 RID: 275
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000114 RID: 276
		[AccessedThroughProperty("TextIPCver")]
		private TextBox _TextIPCver;

		// Token: 0x04000115 RID: 277
		[AccessedThroughProperty("TextByteSek")]
		private TextBox _TextByteSek;

		// Token: 0x04000116 RID: 278
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000117 RID: 279
		[AccessedThroughProperty("TextUppdatesSek")]
		private TextBox _TextUppdatesSek;

		// Token: 0x04000118 RID: 280
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000119 RID: 281
		[AccessedThroughProperty("TextComRestarts")]
		private TextBox _TextComRestarts;

		// Token: 0x0400011A RID: 282
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400011B RID: 283
		[AccessedThroughProperty("TextMottagsFel")]
		private TextBox _TextMottagsFel;

		// Token: 0x0400011C RID: 284
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400011D RID: 285
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400011E RID: 286
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400011F RID: 287
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000120 RID: 288
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000121 RID: 289
		[AccessedThroughProperty("GroupMätVärden")]
		private GroupBox _GroupMätVärden;

		// Token: 0x04000122 RID: 290
		[AccessedThroughProperty("TextTankBTryck")]
		private TextBox _TextTankBTryck;

		// Token: 0x04000123 RID: 291
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000124 RID: 292
		[AccessedThroughProperty("TextTankATryck")]
		private TextBox _TextTankATryck;

		// Token: 0x04000125 RID: 293
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000126 RID: 294
		[AccessedThroughProperty("TextSlangTryck")]
		private TextBox _TextSlangTryck;

		// Token: 0x04000127 RID: 295
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000128 RID: 296
		[AccessedThroughProperty("TextSvivelTryck")]
		private TextBox _TextSvivelTryck;

		// Token: 0x04000129 RID: 297
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x0400012A RID: 298
		[AccessedThroughProperty("TextTankBerror")]
		private TextBox _TextTankBerror;

		// Token: 0x0400012B RID: 299
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x0400012C RID: 300
		[AccessedThroughProperty("TextTankBViktL")]
		private TextBox _TextTankBViktL;

		// Token: 0x0400012D RID: 301
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x0400012E RID: 302
		[AccessedThroughProperty("TextTankAError")]
		private TextBox _TextTankAError;

		// Token: 0x0400012F RID: 303
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04000130 RID: 304
		[AccessedThroughProperty("TextTankAViktL")]
		private TextBox _TextTankAViktL;

		// Token: 0x04000131 RID: 305
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x04000132 RID: 306
		[AccessedThroughProperty("TextBorrDjup")]
		private TextBox _TextBorrDjup;

		// Token: 0x04000133 RID: 307
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x04000134 RID: 308
		[AccessedThroughProperty("TextCellBSpeed")]
		private TextBox _TextCellBSpeed;

		// Token: 0x04000135 RID: 309
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000136 RID: 310
		[AccessedThroughProperty("TextCellASpeed")]
		private TextBox _TextCellASpeed;

		// Token: 0x04000137 RID: 311
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x04000138 RID: 312
		[AccessedThroughProperty("TextBorrSpeed")]
		private TextBox _TextBorrSpeed;

		// Token: 0x04000139 RID: 313
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x0400013A RID: 314
		[AccessedThroughProperty("TextTankBViktH")]
		private TextBox _TextTankBViktH;

		// Token: 0x0400013B RID: 315
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x0400013C RID: 316
		[AccessedThroughProperty("TextKomprTemp")]
		private TextBox _TextKomprTemp;

		// Token: 0x0400013D RID: 317
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x0400013E RID: 318
		[AccessedThroughProperty("TextTankBTemp")]
		private TextBox _TextTankBTemp;

		// Token: 0x0400013F RID: 319
		[AccessedThroughProperty("Label24")]
		private Label _Label24;

		// Token: 0x04000140 RID: 320
		[AccessedThroughProperty("TextTankATemp")]
		private TextBox _TextTankATemp;

		// Token: 0x04000141 RID: 321
		[AccessedThroughProperty("Label25")]
		private Label _Label25;

		// Token: 0x04000142 RID: 322
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000143 RID: 323
		[AccessedThroughProperty("Label26")]
		private Label _Label26;

		// Token: 0x04000144 RID: 324
		[AccessedThroughProperty("Label27")]
		private Label _Label27;

		// Token: 0x04000145 RID: 325
		[AccessedThroughProperty("Label28")]
		private Label _Label28;

		// Token: 0x04000146 RID: 326
		[AccessedThroughProperty("Label29")]
		private Label _Label29;

		// Token: 0x04000147 RID: 327
		[AccessedThroughProperty("TextStatusVärden")]
		private TextBox _TextStatusVärden;

		// Token: 0x04000148 RID: 328
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x04000149 RID: 329
		[AccessedThroughProperty("TextUtCellB")]
		private TextBox _TextUtCellB;

		// Token: 0x0400014A RID: 330
		[AccessedThroughProperty("Label31")]
		private Label _Label31;

		// Token: 0x0400014B RID: 331
		[AccessedThroughProperty("TextUtCellA")]
		private TextBox _TextUtCellA;

		// Token: 0x0400014C RID: 332
		[AccessedThroughProperty("Label32")]
		private Label _Label32;

		// Token: 0x0400014D RID: 333
		[AccessedThroughProperty("TextUtRotation")]
		private TextBox _TextUtRotation;

		// Token: 0x0400014E RID: 334
		[AccessedThroughProperty("Label33")]
		private Label _Label33;

		// Token: 0x0400014F RID: 335
		[AccessedThroughProperty("TextUtUppNer")]
		private TextBox _TextUtUppNer;

		// Token: 0x04000150 RID: 336
		[AccessedThroughProperty("Label34")]
		private Label _Label34;

		// Token: 0x04000151 RID: 337
		[AccessedThroughProperty("TextINPotB")]
		private TextBox _TextINPotB;

		// Token: 0x04000152 RID: 338
		[AccessedThroughProperty("Label35")]
		private Label _Label35;

		// Token: 0x04000153 RID: 339
		[AccessedThroughProperty("TextInPotA")]
		private TextBox _TextInPotA;

		// Token: 0x04000154 RID: 340
		[AccessedThroughProperty("Label36")]
		private Label _Label36;

		// Token: 0x04000155 RID: 341
		[AccessedThroughProperty("TextLuftFukt")]
		private TextBox _TextLuftFukt;

		// Token: 0x04000156 RID: 342
		[AccessedThroughProperty("Label37")]
		private Label _Label37;

		// Token: 0x04000157 RID: 343
		[AccessedThroughProperty("TextStatusAirValves")]
		private TextBox _TextStatusAirValves;

		// Token: 0x04000158 RID: 344
		[AccessedThroughProperty("Label38")]
		private Label _Label38;

		// Token: 0x04000159 RID: 345
		[AccessedThroughProperty("TextCarrier")]
		private TextBox _TextCarrier;

		// Token: 0x0400015A RID: 346
		[AccessedThroughProperty("Label39")]
		private Label _Label39;

		// Token: 0x0400015B RID: 347
		[AccessedThroughProperty("TextInstaller")]
		private TextBox _TextInstaller;

		// Token: 0x0400015C RID: 348
		[AccessedThroughProperty("Label40")]
		private Label _Label40;

		// Token: 0x0400015D RID: 349
		[AccessedThroughProperty("TextTankAViktH")]
		private TextBox _TextTankAViktH;

		// Token: 0x0400015E RID: 350
		[AccessedThroughProperty("Label41")]
		private Label _Label41;

		// Token: 0x0400015F RID: 351
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000160 RID: 352
		[AccessedThroughProperty("TextTankAhg")]
		private TextBox _TextTankAhg;

		// Token: 0x04000161 RID: 353
		[AccessedThroughProperty("TextTankBgh")]
		private TextBox _TextTankBgh;

		// Token: 0x04000162 RID: 354
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000163 RID: 355
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x04000164 RID: 356
		[AccessedThroughProperty("RadioDriver4")]
		private RadioButton _RadioDriver4;

		// Token: 0x04000165 RID: 357
		[AccessedThroughProperty("TextDriver4")]
		private TextBox _TextDriver4;

		// Token: 0x04000166 RID: 358
		[AccessedThroughProperty("RadioDriver3")]
		private RadioButton _RadioDriver3;

		// Token: 0x04000167 RID: 359
		[AccessedThroughProperty("TextDriver3")]
		private TextBox _TextDriver3;

		// Token: 0x04000168 RID: 360
		[AccessedThroughProperty("RadioDriver2")]
		private RadioButton _RadioDriver2;

		// Token: 0x04000169 RID: 361
		[AccessedThroughProperty("TextDriver2")]
		private TextBox _TextDriver2;

		// Token: 0x0400016A RID: 362
		[AccessedThroughProperty("RadioDriver1")]
		private RadioButton _RadioDriver1;

		// Token: 0x0400016B RID: 363
		[AccessedThroughProperty("TextDriver1")]
		private TextBox _TextDriver1;

		// Token: 0x0400016C RID: 364
		[AccessedThroughProperty("ComboBoxports")]
		private ComboBox _ComboBoxports;

		// Token: 0x0400016D RID: 365
		[AccessedThroughProperty("NUpGround")]
		private NumericUpDown _NUpGround;

		// Token: 0x0400016E RID: 366
		[AccessedThroughProperty("chkNovatron")]
		private CheckBox _chkNovatron;

		// Token: 0x0400016F RID: 367
		public FestoCom Signaler;

		// Token: 0x04000170 RID: 368
		public clsPelare AktuellPelare;

		// Token: 0x04000171 RID: 369
		public FormSettings frmSettings;

		// Token: 0x04000172 RID: 370
		public frmTestDrill HuvudForm;

		// Token: 0x04000173 RID: 371
		private bool mDriverChange;

		// Token: 0x04000174 RID: 372
		private bool StartComboPort;

		// Token: 0x04000175 RID: 373
		private int STATIC_KntrlComPort_Tick_20211C1265_Antaltecken;

		// Token: 0x04000176 RID: 374
		private StaticLocalInitFlag STATIC_KntrlComPort_Tick_20211C1265_StartSekvens_Init;

		// Token: 0x04000177 RID: 375
		private bool STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia;

		// Token: 0x04000178 RID: 376
		private bool STATIC_KntrlComPort_Tick_20211C1265_StartSekvens;

		// Token: 0x04000179 RID: 377
		private StaticLocalInitFlag STATIC_KntrlComPort_Tick_20211C1265_villÄndraKopia_Init;

		// Token: 0x0400017A RID: 378
		private bool STATIC_KntrlComPort_Tick_20211C1265_Startat;

		// Token: 0x0400017B RID: 379
		private StaticLocalInitFlag STATIC_KntrlComPort_Tick_20211C1265_Startat_Init;
	}
}
