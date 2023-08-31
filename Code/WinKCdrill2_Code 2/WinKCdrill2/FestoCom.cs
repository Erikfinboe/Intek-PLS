using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using winKCdrill2.My;

namespace winKCdrill2
{
	// Token: 0x0200000B RID: 11
	public class FestoCom
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0002AB20 File Offset: 0x00028F20
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0002AB34 File Offset: 0x00028F34
		public virtual SerialPort mAnvändPort
		{
			[DebuggerNonUserCode]
			get
			{
				return this._mAnvändPort;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._mAnvändPort = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0002AB40 File Offset: 0x00028F40
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0002AB54 File Offset: 0x00028F54
		public string StigBott
		{
			get
			{
				return this.mStigBott;
			}
			set
			{
				this.mStigBott = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0002AB60 File Offset: 0x00028F60
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0002AB74 File Offset: 0x00028F74
		public string StigTopp
		{
			get
			{
				return this.mStigTopp;
			}
			set
			{
				this.mStigTopp = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0002AB80 File Offset: 0x00028F80
		// (set) Token: 0x06000072 RID: 114 RVA: 0x0002AB98 File Offset: 0x00028F98
		public SerialPort Comport
		{
			get
			{
				return this.mAnvändPort;
			}
			set
			{
				this.mAnvändPort = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0002ABA4 File Offset: 0x00028FA4
		public string VågKomAvstängd
		{
			get
			{
				return this.mVågKomAvstängd;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0002ABBC File Offset: 0x00028FBC
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0002ABD4 File Offset: 0x00028FD4
		public int MätViktBhg
		{
			get
			{
				return this.mMätViktBhg;
			}
			set
			{
				this.mMätViktBhg = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0002ABE0 File Offset: 0x00028FE0
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0002ABF8 File Offset: 0x00028FF8
		public int MätViktAhg
		{
			get
			{
				return this.mMätViktAhg;
			}
			set
			{
				this.mMätViktAh = Conversions.ToString(value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0002AC08 File Offset: 0x00029008
		public string AutoRegFakt
		{
			get
			{
				return this.mAutoRegFakt;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0002AC20 File Offset: 0x00029020
		public string AutoEgenUpp
		{
			get
			{
				return this.mAutoEgenUpp;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0002AC38 File Offset: 0x00029038
		public string AutoAntalMedelH
		{
			get
			{
				return this.mAutoAntalMedelH;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0002AC50 File Offset: 0x00029050
		public string AutoMaxUpp
		{
			get
			{
				return this.mAutoMaxUpp;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0002AC68 File Offset: 0x00029068
		public string AutoMinUpp
		{
			get
			{
				return this.mAutoMinUpp;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0002AC80 File Offset: 0x00029080
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0002AC98 File Offset: 0x00029098
		public bool VillÄndraiSettings
		{
			get
			{
				return this.mVillÄndraiSettings;
			}
			set
			{
				this.mVillÄndraiSettings = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0002ACA4 File Offset: 0x000290A4
		public bool SettingsÄrUppdat
		{
			get
			{
				return this.mSettingsÄrUppdat;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0002ACBC File Offset: 0x000290BC
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0002ACD4 File Offset: 0x000290D4
		public int DjupViktLäst
		{
			get
			{
				return this.mDjupViktLäst;
			}
			set
			{
				this.mDjupViktLäst = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0002ACE0 File Offset: 0x000290E0
		public string Meddelande
		{
			get
			{
				return this.mMeddelande;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000083 RID: 131 RVA: 0x0002ACF8 File Offset: 0x000290F8
		// (set) Token: 0x06000084 RID: 132 RVA: 0x0002AD10 File Offset: 0x00029110
		public int AntalTkn
		{
			get
			{
				return this.mAntalTkn;
			}
			set
			{
				this.mAntalTkn = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0002AD1C File Offset: 0x0002911C
		public long Väntar
		{
			get
			{
				return this.mVäntar;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0002AD34 File Offset: 0x00029134
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0002AD4C File Offset: 0x0002914C
		public int Sekunder
		{
			get
			{
				return this.mSekunder;
			}
			set
			{
				this.mSekunder = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0002AD58 File Offset: 0x00029158
		public int ComRestarts
		{
			get
			{
				return this.mComRestarts;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0002AD70 File Offset: 0x00029170
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0002AD88 File Offset: 0x00029188
		public int ViktDjupPerSek
		{
			get
			{
				return this.mViktDjupPerSek;
			}
			set
			{
				this.mViktDjupPerSek = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0002AD94 File Offset: 0x00029194
		public int MottagsFelRäknare
		{
			get
			{
				return this.mMottagsFelRäknare;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0002ADAC File Offset: 0x000291AC
		// (set) Token: 0x0600008D RID: 141 RVA: 0x0002ADC4 File Offset: 0x000291C4
		public string SeriePort
		{
			get
			{
				return this.mSeriePort;
			}
			set
			{
				this.mSeriePort = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0002ADD0 File Offset: 0x000291D0
		public string IPCversion
		{
			get
			{
				return this.mKontrollerVersion;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600008F RID: 143 RVA: 0x0002ADE8 File Offset: 0x000291E8
		public string Version
		{
			get
			{
				return this.mVersionOfFestoCom;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0002AE00 File Offset: 0x00029200
		public string PelEkgTopp
		{
			get
			{
				return this.mPelEkgTopp;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0002AE18 File Offset: 0x00029218
		public string PelEmmtopp
		{
			get
			{
				return this.mPelEmmTopp;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0002AE30 File Offset: 0x00029230
		public string PelEkgBott
		{
			get
			{
				return this.mPelEkgBott;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0002AE48 File Offset: 0x00029248
		public string PelEmmBott
		{
			get
			{
				return this.mPelEmmBott;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0002AE60 File Offset: 0x00029260
		public string PelRotBegräns
		{
			get
			{
				return this.mPelRotBegräns;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0002AE78 File Offset: 0x00029278
		public string PelUtmatDiff
		{
			get
			{
				return this.mPelUtmatDiff;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0002AE90 File Offset: 0x00029290
		public string PelJoyUNBegräns
		{
			get
			{
				return this.mPelJoyUNBegräns;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0002AEA8 File Offset: 0x000292A8
		public string PelJoyRotBegräns
		{
			get
			{
				return this.mPelJoyRotBegräns;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0002AEC0 File Offset: 0x000292C0
		public string PelStoppDjup
		{
			get
			{
				return this.mPelStoppDjup;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0002AED8 File Offset: 0x000292D8
		public string PelTeoHg
		{
			get
			{
				return this.mPelTeoHg;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0002AEF0 File Offset: 0x000292F0
		public string PelFrånTankA
		{
			get
			{
				return this.mPelFrånTankA;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0002AF08 File Offset: 0x00029308
		public string PelStigning
		{
			get
			{
				return this.mPelStigning;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0002AF20 File Offset: 0x00029320
		public bool PelVillMaxStig
		{
			get
			{
				return this.mPelVillMaxStig;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0002AF38 File Offset: 0x00029338
		public bool PelVillCellAuto
		{
			get
			{
				return this.mPelVillCellAuto;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0002AF50 File Offset: 0x00029350
		public string PelVillRotBorr
		{
			get
			{
				return this.mPelVillRotBorr;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0002AF68 File Offset: 0x00029368
		public bool PelVillPelStartMupp
		{
			get
			{
				return this.mPelVillPelStartMupp;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0002AF80 File Offset: 0x00029380
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0002AF98 File Offset: 0x00029398
		public bool IPCnolla
		{
			get
			{
				return this.mIPCnolla;
			}
			set
			{
				this.mIPCnolla = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0002AFA4 File Offset: 0x000293A4
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0002AFBC File Offset: 0x000293BC
		public bool IPCpelStart
		{
			get
			{
				return this.mIPCpelStart;
			}
			set
			{
				this.mIPCpelStart = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0002AFC8 File Offset: 0x000293C8
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0002AFE0 File Offset: 0x000293E0
		public bool IPCpelStopp
		{
			get
			{
				return this.mIPCpelStopp;
			}
			set
			{
				this.mIPCpelStopp = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0002AFEC File Offset: 0x000293EC
		public string MätTsvivel
		{
			get
			{
				return this.mMätTsvivel;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0002B004 File Offset: 0x00029404
		public string MätTslang
		{
			get
			{
				return this.mMätTslang;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0002B01C File Offset: 0x0002941C
		public string MätTtankA
		{
			get
			{
				return this.mMätTtankA;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0002B034 File Offset: 0x00029434
		public string MätTtankB
		{
			get
			{
				return this.mMätTtankB;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0002B04C File Offset: 0x0002944C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0002B064 File Offset: 0x00029464
		public string MätDjup
		{
			get
			{
				return this.mMätDjup;
			}
			set
			{
				this.mMätDjup = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0002B070 File Offset: 0x00029470
		public string MätViktAl
		{
			get
			{
				return this.mMätViktAl;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0002B088 File Offset: 0x00029488
		public string MätViktAh
		{
			get
			{
				return this.mMätViktAh;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0002B0A0 File Offset: 0x000294A0
		public string MätFelkodA
		{
			get
			{
				return this.mMätFelkodA;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0002B0B8 File Offset: 0x000294B8
		public string MätViktBl
		{
			get
			{
				return this.mMätViktBl;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0002B0D0 File Offset: 0x000294D0
		public string MätViktBh
		{
			get
			{
				return this.mMätViktBh;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0002B0E8 File Offset: 0x000294E8
		public string MätFelkodB
		{
			get
			{
				return this.mMätFelkodB;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0002B100 File Offset: 0x00029500
		public string MätVarvBorr
		{
			get
			{
				return this.mMätVarvBorr;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0002B118 File Offset: 0x00029518
		public string MätVarvCellA
		{
			get
			{
				return this.mMätVarvCellA;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0002B130 File Offset: 0x00029530
		public string MätVarvCellB
		{
			get
			{
				return this.mMätVarvCellB;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0002B148 File Offset: 0x00029548
		public string MätTempLuftA
		{
			get
			{
				return this.mMätTempLuftA;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0002B160 File Offset: 0x00029560
		public string MätTempLuftB
		{
			get
			{
				return this.mMätTempLuftB;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0002B178 File Offset: 0x00029578
		public string MätTempKompr
		{
			get
			{
				return this.mMätTempKompr;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0002B190 File Offset: 0x00029590
		public string MätInstaller
		{
			get
			{
				return this.mMätInstaller;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0002B1A8 File Offset: 0x000295A8
		public string Carrier
		{
			get
			{
				return this.mMätCarrier;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0002B1C0 File Offset: 0x000295C0
		public string MätLuftVstatus
		{
			get
			{
				return this.mMätLuftVstatus;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0002B1D8 File Offset: 0x000295D8
		public string MätLuftFukt
		{
			get
			{
				return this.mMätLuftFukt;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0002B1F0 File Offset: 0x000295F0
		public string MätPotCellA
		{
			get
			{
				return this.mMätPotCellA;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0002B208 File Offset: 0x00029608
		public string MätPotCellB
		{
			get
			{
				return this.mMätPotCellB;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0002B220 File Offset: 0x00029620
		public string MätUtUNer
		{
			get
			{
				return this.mMätUtUNer;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0002B238 File Offset: 0x00029638
		public string MätUtRot
		{
			get
			{
				return this.mMätUtRot;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0002B250 File Offset: 0x00029650
		public string MätUtCellA
		{
			get
			{
				return this.mMätUtCellA;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0002B268 File Offset: 0x00029668
		public string MätUtCellB
		{
			get
			{
				return this.mMätUtCellB;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0002B280 File Offset: 0x00029680
		public string MätStatusBitar
		{
			get
			{
				return this.mMätStatusBitar;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0002B298 File Offset: 0x00029698
		public string AntalTknSek
		{
			get
			{
				string AntalTknSek;
				if (this.mSekunder > 0 & this.mAntalTkn > 0)
				{
					AntalTknSek = Strings.Format((double)this.mAntalTkn / (double)this.mSekunder, "0");
				}
				else
				{
					AntalTknSek = "0";
				}
				return AntalTknSek;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0002B2E4 File Offset: 0x000296E4
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0002B2FC File Offset: 0x000296FC
		public bool ComÄrUppDat
		{
			get
			{
				return this.mComÄrUppDat;
			}
			set
			{
				this.mComÄrUppDat = value;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0002B308 File Offset: 0x00029708
		public FestoCom()
		{
			this.mVersionOfFestoCom = "4.00";
			this.mKontrollerVersion = "x";
			this.mAntalTkn = 0;
			this.mAnvändPort = new SerialPort();
			this.KntrSeriePort = new System.Timers.Timer();
			this.mSeriePort = "COM1";
			this.mComRestarts = -1;
			this.STATIC_TeckenAnlänt_20211C1241_Mottaget_Init = new StaticLocalInitFlag();
			this.mComÄrUppDat = false;
			this.mSeriePort = MySettingsProperty.Settings.ComPortVald;
			this.mAnvändPort.PortName = this.mSeriePort;
			this.mAnvändPort.BaudRate = 9600;
			this.mAnvändPort.DataBits = 8;
			this.mAnvändPort.StopBits = StopBits.One;
			this.mAnvändPort.RtsEnable = true;
			this.mAnvändPort.DtrEnable = true;
			this.mAnvändPort.Parity = Parity.None;
			this.mAnvändPort.DiscardNull = true;
			this.mAnvändPort.NewLine = "\r";
			this.mAnvändPort.DataReceived += this.TeckenAnlänt;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0002B414 File Offset: 0x00029814
		private void pinchange(object source, SerialPinChangedEventArgs e)
		{
			string str = e.EventType.ToString();
			int a = (int)e.EventType;
			Interaction.MsgBox(" Pinchange", MsgBoxStyle.OkOnly, null);
			checked
			{
				this.STATIC_pinchange_20211C1239_räkna++;
				this.mMeddelande = " Pin Change ";
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0002B460 File Offset: 0x00029860
		private void Serieerror(object source, SerialErrorReceivedEventArgs e)
		{
			checked
			{
				this.STATIC_Serieerror_20211C123D_räkna++;
				Interaction.MsgBox(" Serie error", MsgBoxStyle.OkOnly, null);
				this.mMeddelande = " Serie error" + e.ToString();
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0002B494 File Offset: 0x00029894
		private void TeckenAnlänt(object source, SerialDataReceivedEventArgs e)
		{
			string value = "\u0011";
			string NästaSändSträng = "";
			string rValue;
			try
			{
				rValue = this.mAnvändPort.ReadTo(value);
			}
			catch (Exception ex)
			{
				return;
			}
			int Antal = Strings.Len(rValue);
			checked
			{
				this.STATIC_TeckenAnlänt_20211C1241_AntalChar += Antal;
				this.mAntalTkn += Antal;
				if (Strings.InStr(rValue, "ACCESS", CompareMethod.Binary) != 0)
				{
					this.mMottagsFelRäknare++;
					this.ReStartaCom();
					return;
				}
				if (Strings.InStr(rValue, "FESTO", CompareMethod.Binary) != 0)
				{
					this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
					int PosF = 1;
					if (Operators.CompareString(Strings.Mid(rValue, 1, 1), "F", false) != 0)
					{
						int num = 1;
						int num2 = Strings.Len(rValue);
						for (int i = num; i <= num2; i++)
						{
							if (Operators.CompareString(Strings.Mid(rValue, i, 1), "F", false) == 0)
							{
								PosF = i;
							}
						}
					}
					if (PosF < Strings.Len(rValue) - 2)
					{
						this.mKontrollerVersion = Strings.Mid(rValue, PosF, Strings.Len(rValue) - 2 - PosF);
					}
					else
					{
						this.mKontrollerVersion = "?";
					}
					this.mComRestarts++;
					if (this.mSettingsÄrUppdat)
					{
						NästaSändSträng = "DMW9971,MW9972,MW9973,MW9974";
					}
					else
					{
						NästaSändSträng = "DMW9920,MW9921,MW9922,MW9923";
					}
				}
				if (Strings.InStr(rValue, "MMW", CompareMethod.Binary) != 0)
				{
					bool sattProg = false;
					if (Strings.InStr(rValue, "MMW9952=1", CompareMethod.Binary) != 0)
					{
						this.mIPCnolla = false;
						sattProg = true;
					}
					if (Strings.InStr(rValue, "MMW9953=1", CompareMethod.Binary) != 0)
					{
						this.mIPCpelStart = false;
						sattProg = true;
					}
					if (Strings.InStr(rValue, "MMW9954=1", CompareMethod.Binary) != 0)
					{
						this.mIPCpelStopp = false;
						sattProg = true;
					}
					if (sattProg)
					{
						NästaSändSträng = "DMW9971,MW9972,MW9973,MW9974";
					}
				}
				string[] strVärden = new string[5];
				int[] intPosÄr = new int[5];
				if (Strings.InStr(rValue, "DMW", CompareMethod.Binary) != 0)
				{
					int num3 = 1;
					int num4 = Strings.Len(rValue);
					int j;
					int k = 0;
					for (j = num3; j <= num4; j++)
					{
						if (Operators.CompareString(Strings.Mid(rValue, j, 1), "=", false) == 0)
						{
							intPosÄr[k] = j;
							k++;
						}
					}
					if (k != 4)
					{
						this.mMottagsFelRäknare++;
						NästaSändSträng = "DMW9971,MW9972,MW9973,MW9974";
						return;
					}
					intPosÄr[k] = Strings.Len(rValue) - 2;
					j = 0;
					do
					{
						strVärden[j] = Strings.Mid(rValue, intPosÄr[j] + 1, intPosÄr[j + 1] - intPosÄr[j] - 1);
						j++;
					}
					while (j <= 3);
					Monitor.Enter(this.STATIC_TeckenAnlänt_20211C1241_Mottaget_Init);
					try
					{
						if (this.STATIC_TeckenAnlänt_20211C1241_Mottaget_Init.State == 0)
						{
							this.STATIC_TeckenAnlänt_20211C1241_Mottaget_Init.State = 2;
							this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 0;
						}
						else if (this.STATIC_TeckenAnlänt_20211C1241_Mottaget_Init.State == 2)
						{
							throw new IncompleteInitialization();
						}
					}
					finally
					{
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget_Init.State = 1;
						Monitor.Exit(this.STATIC_TeckenAnlänt_20211C1241_Mottaget_Init);
					}
					if (Strings.InStr(rValue, "DMW9971", CompareMethod.Binary) > 0)
					{
						this.mMätDjup = strVärden[0];
						this.mMätViktAl = strVärden[1];
						this.mMätViktAh = strVärden[2];
						this.mMätViktBl = strVärden[3];
						if (this.mComÄrUppDat)
						{
							if (Conversions.ToInteger(this.mMätViktAh) == 0)
							{
								this.mMätViktAhg = Conversions.ToInteger(this.mMätViktAl);
							}
							if (Conversions.ToInteger(this.mMätViktAh) == 1)
							{
								this.mMätViktAhg = 65535 - Conversions.ToInteger(this.mMätViktAl);
							}
							if (Conversions.ToInteger(this.mMätViktAh) == 2)
							{
								this.mMätViktAhg = 65535 + Conversions.ToInteger(this.mMätViktAl);
							}
							if (Conversions.ToInteger(this.mMätViktBh) == 0)
							{
								this.mMätViktBhg = Conversions.ToInteger(this.mMätViktBl);
							}
							if (Conversions.ToInteger(this.mMätViktBh) == 1)
							{
								this.mMätViktBhg = 65535 - Conversions.ToInteger(this.mMätViktBl);
							}
							if (Conversions.ToInteger(this.mMätViktBh) == 2)
							{
								this.mMätViktBhg = 65535 + Conversions.ToInteger(this.mMätViktBl);
							}
						}
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = true;
					}
					if (Strings.InStr(rValue, "DMW9975", CompareMethod.Binary) > 0)
					{
						this.mMätViktBh = strVärden[0];
						this.mMätVarvBorr = strVärden[1];
						this.mMätVarvCellA = strVärden[2];
						this.mMätVarvCellB = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 1;
					}
					if (Strings.InStr(rValue, "DMW9979", CompareMethod.Binary) > 0)
					{
						this.mMätTempLuftA = strVärden[0];
						this.mMätTempLuftB = strVärden[1];
						this.mMätTempKompr = strVärden[2];
						this.mMätFelkodA = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 2;
					}
					if (Strings.InStr(rValue, "DMW9983", CompareMethod.Binary) > 0)
					{
						this.mMätFelkodB = strVärden[0];
						this.mMätInstaller = strVärden[1];
						this.mMätCarrier = strVärden[2];
						this.mMätLuftVstatus = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 3;
					}
					if (Strings.InStr(rValue, "DMW9987", CompareMethod.Binary) > 0)
					{
						this.mMätLuftFukt = strVärden[0];
						this.mMätPotCellA = strVärden[1];
						this.mMätPotCellB = strVärden[2];
						this.mMätUtUNer = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 4;
					}
					if (Strings.InStr(rValue, "DMW9991", CompareMethod.Binary) > 0)
					{
						this.mMätUtRot = strVärden[0];
						this.mMätUtCellA = strVärden[1];
						this.mMätUtCellB = strVärden[2];
						this.mMätStatusBitar = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 5;
					}
					if (Strings.InStr(rValue, "DMW9995", CompareMethod.Binary) > 0)
					{
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 6;
					}
					if (Strings.InStr(rValue, "DMW9967", CompareMethod.Binary) > 0)
					{
						this.mMätTsvivel = strVärden[0];
						this.mMätTslang = strVärden[1];
						this.mMätTtankA = strVärden[2];
						this.mMätTtankB = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
						if (!this.mComÄrUppDat)
						{
							this.mComÄrUppDat = true;
						}
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 7;
					}
					if (Strings.InStr(rValue, "DMW9920", CompareMethod.Binary) > 0)
					{
						this.mAutoMinUpp = strVärden[0];
						this.mAutoMaxUpp = strVärden[1];
						this.mAutoAntalMedelH = strVärden[2];
						this.mAutoEgenUpp = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = true;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 8;
					}
					if (Strings.InStr(rValue, "DMW9924", CompareMethod.Binary) > 0)
					{
						this.mAutoRegFakt = strVärden[0];
						this.mVågKomAvstängd = strVärden[1];
						this.mStigTopp = strVärden[2];
						this.mStigBott = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = true;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 9;
					}
					if (Strings.InStr(rValue, "DMW9936", CompareMethod.Binary) > 0)
					{
						this.mPelEkgTopp = strVärden[0];
						this.mPelEmmTopp = strVärden[1];
						this.mPelEkgBott = strVärden[2];
						this.mPelEmmBott = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = true;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 10;
					}
					if (Strings.InStr(rValue, "DMW9940", CompareMethod.Binary) > 0)
					{
						this.mPelRotBegräns = strVärden[0];
						this.mPelUtmatDiff = strVärden[1];
						this.mPelJoyUNBegräns = strVärden[2];
						this.mPelJoyRotBegräns = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = true;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 11;
					}
					if (Strings.InStr(rValue, "DMW9944", CompareMethod.Binary) > 0)
					{
						this.mPelStoppDjup = strVärden[0];
						this.mPelTeoHg = strVärden[1];
						this.mPelFrånTankA = strVärden[2];
						this.mPelStigning = strVärden[3];
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = true;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 12;
					}
					if (Strings.InStr(rValue, "DMW9948", CompareMethod.Binary) > 0)
					{
						if (Operators.CompareString(strVärden[0], "1", false) == 0)
						{
							this.mPelVillMaxStig = true;
						}
						else
						{
							this.mPelVillMaxStig = false;
						}
						if (Operators.CompareString(strVärden[1], "1", false) == 0)
						{
							this.mPelVillCellAuto = true;
						}
						else
						{
							this.mPelVillCellAuto = false;
						}
						this.mPelVillRotBorr = strVärden[2];
						if (Operators.CompareString(strVärden[3], "1", false) == 0)
						{
							this.mPelVillPelStartMupp = true;
						}
						else
						{
							this.mPelVillPelStartMupp = false;
						}
						this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått = false;
						this.mSettingsÄrUppdat = true;
						this.STATIC_TeckenAnlänt_20211C1241_Mottaget = 0;
					}
					if (!this.STATIC_TeckenAnlänt_20211C1241_ViktDjupFått)
					{
						NästaSändSträng = "DMW9971,MW9972,MW9973,MW9974";
						this.mDjupViktLäst++;
					}
					else
					{
						switch (this.STATIC_TeckenAnlänt_20211C1241_Mottaget)
						{
						case 0:
							NästaSändSträng = "DMW9975,MW9976,MW9977,MW9978";
							break;
						case 1:
							NästaSändSträng = "DMW9979,MW9980,MW9981,MW9982";
							break;
						case 2:
							NästaSändSträng = "DMW9983,MW9984,MW9985,MW9986";
							break;
						case 3:
							NästaSändSträng = "DMW9987,MW9988,MW9989,MW9990";
							break;
						case 4:
							NästaSändSträng = "DMW9991,MW9992,MW9993,MW9994";
							break;
						case 5:
							NästaSändSträng = "DMW9995,MW9996,MW9997,MW9998";
							break;
						case 6:
							NästaSändSträng = "DMW9967,MW9968,MW9969,MW9970";
							break;
						case 7:
							NästaSändSträng = "DMW9975,MW9976,MW9977,MW9978";
							this.mMätRegLäst++;
							break;
						case 8:
							NästaSändSträng = "DMW9924,MW9925,MW9926,MW9927";
							break;
						case 9:
							NästaSändSträng = "DMW9936,MW9937,MW9938,MW9939";
							break;
						case 10:
							NästaSändSträng = "DMW9940,MW9941,MW9942,MW9943";
							break;
						case 11:
							NästaSändSträng = "DMW9944,MW9945,MW9946,MW9947";
							break;
						case 12:
							NästaSändSträng = "DMW9948,MW9949,MW9950,MW9951";
							break;
						}
					}
				}
				this.STATIC_TeckenAnlänt_20211C1241_SparadSändSträng = NästaSändSträng;
				if (this.mVillÄndraiSettings)
				{
					if (Operators.CompareString(this.ÄndrarSettings(rValue), "Tom", false) == 0)
					{
						this.mVillÄndraiSettings = false;
						NästaSändSträng = "DMW9971,MW9972,MW9973,MW9974";
					}
					else
					{
						NästaSändSträng = this.ÄndrarSettings(rValue);
						this.STATIC_TeckenAnlänt_20211C1241_SparadSändSträng = NästaSändSträng;
					}
				}
				if (this.mIPCnolla)
				{
					NästaSändSträng = "MMW9952=1";
				}
				if (this.mIPCpelStart)
				{
					NästaSändSträng = "MMW9953=1";
				}
				if (this.mIPCpelStopp)
				{
					NästaSändSträng = "MMW9954=1";
				}
				this.SändRad(NästaSändSträng);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0002BDC0 File Offset: 0x0002A1C0
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0002BDD8 File Offset: 0x0002A1D8
		public FormSettings SättingsForm
		{
			get
			{
				return this.mFormSättings;
			}
			set
			{
				this.mFormSättings = value;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0002BDE4 File Offset: 0x0002A1E4
		private string ÄndrarSettings(string sistaMottaget)
		{
			string Sträng = "Tom";
			if (!this.mVillÄndraiSettings)
			{
				return Sträng;
			}
			if (Strings.InStr(sistaMottaget, "MMW", CompareMethod.Binary) != 0)
			{
				string Värdet = Strings.Mid(sistaMottaget, 9, checked(Strings.Len(sistaMottaget) - 9));
				if (Strings.InStr(sistaMottaget, "MMW9945", CompareMethod.Binary) != 0)
				{
					this.mPelTeoHg = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9944", CompareMethod.Binary) != 0)
				{
					this.mPelStoppDjup = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9936", CompareMethod.Binary) != 0)
				{
					this.mPelEkgTopp = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9937", CompareMethod.Binary) != 0)
				{
					this.mPelEmmTopp = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9938", CompareMethod.Binary) != 0)
				{
					this.mPelEkgBott = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9939", CompareMethod.Binary) != 0)
				{
					this.mPelEmmBott = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9942", CompareMethod.Binary) != 0)
				{
					this.mPelJoyUNBegräns = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9943", CompareMethod.Binary) != 0)
				{
					this.mPelJoyRotBegräns = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9946", CompareMethod.Binary) != 0)
				{
					this.mPelFrånTankA = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9947", CompareMethod.Binary) != 0)
				{
					this.mPelStigning = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9940", CompareMethod.Binary) != 0)
				{
					this.mPelRotBegräns = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9950", CompareMethod.Binary) != 0)
				{
					this.mPelVillRotBorr = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9920", CompareMethod.Binary) != 0)
				{
					this.mAutoMinUpp = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9921", CompareMethod.Binary) != 0)
				{
					this.mAutoMaxUpp = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9922", CompareMethod.Binary) != 0)
				{
					this.mAutoAntalMedelH = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9923", CompareMethod.Binary) != 0)
				{
					this.mAutoEgenUpp = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9924", CompareMethod.Binary) != 0)
				{
					this.mAutoRegFakt = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9925", CompareMethod.Binary) != 0)
				{
					this.mVågKomAvstängd = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9926", CompareMethod.Binary) != 0)
				{
					this.mStigTopp = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9927", CompareMethod.Binary) != 0)
				{
					this.mStigBott = Värdet;
				}
				if (Strings.InStr(sistaMottaget, "MMW9948=1", CompareMethod.Binary) != 0)
				{
					this.mPelVillMaxStig = true;
				}
				if (Strings.InStr(sistaMottaget, "MMW9948=0", CompareMethod.Binary) != 0)
				{
					this.mPelVillMaxStig = false;
				}
				if (Strings.InStr(sistaMottaget, "MMW9949=1", CompareMethod.Binary) != 0)
				{
					this.mPelVillCellAuto = true;
				}
				if (Strings.InStr(sistaMottaget, "MMW9949=0", CompareMethod.Binary) != 0)
				{
					this.mPelVillCellAuto = false;
				}
				if (Strings.InStr(sistaMottaget, "MMW9951=1", CompareMethod.Binary) != 0)
				{
					this.mPelVillPelStartMupp = true;
				}
				if (Strings.InStr(sistaMottaget, "MMW9951=0", CompareMethod.Binary) != 0)
				{
					this.mPelVillPelStartMupp = false;
				}
			}
			FormSettings formSettings = this.mFormSättings;
			if (!this.TestarLika(formSettings.NUpBinder.Value, new decimal((double)Conversions.ToInteger(this.mPelTeoHg) / 10.0)))
			{
				Sträng = "MMW9945=" + Conversions.ToString(Convert.ToInt32(decimal.Multiply(formSettings.NUpBinder.Value, 10m)));
			}
			if (!this.TestarLika(formSettings.NUpAutoStop.Value, new decimal((double)Conversions.ToInteger(this.mPelStoppDjup) / 1000.0)))
			{
				Sträng = "MMW9944=" + Conversions.ToString(Convert.ToInt32(decimal.Multiply(formSettings.NUpAutoStop.Value, 1000m)));
			}
			if (!this.TestarLika(formSettings.NUpBinderTop.Value, new decimal((double)Conversions.ToInteger(this.mPelEkgTopp) / 10.0)))
			{
				Sträng = "MMW9936=" + Conversions.ToString(Convert.ToInt32(decimal.Multiply(formSettings.NUpBinderTop.Value, 10m)));
			}
			if (!this.TestarLika(formSettings.NUpTopDjup.Value, new decimal((double)Conversions.ToInteger(this.mPelEmmTopp) / 1000.0)))
			{
				Sträng = "MMW9937=" + Conversions.ToString(Convert.ToInt32(decimal.Multiply(formSettings.NUpTopDjup.Value, 1000m)));
			}
			if (!this.TestarLika(formSettings.NUpBinderBott.Value, new decimal((double)Conversions.ToInteger(this.mPelEkgBott) / 10.0)))
			{
				Sträng = "MMW9938=" + Conversions.ToString(Convert.ToInt32(decimal.Multiply(formSettings.NUpBinderBott.Value, 10m)));
			}
			if (!this.TestarLika(formSettings.NUpBottDjup.Value, new decimal((double)Conversions.ToInteger(this.mPelEmmBott) / 1000.0)))
			{
				Sträng = "MMW9939=" + Conversions.ToString(Convert.ToInt32(decimal.Multiply(formSettings.NUpBottDjup.Value, 1000m)));
			}
			if (!this.TestarLika(formSettings.NUpJoyUppNer.Value, new decimal(Conversions.ToInteger(this.mPelJoyUNBegräns))))
			{
				Sträng = "MMW9942=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpJoyUppNer.Value));
			}
			if (!this.TestarLika(formSettings.NUpJoyRot.Value, new decimal(Conversions.ToInteger(this.mPelJoyRotBegräns))))
			{
				Sträng = "MMW9943=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpJoyRot.Value));
			}
			if (!this.TestarLika(formSettings.NUpMixFrånA.Value, new decimal(Conversions.ToInteger(this.mPelFrånTankA))))
			{
				Sträng = "MMW9946=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpMixFrånA.Value));
			}
			if (!this.TestarLika(formSettings.NUpStigning.Value, new decimal(Conversions.ToInteger(this.mPelStigning))))
			{
				Sträng = "MMW9947=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpStigning.Value));
			}
			if (!this.TestarLika(formSettings.NUpRotMaxPelTillV.Value, new decimal(Conversions.ToInteger(this.mPelRotBegräns))))
			{
				Sträng = "MMW9940=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpRotMaxPelTillV.Value));
			}
			if (!this.TestarLika(formSettings.NUpÖnskadRotDrill.Value, new decimal(Conversions.ToInteger(this.mPelVillRotBorr))))
			{
				Sträng = "MMW9950=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpÖnskadRotDrill.Value));
			}
			if (!this.TestarLika(formSettings.NUpMinUppBits.Value, new decimal(Conversions.ToInteger(this.mAutoMinUpp))))
			{
				Sträng = "MMW9920=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpMinUppBits.Value));
			}
			if (!this.TestarLika(formSettings.NUpMaxUppBits.Value, new decimal(Conversions.ToInteger(this.mAutoMaxUpp))))
			{
				Sträng = "MMW9921=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpMaxUppBits.Value));
			}
			if (!this.TestarLika(formSettings.NUpAntalStartV.Value, new decimal(Conversions.ToInteger(this.mAutoAntalMedelH))))
			{
				Sträng = "MMW9922=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpAntalStartV.Value));
			}
			if (!this.TestarLika(formSettings.NUpEgetStartV.Value, new decimal(Conversions.ToInteger(this.mAutoEgenUpp))))
			{
				Sträng = "MMW9923=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpEgetStartV.Value));
			}
			if (!this.TestarLika(formSettings.NUpRegFaktor.Value, new decimal(Conversions.ToInteger(this.mAutoRegFakt))))
			{
				Sträng = "MMW9924=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpRegFaktor.Value));
			}
			if (formSettings.CheckCellAuto.Checked != this.mPelVillCellAuto)
			{
				if (formSettings.CheckCellAuto.Checked)
				{
					Sträng = "MMW9949=1";
				}
				else
				{
					Sträng = "MMW9949=0";
				}
			}
			if (formSettings.CheckStartUpMedel.Checked != this.mPelVillPelStartMupp)
			{
				if (formSettings.CheckStartUpMedel.Checked)
				{
					Sträng = "MMW9951=1";
				}
				else
				{
					Sträng = "MMW9951=0";
				}
			}
			if (formSettings.CheckMaxUpSpeed.Checked != this.mPelVillMaxStig)
			{
				if (formSettings.CheckMaxUpSpeed.Checked)
				{
					Sträng = "MMW9948=1";
				}
				else
				{
					Sträng = "MMW9948=0";
				}
			}
			if ((formSettings.CheckTankAoff.Checked & !formSettings.CheckTankBoff.Checked) && Conversions.ToInteger(this.mVågKomAvstängd) != 1)
			{
				Sträng = "MMW9925=1";
			}
			if ((!formSettings.CheckTankAoff.Checked & formSettings.CheckTankBoff.Checked) && Conversions.ToInteger(this.mVågKomAvstängd) != 2)
			{
				Sträng = "MMW9925=2";
			}
			if ((formSettings.CheckTankAoff.Checked & formSettings.CheckTankBoff.Checked) && Conversions.ToInteger(this.mVågKomAvstängd) != 3)
			{
				Sträng = "MMW9925=3";
			}
			if ((!formSettings.CheckTankAoff.Checked & !formSettings.CheckTankBoff.Checked) && Conversions.ToInteger(this.mVågKomAvstängd) != 0)
			{
				Sträng = "MMW9925=0";
			}
			if (!this.TestarLika(formSettings.NUpStigTopp.Value, new decimal(Conversions.ToInteger(this.mStigTopp))))
			{
				Sträng = "MMW9926=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpStigTopp.Value));
			}
			if (!this.TestarLika(formSettings.NUpStigBotten.Value, new decimal(Conversions.ToInteger(this.mStigBott))))
			{
				Sträng = "MMW9927=" + Conversions.ToString(Convert.ToInt32(formSettings.NUpStigBotten.Value));
			}
			return Sträng;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0002C780 File Offset: 0x0002AB80
		private bool TestarLika(decimal Dec1, decimal Dec2)
		{
			object str = Conversions.ToString(Dec1);
			object str2 = Conversions.ToString(Dec2);
			return decimal.Compare(Dec1, Dec2) == 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0002C7AC File Offset: 0x0002ABAC
		public void ReStartaCom()
		{
			string StartTkn = "\u0014";
			string str = "Tom";
			if (!this.mAnvändPort.IsOpen)
			{
				this.mAnvändPort.Open();
			}
			checked
			{
				this.mComRestarts++;
				this.mAnvändPort.DiscardInBuffer();
				this.mAnvändPort.DiscardOutBuffer();
				this.mMeddelande = str;
				this.SändRad(StartTkn);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0002C810 File Offset: 0x0002AC10
		private bool SändRad(string Rad)
		{
			if (this.mAnvändPort.IsOpen)
			{
				this.mAnvändPort.WriteLine(Rad);
			}
			bool SändRad = false;
			return SändRad;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0002C838 File Offset: 0x0002AC38
		~FestoCom()
		{
			this.mAnvändPort.Close();
			this.mAnvändPort.Dispose();
			//base.Finalize();
		}

		// Token: 0x04000080 RID: 128
		private string mVersionOfFestoCom;

		// Token: 0x04000081 RID: 129
		private string mKontrollerVersion;

		// Token: 0x04000082 RID: 130
		private string mAutoMinUpp;

		// Token: 0x04000083 RID: 131
		private string mAutoMaxUpp;

		// Token: 0x04000084 RID: 132
		private string mAutoAntalMedelH;

		// Token: 0x04000085 RID: 133
		private string mAutoEgenUpp;

		// Token: 0x04000086 RID: 134
		private string mAutoRegFakt;

		// Token: 0x04000087 RID: 135
		private string mVågKomAvstängd;

		// Token: 0x04000088 RID: 136
		private string mStigTopp;

		// Token: 0x04000089 RID: 137
		private string mStigBott;

		// Token: 0x0400008A RID: 138
		private string mPelEkgTopp;

		// Token: 0x0400008B RID: 139
		private string mPelEmmTopp;

		// Token: 0x0400008C RID: 140
		private string mPelEkgBott;

		// Token: 0x0400008D RID: 141
		private string mPelEmmBott;

		// Token: 0x0400008E RID: 142
		private string mPelRotBegräns;

		// Token: 0x0400008F RID: 143
		private string mPelUtmatDiff;

		// Token: 0x04000090 RID: 144
		private string mPelJoyUNBegräns;

		// Token: 0x04000091 RID: 145
		private string mPelJoyRotBegräns;

		// Token: 0x04000092 RID: 146
		private string mPelStoppDjup;

		// Token: 0x04000093 RID: 147
		private string mPelTeoHg;

		// Token: 0x04000094 RID: 148
		private string mPelFrånTankA;

		// Token: 0x04000095 RID: 149
		private string mPelStigning;

		// Token: 0x04000096 RID: 150
		private bool mPelVillMaxStig;

		// Token: 0x04000097 RID: 151
		private bool mPelVillCellAuto;

		// Token: 0x04000098 RID: 152
		private string mPelVillRotBorr;

		// Token: 0x04000099 RID: 153
		private bool mPelVillPelStartMupp;

		// Token: 0x0400009A RID: 154
		private bool mIPCnolla;

		// Token: 0x0400009B RID: 155
		private bool mIPCpelStart;

		// Token: 0x0400009C RID: 156
		private bool mIPCpelStopp;

		// Token: 0x0400009D RID: 157
		private string mMätTsvivel;

		// Token: 0x0400009E RID: 158
		private string mMätTslang;

		// Token: 0x0400009F RID: 159
		private string mMätTtankA;

		// Token: 0x040000A0 RID: 160
		private string mMätTtankB;

		// Token: 0x040000A1 RID: 161
		private string mMätDjup;

		// Token: 0x040000A2 RID: 162
		private string mMätViktAl;

		// Token: 0x040000A3 RID: 163
		private string mMätViktAh;

		// Token: 0x040000A4 RID: 164
		private string mMätViktBl;

		// Token: 0x040000A5 RID: 165
		private string mMätViktBh;

		// Token: 0x040000A6 RID: 166
		private int mMätViktAhg;

		// Token: 0x040000A7 RID: 167
		private int mMätViktBhg;

		// Token: 0x040000A8 RID: 168
		private string mMätVarvBorr;

		// Token: 0x040000A9 RID: 169
		private string mMätVarvCellA;

		// Token: 0x040000AA RID: 170
		private string mMätVarvCellB;

		// Token: 0x040000AB RID: 171
		private string mMätTempLuftA;

		// Token: 0x040000AC RID: 172
		private string mMätTempLuftB;

		// Token: 0x040000AD RID: 173
		private string mMätTempKompr;

		// Token: 0x040000AE RID: 174
		private string mMätFelkodA;

		// Token: 0x040000AF RID: 175
		private string mMätFelkodB;

		// Token: 0x040000B0 RID: 176
		private string mMätInstaller;

		// Token: 0x040000B1 RID: 177
		private string mMätCarrier;

		// Token: 0x040000B2 RID: 178
		private string mMätLuftVstatus;

		// Token: 0x040000B3 RID: 179
		private string mMätLuftFukt;

		// Token: 0x040000B4 RID: 180
		private string mMätPotCellA;

		// Token: 0x040000B5 RID: 181
		private string mMätPotCellB;

		// Token: 0x040000B6 RID: 182
		private string mMätUtUNer;

		// Token: 0x040000B7 RID: 183
		private string mMätUtRot;

		// Token: 0x040000B8 RID: 184
		private string mMätUtCellA;

		// Token: 0x040000B9 RID: 185
		private string mMätUtCellB;

		// Token: 0x040000BA RID: 186
		private string mMätStatusBitar;

		// Token: 0x040000BB RID: 187
		private bool mSettingsÄrUppdat;

		// Token: 0x040000BC RID: 188
		private bool mVillÄndraiSettings;

		// Token: 0x040000BD RID: 189
		private bool mComÄrUppDat;

		// Token: 0x040000BE RID: 190
		private int mAntalTkn;

		// Token: 0x040000BF RID: 191
		[AccessedThroughProperty("mAnvändPort")]
		private SerialPort _mAnvändPort;

		// Token: 0x040000C0 RID: 192
		private System.Timers.Timer KntrSeriePort;

		// Token: 0x040000C1 RID: 193
		private string mSeriePort;

		// Token: 0x040000C2 RID: 194
		private int mMottagsFelRäknare;

		// Token: 0x040000C3 RID: 195
		private int mDjupViktLäst;

		// Token: 0x040000C4 RID: 196
		private int mMätRegLäst;

		// Token: 0x040000C5 RID: 197
		private int mSekunder;

		// Token: 0x040000C6 RID: 198
		private int mComRestarts;

		// Token: 0x040000C7 RID: 199
		private int mViktDjupPerSek;

		// Token: 0x040000C8 RID: 200
		private long mVäntar;

		// Token: 0x040000C9 RID: 201
		private string mMeddelande;

		// Token: 0x040000CA RID: 202
		private bool mSäntStartTkn;

		// Token: 0x040000CB RID: 203
		private FormSettings mFormSättings;

		// Token: 0x040000CC RID: 204
		private int STATIC_TeckenAnlänt_20211C1241_AntalChar;

		// Token: 0x040000CD RID: 205
		private bool STATIC_TeckenAnlänt_20211C1241_ViktDjupFått;

		// Token: 0x040000CE RID: 206
		private string STATIC_TeckenAnlänt_20211C1241_SparadSändSträng;

		// Token: 0x040000CF RID: 207
		private int STATIC_pinchange_20211C1239_räkna;

		// Token: 0x040000D0 RID: 208
		private int STATIC_Serieerror_20211C123D_räkna;

		// Token: 0x040000D1 RID: 209
		private int STATIC_TeckenAnlänt_20211C1241_Mottaget;

		// Token: 0x040000D2 RID: 210
		private StaticLocalInitFlag STATIC_TeckenAnlänt_20211C1241_Mottaget_Init;
	}
}
