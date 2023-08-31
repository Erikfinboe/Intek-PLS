using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace winKCdrill2
{
	// Token: 0x0200001A RID: 26
	public class RitaTank
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x00030360 File Offset: 0x0002E760
		public RitaTank()
		{
			this.txtBox = new TextBox();
			this.mTemp = 0f;
			this.mTankNamn = "A";
			this.mCellm = new Cellmatare();
			this.PicCell = new PictureBox();
			this.TxtCell = new Label();
			this.PicRörUtCm = new PictureBox();
			this.RörUtCm = new RitaRörH();
			this.PicRörIn1 = new PictureBox();
			this.RörInC1 = new RitaRörH();
			this.PicRörIn2 = new PictureBox();
			this.RörInUpp = new RitaKrökÖH();
			this.PicRörIn3 = new PictureBox();
			this.RörInVert = new RitaRörV();
			this.PicRörIn4 = new PictureBox();
			this.RörInSKrök = new RitaKrökUH();
			this.PicValvUt = new PictureBox();
			this.PicAvluft = new PictureBox();
			this.RörAvluft = new RitaRörH();
			this.TipUtValv = new ToolTip();
			this.BindUtValve = new Ventil();
			this.PicAvluftValv = new PictureBox();
			this.TipAvluftValv = new ToolTip();
			this.AvluftValv = new Ventil();
			this.PicRörInS1 = new PictureBox();
			this.RörInStor1 = new RitaRörH();
			this.PicRörInS2 = new PictureBox();
			this.RörInStor2 = new RitaKrökUH();
			this.PicRörInS3 = new PictureBox();
			this.RörInStor3 = new RitaRörV();
			this.PicRörInS4 = new PictureBox();
			this.RörInStor4 = new RitaKrökÖV();
			this.PicRörInS5 = new PictureBox();
			this.RörInStor5 = new RitaRörH();
			this.PicBindInValv = new PictureBox();
			this.TipBindInValv = new ToolTip();
			this.BindInValv = new Ventil();
			this.PicRörUtS1 = new PictureBox();
			this.RörUtStor1 = new RitaRörH();
			this.PicRörUtS2 = new PictureBox();
			this.RörUtStor2 = new RitaKrökUH();
			this.PicRörUtS3 = new PictureBox();
			this.RörUtStor3 = new RitaRörV();
			this.PicRörUtS4 = new PictureBox();
			this.RörUtStor4 = new RitaKrökÖV();
			this.PicRörUtS5 = new PictureBox();
			this.RörUtStor5 = new RitaRörH();
			this.PicBindUtValv = new PictureBox();
			this.TipBindUtValv = new ToolTip();
			this.BindUtValv = new Ventil();
			this.PicLuftIn1 = new PictureBox();
			this.PicLuftIn2 = new PictureBox();
			this.PicLuftIn3 = new PictureBox();
			this.PicLuftIn4 = new PictureBox();
			this.LuftRör1 = new RitaRörV();
			this.LuftRör2 = new RitaKrökUH();
			this.LuftRör3 = new RitaRörH();
			this.LuftRör4 = new RitaKrökÖV();
			this.mMaxVikt = 4000;
			this.mRörVliten = 8;
			this.mRörVStor = 15;
			this.mValvUtNamn = "V 201A";
			this.mValvAvluftNamn = "V 204A";
			this.ValvInBindNamn = "HV 14";
			this.mValvUtBindNamn = "HV 15";
			this.mAktiv = true;
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00030640 File Offset: 0x0002EA40
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00030658 File Offset: 0x0002EA58
		public float Temp
		{
			get
			{
				return this.mTemp;
			}
			set
			{
				this.mTemp = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00030664 File Offset: 0x0002EA64
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x0003067C File Offset: 0x0002EA7C
		public string TankNamn
		{
			get
			{
				return this.mTankNamn;
			}
			set
			{
				this.mTankNamn = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00030688 File Offset: 0x0002EA88
		// (set) Token: 0x060003CB RID: 971 RVA: 0x000306A0 File Offset: 0x0002EAA0
		public string ValvUtBindNamn
		{
			get
			{
				return this.mValvUtBindNamn;
			}
			set
			{
				this.mValvUtBindNamn = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060003CC RID: 972 RVA: 0x000306AC File Offset: 0x0002EAAC
		// (set) Token: 0x060003CD RID: 973 RVA: 0x000306C4 File Offset: 0x0002EAC4
		public string ValvUtNamn
		{
			get
			{
				return this.mValvUtNamn;
			}
			set
			{
				this.mValvUtNamn = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000306D0 File Offset: 0x0002EAD0
		// (set) Token: 0x060003CF RID: 975 RVA: 0x000306E8 File Offset: 0x0002EAE8
		public string ValvAvluftNamn
		{
			get
			{
				return this.mValvAvluftNamn;
			}
			set
			{
				this.mValvAvluftNamn = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x000306F4 File Offset: 0x0002EAF4
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0003070C File Offset: 0x0002EB0C
		public string ValvInBindNamn
		{
			get
			{
				return this.mValvInBindNamn;
			}
			set
			{
				this.mValvInBindNamn = value;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00030718 File Offset: 0x0002EB18
		public void BinderInValve(bool UtOpen, bool UtClose)
		{
			if (!this.mInitierad)
			{
				return;
			}
			this.BindInValv.Lägen(UtOpen, UtClose);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00030730 File Offset: 0x0002EB30
		public void MaterialUtValve(bool UtOpen, bool UtClose)
		{
			if (!this.mInitierad)
			{
				return;
			}
			this.BindUtValve.Lägen(UtOpen, UtClose);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00030748 File Offset: 0x0002EB48
		public void MaterialUtValv(bool UtOpen, bool UtClose)
		{
			if (!this.mInitierad)
			{
				return;
			}
			this.BindUtValv.Lägen(UtOpen, UtClose);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00030760 File Offset: 0x0002EB60
		public void AvluftValve(bool Utopen, bool Utclose)
		{
			if (!this.mInitierad)
			{
				return;
			}
			this.AvluftValv.Lägen(Utopen, Utclose);
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00030778 File Offset: 0x0002EB78
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00030790 File Offset: 0x0002EB90
		public int RörVLiten
		{
			get
			{
				return this.mRörVliten;
			}
			set
			{
				this.mRörVliten = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0003079C File Offset: 0x0002EB9C
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000307B4 File Offset: 0x0002EBB4
		public int RörVStor
		{
			get
			{
				return this.mRörVStor;
			}
			set
			{
				this.mRörVStor = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000307C0 File Offset: 0x0002EBC0
		// (set) Token: 0x060003DB RID: 987 RVA: 0x000307D8 File Offset: 0x0002EBD8
		public float CellFart
		{
			get
			{
				return this.mCellFart;
			}
			set
			{
				this.mCellFart = value;
				this.mCellm.CellFart = this.mCellFart;
				this.TxtCell.Text = Strings.Format(this.mCellFart, "#0") + " rpm";
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00030828 File Offset: 0x0002EC28
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00030840 File Offset: 0x0002EC40
		public PictureBox Picbox
		{
			get
			{
				return this.mPicBox;
			}
			set
			{
				this.mInitierad = true;
				this.mPicBox = value;
				this.mPicBox.BorderStyle = BorderStyle.None;
				int ProcBredd = 70;
				int ProcHöjd = 85;
				checked
				{
					int mBreddHalva = (int)Math.Round((double)(100 - ProcBredd) / 2.0);
					this.mHöjd = (int)Math.Round((double)(this.mPicBox.Height * ProcHöjd) / 100.0);
					this.mBredd = (int)Math.Round((double)(this.mPicBox.Width * ProcBredd) / 100.0);
					this.mVänsterSida = (int)Math.Round((double)(this.mPicBox.Width * mBreddHalva) / 100.0);
					this.PicCell.Width = (int)Math.Round((double)this.mPicBox.Width / 3.0);
					this.PicCell.Top = this.mHöjd;
					this.PicCell.Height = this.mPicBox.Height - this.mHöjd;
					this.PicCell.Left = (int)Math.Round(unchecked((double)this.mPicBox.Width / 2.0 - (double)this.PicCell.Width / 2.0));
					this.PicCell.BorderStyle = BorderStyle.None;
					this.PicCell.BringToFront();
					this.mPicBox.Controls.Add(this.PicCell);
					this.mCellm.PicBox = this.PicCell;
					this.TxtCell.BringToFront();
					this.TxtCell.Font = new Font("Arial", 12f);
					this.TxtCell.Left = this.PicCell.Left + this.PicCell.Width;
					this.TxtCell.Top = this.PicCell.Top - this.TxtCell.Height;
					this.TxtCell.BorderStyle = BorderStyle.None;
					this.TxtCell.TextAlign = ContentAlignment.MiddleLeft;
					this.mPicBox.Controls.Add(this.TxtCell);
					this.PicRörUtCm.Left = this.PicCell.Left + this.PicCell.Width;
					this.PicRörUtCm.Width = this.mPicBox.Width - this.PicRörUtCm.Left;
					this.PicRörUtCm.Top = this.mPicBox.Height - this.mRörVliten;
					this.PicRörUtCm.Height = this.mRörVliten;
					this.PicRörUtCm.BringToFront();
					this.mPicBox.Controls.Add(this.PicRörUtCm);
					this.RörUtCm.PicBox = this.PicRörUtCm;
					this.PicRörIn1.Width = 5;
					this.PicRörIn1.Left = this.PicCell.Left - this.PicRörIn1.Width;
					this.PicRörIn1.Top = this.mPicBox.Height - this.mRörVliten;
					this.PicRörIn1.Height = this.mRörVliten;
					this.PicRörIn1.BringToFront();
					this.mPicBox.Controls.Add(this.PicRörIn1);
					this.RörInC1.PicBox = this.PicRörIn1;
					this.PicRörIn2.Left = this.PicRörIn1.Left - this.mRörVliten;
					this.PicRörIn2.Top = this.PicRörIn1.Top;
					this.PicRörIn2.Width = this.mRörVliten;
					this.PicRörIn2.Height = this.mRörVliten;
					this.PicRörIn2.BringToFront();
					this.mPicBox.Controls.Add(this.PicRörIn2);
					this.RörInUpp.PicBox = this.PicRörIn2;
					this.PicRörIn3.Width = this.mRörVliten;
					this.PicRörIn3.Top = 10 + this.mRörVliten;
					this.PicRörIn3.Left = this.PicRörIn2.Left;
					this.PicRörIn3.Height = this.PicRörIn2.Top - this.PicRörIn3.Top;
					this.PicRörIn3.SendToBack();
					this.mPicBox.Controls.Add(this.PicRörIn3);
					this.RörInVert.PicBox = this.PicRörIn3;
					this.PicRörIn4.Width = this.mRörVliten;
					this.PicRörIn4.Height = this.mRörVliten;
					this.PicRörIn4.Top = this.PicRörIn3.Top - this.mRörVliten;
					this.PicRörIn4.Left = this.PicRörIn3.Left;
					this.PicRörIn4.BringToFront();
					this.mPicBox.Controls.Add(this.PicRörIn4);
					this.RörInSKrök.PicBox = this.PicRörIn4;
					this.PicValvUt.Top = this.PicRörUtCm.Top;
					this.PicValvUt.Left = this.mPicBox.Width - this.mRörVliten;
					this.PicValvUt.Height = this.mRörVliten;
					this.PicValvUt.Width = this.mRörVliten;
					this.TipUtValv.SetToolTip(this.PicValvUt, "Initierad");
					this.mPicBox.Controls.Add(this.PicValvUt);
					this.BindUtValve.InitValve(ref this.PicValvUt, false, ref this.TipUtValv, this.mValvUtNamn);
					this.PicAvluft.Left = 0;
					this.PicAvluft.Height = this.mRörVliten;
					this.PicAvluft.Width = this.PicRörIn3.Left;
					this.PicAvluft.Top = this.PicCell.Top;
					this.PicAvluft.BringToFront();
					this.mPicBox.Controls.Add(this.PicAvluft);
					this.RörAvluft.PicBox = this.PicAvluft;
					this.PicAvluftValv.Top = this.PicAvluft.Top;
					this.PicAvluftValv.Height = this.mRörVliten;
					this.PicAvluftValv.Left = this.PicAvluft.Left;
					this.PicAvluftValv.Width = this.mRörVliten;
					this.TipAvluftValv.SetToolTip(this.PicAvluftValv, "Initierad");
					this.mPicBox.Controls.Add(this.PicAvluftValv);
					this.AvluftValv.InitValve(ref this.PicAvluftValv, false, ref this.TipAvluftValv, this.ValvAvluftNamn);
					this.PicRörInS1.Top = 15;
					this.PicRörInS1.Height = this.mRörVStor;
					this.PicRörInS1.Left = this.mVänsterSida - 5;
					this.PicRörInS1.Width = this.mVänsterSida - this.PicRörInS1.Left + 1;
					this.mPicBox.Controls.Add(this.PicRörInS1);
					this.RörInStor1.PicBox = this.PicRörInS1;
					this.PicRörInS2.Top = this.PicRörInS1.Top;
					this.PicRörInS2.Height = this.mRörVStor;
					this.PicRörInS2.Left = this.PicRörInS1.Left - this.mRörVStor;
					this.PicRörInS2.Width = this.mRörVStor;
					this.mPicBox.Controls.Add(this.PicRörInS2);
					Color Färg = default(Color);
					Färg = this.PicRörInS2.BackColor;
					Färg = Color.FromArgb(0, Färg);
					this.PicRörInS2.BackColor = Färg;
					this.RörInStor2.PicBox = this.PicRörInS2;
					this.PicRörInS3.Top = this.PicRörInS2.Top + this.PicRörInS2.Height;
					this.PicRörInS3.Height = (int)Math.Round(unchecked((double)this.mHöjd / 2.0 - (double)this.PicRörInS3.Top));
					this.PicRörInS3.Left = this.PicRörInS2.Left;
					this.PicRörInS3.Width = this.mRörVStor;
					this.mPicBox.Controls.Add(this.PicRörInS3);
					this.RörInStor3.PicBox = this.PicRörInS3;
					this.PicRörInS4.Top = this.PicRörInS3.Top + this.PicRörInS3.Height;
					this.PicRörInS4.Height = this.mRörVStor;
					this.PicRörInS4.Left = this.PicRörInS2.Left;
					this.PicRörInS4.Width = this.mRörVStor;
					this.mPicBox.Controls.Add(this.PicRörInS4);
					this.RörInStor4.PicBox = this.PicRörInS4;
					this.PicRörInS5.Top = this.PicRörInS4.Top;
					this.PicRörInS5.Height = this.mRörVStor;
					this.PicRörInS5.Left = 0;
					this.PicRörInS5.Width = this.PicRörInS4.Left;
					this.mPicBox.Controls.Add(this.PicRörInS5);
					this.RörInStor5.PicBox = this.PicRörInS5;
					this.PicBindInValv.Top = this.PicRörInS5.Top;
					this.PicBindInValv.Height = this.mRörVStor;
					this.PicBindInValv.Left = this.PicRörInS5.Left;
					this.PicBindInValv.Width = this.mRörVliten;
					this.TipBindInValv.SetToolTip(this.PicBindInValv, "Initierad");
					this.mPicBox.Controls.Add(this.PicBindInValv);
					this.BindInValv.InitValve(ref this.PicBindInValv, false, ref this.TipBindInValv, this.mValvInBindNamn);
					this.PicRörUtS1.Top = 15;
					this.PicRörUtS1.Height = this.mRörVStor;
					this.PicRörUtS1.Left = this.PicRörIn4.Left - 8;
					this.PicRörUtS1.Width = 1;
					this.mPicBox.Controls.Add(this.PicRörUtS1);
					this.RörUtStor1.PicBox = this.PicRörUtS1;
					this.PicRörUtS2.Top = this.PicRörUtS1.Top;
					this.PicRörUtS2.Height = this.mRörVStor;
					this.PicRörUtS2.Left = this.PicRörUtS1.Left - this.mRörVStor;
					this.PicRörUtS2.Width = this.mRörVStor;
					this.mPicBox.Controls.Add(this.PicRörUtS2);
					this.PicRörUtS2.BackColor = Färg;
					this.RörUtStor2.PicBox = this.PicRörUtS2;
					this.PicRörUtS3.Top = this.PicRörUtS2.Top + this.PicRörUtS2.Height;
					this.PicRörUtS3.Height = this.PicRörInS3.Height + this.mRörVStor + 2 * this.mRörVStor;
					this.PicRörUtS3.Left = this.PicRörUtS2.Left;
					this.PicRörUtS3.Width = this.mRörVStor;
					this.mPicBox.Controls.Add(this.PicRörUtS3);
					this.RörUtStor3.PicBox = this.PicRörUtS3;
					this.PicRörUtS4.Top = this.PicRörUtS3.Top + this.PicRörUtS3.Height;
					this.PicRörUtS4.Height = this.mRörVStor;
					this.PicRörUtS4.Left = this.PicRörUtS2.Left;
					this.PicRörUtS4.Width = this.mRörVStor;
					this.mPicBox.Controls.Add(this.PicRörUtS4);
					this.RörUtStor4.PicBox = this.PicRörUtS4;
					this.PicRörUtS5.Top = this.PicRörUtS4.Top;
					this.PicRörUtS5.Height = this.mRörVStor;
					this.PicRörUtS5.Left = 0;
					this.PicRörUtS5.Width = this.PicRörUtS4.Left;
					this.mPicBox.Controls.Add(this.PicRörUtS5);
					this.RörUtStor5.PicBox = this.PicRörUtS5;
					this.PicBindUtValv.Top = this.PicRörUtS5.Top;
					this.PicBindUtValv.Height = this.mRörVStor;
					this.PicBindUtValv.Left = this.PicRörUtS5.Left;
					this.PicBindUtValv.Width = this.mRörVliten;
					this.TipBindUtValv.SetToolTip(this.PicBindUtValv, "Initierad");
					this.mPicBox.Controls.Add(this.PicBindUtValv);
					this.BindUtValv.InitValve(ref this.PicBindUtValv, false, ref this.TipBindUtValv, this.mValvUtBindNamn);
					this.PicLuftIn1.Left = 24;
					this.PicLuftIn1.Width = this.mRörVliten;
					this.PicLuftIn1.Top = this.PicAvluft.Top - 15;
					this.PicLuftIn1.Height = this.mPicBox.Height - this.PicLuftIn1.Top;
					this.PicLuftIn1.BringToFront();
					this.mPicBox.Controls.Add(this.PicLuftIn1);
					this.PicLuftIn1.BringToFront();
					this.LuftRör1.PicBox = this.PicLuftIn1;
					this.PicLuftIn2.Left = this.PicLuftIn1.Left;
					this.PicLuftIn2.Width = this.mRörVliten;
					this.PicLuftIn2.Top = this.PicLuftIn1.Top - this.mRörVliten;
					this.PicLuftIn2.Height = this.mRörVliten;
					this.PicLuftIn2.BringToFront();
					this.mPicBox.Controls.Add(this.PicLuftIn2);
					this.LuftRör2.PicBox = this.PicLuftIn2;
					this.PicLuftIn3.Left = this.PicLuftIn2.Left + this.mRörVliten;
					this.PicLuftIn3.Width = (int)Math.Round(unchecked((double)this.mPicBox.Width / 2.0 - (double)this.PicLuftIn3.Left)) - 15;
					this.PicLuftIn3.Top = this.PicLuftIn2.Top;
					this.PicLuftIn3.Height = this.mRörVliten;
					this.PicLuftIn3.BringToFront();
					this.mPicBox.Controls.Add(this.PicLuftIn3);
					this.PicLuftIn3.BringToFront();
					this.LuftRör3.PicBox = this.PicLuftIn3;
					this.PicLuftIn4.Left = this.PicLuftIn3.Left + this.PicLuftIn3.Width;
					this.PicLuftIn4.Width = this.mRörVliten;
					this.PicLuftIn4.Top = this.PicLuftIn3.Top;
					this.PicLuftIn4.Height = this.mRörVliten;
					this.PicLuftIn4.BringToFront();
					this.mPicBox.Controls.Add(this.PicLuftIn4);
					this.LuftRör4.PicBox = this.PicLuftIn4;
				}
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00031790 File Offset: 0x0002FB90
		// (set) Token: 0x060003DF RID: 991 RVA: 0x000317A8 File Offset: 0x0002FBA8
		public float TankVikt
		{
			get
			{
				return this.mTankVikt;
			}
			set
			{
				this.mTankVikt = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x000317B4 File Offset: 0x0002FBB4
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x000317CC File Offset: 0x0002FBCC
		public int MaxVikt
		{
			get
			{
				return this.mMaxVikt;
			}
			set
			{
				this.mMaxVikt = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000317D8 File Offset: 0x0002FBD8
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x000317F0 File Offset: 0x0002FBF0
		public float tryck
		{
			get
			{
				return this.mTryck;
			}
			set
			{
				this.mTryck = value;
				this.RörUtCm.tryck = this.mTryck;
				this.RörInC1.tryck = this.mTryck;
				this.RörInUpp.tryck = this.mTryck;
				this.RörInVert.tryck = this.mTryck;
				this.RörInSKrök.tryck = this.mTryck;
				this.RörAvluft.tryck = this.mTryck;
				this.RörInStor1.tryck = this.mTryck;
				this.RörInStor2.tryck = this.mTryck;
				this.RörInStor3.tryck = this.mTryck;
				this.RörInStor4.tryck = this.mTryck;
				this.RörInStor5.tryck = this.mTryck;
				this.RörUtStor1.tryck = this.mTryck;
				this.RörUtStor2.tryck = this.mTryck;
				this.RörUtStor3.tryck = this.mTryck;
				this.RörUtStor4.tryck = this.mTryck;
				this.RörUtStor5.tryck = this.mTryck;
				this.LuftRör1.tryck = this.mTryck;
				this.LuftRör2.tryck = this.mTryck;
				this.LuftRör3.tryck = this.mTryck;
				this.LuftRör4.tryck = this.mTryck;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00031958 File Offset: 0x0002FD58
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00031970 File Offset: 0x0002FD70
		public bool Aktiv
		{
			get
			{
				return this.mAktiv;
			}
			set
			{
				if (!this.mAktiv && value)
				{
					this.mPicBox.CreateGraphics().Clear(this.mPicBox.BackColor);
				}
				this.mAktiv = value;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000319A4 File Offset: 0x0002FDA4
		public void RitaOm()
		{
			if (!this.mInitierad)
			{
				return;
			}
			bool BinderGränsTunnan = false;
			int ProcBreddHalva = this.mBreddHalva;
			int Höjd = this.mHöjd;
			int Bredd = this.mBredd;
			int VänsterSidaTank = this.mVänsterSida;
			bool TryckITank = false;
			if ((double)this.mTryck >= 0.1)
			{
				TryckITank = true;
			}
			int ToppH = 0;
			int Radien;
			int Centrum1b;
			int Centrum2b;
			int Infasning;
			int HöjdFläns;
			int HögerFläns;
			int VänsterFläns;
			int Botten;
			GraphicsPath PathÖvre;
			GraphicsPath PathBinderTö;
			GraphicsPath PathBinderTu;
			GraphicsPath PathBinderUö;
			GraphicsPath PathBinderUu;
			GraphicsPath PathFläns;
			Pen NyPenna;
			Graphics formGraphics;
			string drawStringKg;
			string drawStringBar;
			string drawStringTemp;
			Font drawFont;
			SolidBrush drawBrush;
			float HögerIndrag = 0.0f;
			checked
			{
				Radien = (int)Math.Round(unchecked((double)Höjd * 0.2));
				int Centrum1h = ToppH + Radien;
				Centrum1b = VänsterSidaTank + Radien;
				Centrum2b = VänsterSidaTank + Bredd - Radien;
				Infasning = (int)Math.Round(unchecked((double)Höjd * 0.7));
				HöjdFläns = (int)Math.Round(unchecked((double)Höjd * 0.95));
				HögerFläns = (int)Math.Round(unchecked((double)VänsterSidaTank + (double)Bredd / 2.0 + (double)Bredd * 0.2));
				VänsterFläns = (int)Math.Round(unchecked((double)VänsterSidaTank + (double)Bredd / 2.0 - (double)Bredd * 0.2));
				int HögerFlänsUppe = (int)Math.Round(unchecked((double)HögerFläns - 0.05 * (double)Bredd));
				int VänsterFlänsUppe = (int)Math.Round(unchecked((double)VänsterFläns + 0.05 * (double)Bredd));
				Botten = Höjd;
				PathÖvre = new GraphicsPath();
				PathBinderTö = new GraphicsPath();
				PathBinderTu = new GraphicsPath();
				PathBinderUö = new GraphicsPath();
				PathBinderUu = new GraphicsPath();
				PathFläns = new GraphicsPath();
				PathÖvre.AddArc(VänsterSidaTank, ToppH, Radien, Radien, 180f, 90f);
				PathÖvre.AddLine(Centrum1b, ToppH, Centrum2b, ToppH);
				PathÖvre.AddArc(Centrum2b, ToppH, Radien, Radien, 270f, 90f);
				int hSist = (int)Math.Round((double)PathÖvre.GetLastPoint().Y);
				int BinderLängd = (int)Math.Round(unchecked((double)(checked(HöjdFläns - hSist)) * 1.05));
				int BinderlängdTunna = BinderLängd - (HöjdFläns - Infasning);
				int HöjdBinder;
				if (this.mTankVikt < (float)this.mMaxVikt & this.mTankVikt >= 0f)
				{
					float BindGränsTunna = (float)(unchecked(0.2 * (double)this.mMaxVikt));
					if (this.mTankVikt >= BindGränsTunna)
					{
						HöjdBinder = (int)Math.Round((double)(unchecked((float)Infasning - (float)BinderlängdTunna * (this.mTankVikt - BindGränsTunna) / ((float)this.mMaxVikt - BindGränsTunna))));
					}
					else
					{
						HöjdBinder = (int)Math.Round((double)(unchecked((float)HöjdFläns - (float)(checked(HöjdFläns - Infasning)) * this.mTankVikt / BindGränsTunna)));
					}
				}
				else
				{
					HöjdBinder = HöjdFläns - BinderLängd;
				}
				if (this.mTankVikt < 0f)
				{
					HöjdBinder = HöjdFläns;
				}
				if (HöjdBinder <= Infasning)
				{
					BinderGränsTunnan = true;
				}
				if (BinderGränsTunnan)
				{
					PathBinderTö.AddLine(Centrum1b - Radien, HöjdBinder, Centrum1b - Radien, hSist);
					PathBinderTö.AddLine(Centrum1b - Radien, hSist, Centrum2b + Radien, hSist);
					PathBinderTö.AddLine(Centrum2b + Radien, hSist, Centrum2b + Radien, HöjdBinder);
					PathBinderTö.CloseFigure();
					PathBinderTu.AddLine(Centrum1b - Radien, Infasning, Centrum1b - Radien, HöjdBinder);
					PathBinderTu.AddLine(Centrum1b - Radien, HöjdBinder, Centrum2b + Radien, HöjdBinder);
					PathBinderTu.AddLine(Centrum2b + Radien, HöjdBinder, Centrum2b + Radien, Infasning);
					PathBinderTu.CloseFigure();
					PathBinderUö.AddLine(VänsterFlänsUppe, HöjdFläns, Centrum1b - Radien, Infasning);
					PathBinderUö.AddLine(Centrum1b - Radien, Infasning, Centrum2b + Radien, Infasning);
					PathBinderUö.AddLine(Centrum2b + Radien, Infasning, HögerFlänsUppe, HöjdFläns);
					PathBinderUö.CloseFigure();
				}
				else
				{
					PathBinderTö.AddLine(Centrum1b - Radien, Infasning, Centrum1b - Radien, hSist);
					PathBinderTö.AddLine(Centrum1b - Radien, hSist, Centrum2b + Radien, hSist);
					PathBinderTö.AddLine(Centrum2b + Radien, hSist, Centrum2b + Radien, Infasning);
					PathBinderTö.CloseFigure();
					int diffBredd = VänsterFlänsUppe - (Centrum1b - Radien);
					int diffHöjd = HöjdFläns - Infasning;
					int diffBindHöjd = HöjdFläns - HöjdBinder;
					int BreddVfas = (int)Math.Round(unchecked((double)VänsterFlänsUppe - (double)(checked(diffBredd * diffBindHöjd)) / (double)diffHöjd));
					int BreddHfas = (int)Math.Round(unchecked((double)HögerFlänsUppe + (double)(checked(diffBredd * diffBindHöjd)) / (double)diffHöjd));
					PathBinderUö.AddLine(BreddVfas, HöjdBinder, Centrum1b - Radien, Infasning);
					PathBinderUö.AddLine(Centrum1b - Radien, Infasning, Centrum2b + Radien, Infasning);
					PathBinderUö.AddLine(Centrum2b + Radien, Infasning, BreddHfas, HöjdBinder);
					PathBinderUö.CloseFigure();
					PathBinderUu.AddLine(VänsterFlänsUppe, HöjdFläns, BreddVfas, HöjdBinder);
					PathBinderUu.AddLine(BreddVfas, HöjdBinder, BreddHfas, HöjdBinder);
					PathBinderUu.AddLine(BreddHfas, HöjdBinder, HögerFlänsUppe, HöjdFläns);
					PathBinderUu.CloseFigure();
				}
				PathFläns.AddLine(VänsterFläns, Botten, VänsterFläns, HöjdFläns);
				PathFläns.AddLine(VänsterFläns, HöjdFläns, HögerFläns, HöjdFläns);
				PathFläns.AddLine(HögerFläns, HöjdFläns, HögerFläns, Botten);
				PathFläns.CloseFigure();
				NyPenna = new Pen(Color.Black);
				NyPenna.Width = 2f;
				this.mPicBox.CreateGraphics().SmoothingMode = SmoothingMode.HighQuality;
				formGraphics = this.mPicBox.CreateGraphics();
				drawStringKg = Conversions.ToString(this.mTankVikt) + " kg";
				drawStringBar = Strings.Format(this.mTryck, "0.00") + " bar";
				drawStringTemp = Strings.Format(this.mTemp, "0.0") + Conversions.ToString(Strings.Chr(176)) + "C";
				drawFont = new Font("Arial", 16f);
				drawBrush = new SolidBrush(Color.Black);
				if (this.mTankVikt >= 1000f)
				{
					HögerIndrag = 30f;
				}
				if (this.mTankVikt >= 100f & this.mTankVikt < 1000f)
				{
					HögerIndrag = 20f;
				}
				if (this.mTankVikt >= 10f & this.mTankVikt < 100f)
				{
					HögerIndrag = 8f;
				}
				if (this.mTankVikt >= 0f & this.mTankVikt < 10f)
				{
					HögerIndrag = -3f;
				}
				if (this.mTankVikt < 0f & this.mTankVikt > -10f)
				{
					HögerIndrag = 3f;
				}
				if (this.mTankVikt <= -10f & this.mTankVikt > -100f)
				{
					HögerIndrag = 15f;
				}
				if (this.mTankVikt <= -100f & this.mTankVikt > -1000f)
				{
					HögerIndrag = 25f;
				}
			}
			float x = (float)((double)VänsterSidaTank + (double)Bredd / 2.0 - (double)HögerIndrag);
			float xT = (float)((double)VänsterSidaTank + (double)Bredd / 2.0 - 25.0);
			checked
			{
				float y = (float)(Infasning - drawFont.Height);
				float yT = (float)(Infasning - 2 * drawFont.Height);
				float xN = (float)(unchecked((double)VänsterSidaTank + (double)Bredd / 2.0 - 8.0));
				float yN = (float)(Infasning - drawFont.Height * 4 - 2);
				float xTemp = xT;
				float yTemp = (float)(Infasning - 3 * drawFont.Height);
				StringFormat drawFormat = new StringFormat();
				PointF Punkt = new PointF((float)(Centrum1b - Radien - 1), (float)(unchecked((double)Höjd * 0.5)));
				PointF Punkt2 = new PointF((float)(Centrum2b + Radien), (float)(unchecked((double)Höjd * 0.5)));
				PointF Punkt3 = new PointF((float)VänsterFläns, (float)HöjdFläns);
				PointF Punkt4 = new PointF((float)HögerFläns, (float)Botten);
				PointF Punkt5 = new PointF((float)(Centrum1b - Radien), (float)Infasning);
				PointF Punkt6 = new PointF((float)((double)(Bredd + HögerFläns) / 2.0), (float)Höjd);
				Color TomÖvreH = default(Color);
				Color TomÖvreV = default(Color);
				Color NyFärgU = default(Color);
				Color nyFärgT = default(Color);
				if (!TryckITank)
				{
					TomÖvreH = Color.DarkKhaki;
					TomÖvreV = Color.Khaki;
					NyFärgU = Color.FromArgb((int)TomÖvreH.A, (int)(TomÖvreH.R - 30), (int)(TomÖvreH.G - 30), (int)(TomÖvreH.B - 30));
					nyFärgT = Color.FromArgb((int)TomÖvreH.A, (int)(TomÖvreH.R - 10), (int)(TomÖvreH.G - 10), (int)(TomÖvreH.B - 10));
				}
				else
				{
					TomÖvreH = Color.Goldenrod;
					TomÖvreV = Color.LightGoldenrodYellow;
					NyFärgU = Color.FromArgb((int)TomÖvreH.A, (int)(TomÖvreH.R + 10), (int)(TomÖvreH.G - 30), (int)(TomÖvreH.B - 0));
					nyFärgT = Color.FromArgb((int)TomÖvreH.A, (int)(TomÖvreH.R + 20), (int)(TomÖvreH.G - 10), (int)(TomÖvreH.B - 0));
				}
				LinearGradientBrush PenselTom = new LinearGradientBrush(Punkt, Punkt2, TomÖvreV, TomÖvreH);
				LinearGradientBrush PenselTomT = new LinearGradientBrush(Punkt, Punkt2, TomÖvreV, nyFärgT);
				LinearGradientBrush PenselBinder = new LinearGradientBrush(Punkt, Punkt2, Color.GreenYellow, Color.DarkOliveGreen);
				LinearGradientBrush PenselBinderFas = new LinearGradientBrush(Punkt5, Punkt6, Color.GreenYellow, Color.DarkGreen);
				LinearGradientBrush penselTomFas = new LinearGradientBrush(Punkt5, Punkt6, TomÖvreV, NyFärgU);
				LinearGradientBrush PenselFläns = new LinearGradientBrush(Punkt3, Punkt4, Color.LightGray, Color.DarkSlateGray);
				this.mPicBox.CreateGraphics().FillPath(PenselTom, PathÖvre);
				this.mPicBox.CreateGraphics().FillPath(PenselTomT, PathBinderTö);
				this.mPicBox.CreateGraphics().FillPath(PenselFläns, PathFläns);
				if (BinderGränsTunnan)
				{
					this.mPicBox.CreateGraphics().FillPath(PenselBinder, PathBinderTu);
					this.mPicBox.CreateGraphics().FillPath(PenselBinderFas, PathBinderUö);
				}
				else
				{
					this.mPicBox.CreateGraphics().FillPath(penselTomFas, PathBinderUö);
					this.mPicBox.CreateGraphics().FillPath(PenselBinderFas, PathBinderUu);
				}
				if (!this.mAktiv)
				{
					Pen rödpenna = new Pen(Color.MediumVioletRed);
					rödpenna.Width = 3f;
					int Vsida = Centrum1b - Radien;
					int Hsida = Centrum2b + Radien;
					int LbegränsV = (int)Math.Round(unchecked((double)(checked(Hsida - Vsida)) / 3.0 + (double)Vsida));
					int LbegränsH = (int)Math.Round(unchecked((double)(checked(2 * (Hsida - Vsida))) / 3.0 + (double)Vsida));
					this.mPicBox.CreateGraphics().DrawLine(rödpenna, Vsida, 0, LbegränsV, (int)Math.Round((double)Höjd / 3.0));
					this.mPicBox.CreateGraphics().DrawLine(rödpenna, Hsida, 0, LbegränsH, (int)Math.Round((double)Höjd / 3.0));
					this.mPicBox.CreateGraphics().DrawLine(rödpenna, Vsida, Höjd, LbegränsV, (int)Math.Round((double)(2 * Höjd) / 3.0));
					this.mPicBox.CreateGraphics().DrawLine(rödpenna, Hsida, Höjd, LbegränsH, (int)Math.Round((double)(2 * Höjd) / 3.0));
				}
				formGraphics.DrawString(drawStringKg, drawFont, drawBrush, x, y, drawFormat);
				formGraphics.DrawString(drawStringBar, drawFont, drawBrush, xT, yT, drawFormat);
				formGraphics.DrawString(this.mTankNamn, drawFont, drawBrush, xN, yN, drawFormat);
				formGraphics.DrawString(drawStringTemp, drawFont, drawBrush, xTemp, yTemp, drawFormat);
				drawFont.Dispose();
				drawBrush.Dispose();
				formGraphics.Dispose();
				this.mPicBox.CreateGraphics().Dispose();
				NyPenna.Dispose();
				PenselTom.Dispose();
				PenselBinder.Dispose();
				PenselBinderFas.Dispose();
				PenselFläns.Dispose();
			}
		}

		// Token: 0x04000272 RID: 626
		private PictureBox mPicBox;

		// Token: 0x04000273 RID: 627
		private bool mInitierad;

		// Token: 0x04000274 RID: 628
		private float mCellFart;

		// Token: 0x04000275 RID: 629
		private float mTankVikt;

		// Token: 0x04000276 RID: 630
		private int mMaxVikt;

		// Token: 0x04000277 RID: 631
		private float mTryck;

		// Token: 0x04000278 RID: 632
		private TextBox txtBox;

		// Token: 0x04000279 RID: 633
		private int mHöjd;

		// Token: 0x0400027A RID: 634
		private int mBredd;

		// Token: 0x0400027B RID: 635
		private int mBreddHalva;

		// Token: 0x0400027C RID: 636
		private int mVänsterSida;

		// Token: 0x0400027D RID: 637
		private bool mAktiv;

		// Token: 0x0400027E RID: 638
		private float mTemp;

		// Token: 0x0400027F RID: 639
		private string mTankNamn;

		// Token: 0x04000280 RID: 640
		private Cellmatare mCellm;

		// Token: 0x04000281 RID: 641
		private PictureBox PicCell;

		// Token: 0x04000282 RID: 642
		private Label TxtCell;

		// Token: 0x04000283 RID: 643
		private PictureBox PicRörUtCm;

		// Token: 0x04000284 RID: 644
		private RitaRörH RörUtCm;

		// Token: 0x04000285 RID: 645
		private PictureBox PicRörIn1;

		// Token: 0x04000286 RID: 646
		private RitaRörH RörInC1;

		// Token: 0x04000287 RID: 647
		private PictureBox PicRörIn2;

		// Token: 0x04000288 RID: 648
		private RitaKrökÖH RörInUpp;

		// Token: 0x04000289 RID: 649
		private PictureBox PicRörIn3;

		// Token: 0x0400028A RID: 650
		private RitaRörV RörInVert;

		// Token: 0x0400028B RID: 651
		private PictureBox PicRörIn4;

		// Token: 0x0400028C RID: 652
		private RitaKrökUH RörInSKrök;

		// Token: 0x0400028D RID: 653
		private PictureBox PicValvUt;

		// Token: 0x0400028E RID: 654
		private PictureBox PicAvluft;

		// Token: 0x0400028F RID: 655
		private RitaRörH RörAvluft;

		// Token: 0x04000290 RID: 656
		private ToolTip TipUtValv;

		// Token: 0x04000291 RID: 657
		private Ventil BindUtValve;

		// Token: 0x04000292 RID: 658
		private PictureBox PicAvluftValv;

		// Token: 0x04000293 RID: 659
		private ToolTip TipAvluftValv;

		// Token: 0x04000294 RID: 660
		private Ventil AvluftValv;

		// Token: 0x04000295 RID: 661
		private PictureBox PicRörInS1;

		// Token: 0x04000296 RID: 662
		private RitaRörH RörInStor1;

		// Token: 0x04000297 RID: 663
		private PictureBox PicRörInS2;

		// Token: 0x04000298 RID: 664
		private RitaKrökUH RörInStor2;

		// Token: 0x04000299 RID: 665
		private PictureBox PicRörInS3;

		// Token: 0x0400029A RID: 666
		private RitaRörV RörInStor3;

		// Token: 0x0400029B RID: 667
		private PictureBox PicRörInS4;

		// Token: 0x0400029C RID: 668
		private RitaKrökÖV RörInStor4;

		// Token: 0x0400029D RID: 669
		private PictureBox PicRörInS5;

		// Token: 0x0400029E RID: 670
		private RitaRörH RörInStor5;

		// Token: 0x0400029F RID: 671
		private PictureBox PicBindInValv;

		// Token: 0x040002A0 RID: 672
		private ToolTip TipBindInValv;

		// Token: 0x040002A1 RID: 673
		private Ventil BindInValv;

		// Token: 0x040002A2 RID: 674
		private PictureBox PicRörUtS1;

		// Token: 0x040002A3 RID: 675
		private RitaRörH RörUtStor1;

		// Token: 0x040002A4 RID: 676
		private PictureBox PicRörUtS2;

		// Token: 0x040002A5 RID: 677
		private RitaKrökUH RörUtStor2;

		// Token: 0x040002A6 RID: 678
		private PictureBox PicRörUtS3;

		// Token: 0x040002A7 RID: 679
		private RitaRörV RörUtStor3;

		// Token: 0x040002A8 RID: 680
		private PictureBox PicRörUtS4;

		// Token: 0x040002A9 RID: 681
		private RitaKrökÖV RörUtStor4;

		// Token: 0x040002AA RID: 682
		private PictureBox PicRörUtS5;

		// Token: 0x040002AB RID: 683
		private RitaRörH RörUtStor5;

		// Token: 0x040002AC RID: 684
		private PictureBox PicBindUtValv;

		// Token: 0x040002AD RID: 685
		private ToolTip TipBindUtValv;

		// Token: 0x040002AE RID: 686
		private Ventil BindUtValv;

		// Token: 0x040002AF RID: 687
		private PictureBox PicLuftIn1;

		// Token: 0x040002B0 RID: 688
		private PictureBox PicLuftIn2;

		// Token: 0x040002B1 RID: 689
		private PictureBox PicLuftIn3;

		// Token: 0x040002B2 RID: 690
		private PictureBox PicLuftIn4;

		// Token: 0x040002B3 RID: 691
		private RitaRörV LuftRör1;

		// Token: 0x040002B4 RID: 692
		private RitaKrökUH LuftRör2;

		// Token: 0x040002B5 RID: 693
		private RitaRörH LuftRör3;

		// Token: 0x040002B6 RID: 694
		private RitaKrökÖV LuftRör4;

		// Token: 0x040002B7 RID: 695
		private string mValvUtNamn;

		// Token: 0x040002B8 RID: 696
		private string mValvAvluftNamn;

		// Token: 0x040002B9 RID: 697
		private string mValvInBindNamn;

		// Token: 0x040002BA RID: 698
		private string mValvUtBindNamn;

		// Token: 0x040002BB RID: 699
		private int mRörVliten;

		// Token: 0x040002BC RID: 700
		private int mRörVStor;
	}
}
