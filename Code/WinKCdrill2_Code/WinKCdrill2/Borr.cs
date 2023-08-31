using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace winKCdrill2
{
	// Token: 0x02000008 RID: 8
	public class Borr
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00026014 File Offset: 0x00024414
		public Borr()
		{
			this.MastLängd = 30f;
			this.mVrör = new RitaRörV();
			this.Rörpic = new PictureBox();
			this.mBorrLängd = 12f;
			this.mJordBotten = 10f;
			this.mStoppDjup = 0.5f;
			this.mVerktygsHöjd = 1f;
			this.mVisaMeter = false;
			this.mVerktygsBredd = 0.6f;
			this.mlblTryck = new Label();
			this.mlblBar = new Label();
			this.mlblRot = new Label();
			this.mlblRpm = new Label();
			this.mlblDjupV = new Label();
			this.mlblDjupH = new Label();
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000260C8 File Offset: 0x000244C8
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000260E0 File Offset: 0x000244E0
		public PictureBox PicBox
		{
			get
			{
				return this.mPicBox;
			}
			set
			{
				this.mPicBox = value;
				this.Rörpic.Top = 0;
				this.Rörpic.Width = 8;
				this.Rörpic.Height = 30;
				checked
				{
					this.Rörpic.Left = (int)Math.Round(unchecked((double)this.mPicBox.Width / 2.0 - (double)this.Rörpic.Width / 2.0));
					this.mPicBox.Controls.Add(this.Rörpic);
					this.mVrör.PicBox = this.Rörpic;
					Font labelFont = new Font("Arial", 14f);
					this.mlblTryck.Font = labelFont;
					this.mlblTryck.TextAlign = ContentAlignment.BottomRight;
					this.mlblTryck.Text = "0.00";
					this.mlblTryck.AutoSize = true;
					this.mPicBox.Controls.Add(this.mlblTryck);
					this.mlblBar.Font = labelFont;
					this.mlblBar.TextAlign = ContentAlignment.BottomLeft;
					this.mlblBar.Text = "bar";
					this.mlblBar.AutoSize = true;
					this.mPicBox.Controls.Add(this.mlblBar);
					this.TryckLabelPlacering();
					this.mlblRot.Font = labelFont;
					this.mlblRot.TextAlign = ContentAlignment.BottomRight;
					this.mlblRot.Text = "300";
					this.mlblRot.AutoSize = true;
					this.mPicBox.Controls.Add(this.mlblRot);
					this.mlblRpm.Font = labelFont;
					this.mlblRpm.TextAlign = ContentAlignment.BottomLeft;
					this.mlblRpm.Text = "rpm";
					this.mlblRpm.AutoSize = true;
					this.mPicBox.Controls.Add(this.mlblRpm);
					this.RpmLabelPlacering(this.mlblBar.Top + 50, 10);
					this.mlblDjupV.Font = labelFont;
					this.mlblDjupV.TextAlign = ContentAlignment.BottomRight;
					this.mlblDjupV.Text = "0";
					this.mlblDjupV.AutoSize = true;
					this.mPicBox.Controls.Add(this.mlblDjupV);
					this.mlblDjupH.Font = labelFont;
					this.mlblDjupH.TextAlign = ContentAlignment.BottomLeft;
					this.mlblDjupH.Text = "00";
					this.mlblDjupH.AutoSize = true;
					this.mPicBox.Controls.Add(this.mlblDjupH);
					this.djupLabelPlacering(this.mlblRot.Top + 50, 10);
					this.Init = true;
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0002639C File Offset: 0x0002479C
		private void TryckLabelPlacering()
		{
			checked
			{
				this.mlblTryck.Left = this.Rörpic.Left - 2 - this.mlblTryck.Width;
				this.mlblTryck.Top = this.Rörpic.Top + this.Rörpic.Height - this.mlblTryck.Height;
				this.mlblBar.Left = this.Rörpic.Left + this.Rörpic.Width + 2;
				this.mlblBar.Top = this.mlblTryck.Top;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00026438 File Offset: 0x00024838
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00026450 File Offset: 0x00024850
		public int Rotation
		{
			get
			{
				return this.mRotation;
			}
			set
			{
				this.mRotation = value;
				this.mlblRot.Text = Strings.Format(this.mRotation, "0");
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0002647C File Offset: 0x0002487C
		private void RpmLabelPlacering(int Över, int FrånC)
		{
			this.mlblRot.Top = Över;
			checked
			{
				this.mlblRot.Left = (int)Math.Round(unchecked((double)this.mPicBox.Width / 2.0 - (double)FrånC - (double)this.mlblRot.Width));
				this.mlblRpm.Top = Över;
				this.mlblRpm.Left = (int)Math.Round(unchecked((double)this.mPicBox.Width / 2.0 + (double)FrånC));
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00026504 File Offset: 0x00024904
		private void djupLabelPlacering(int Över, int FrånC)
		{
			this.mlblDjupV.Top = Över;
			checked
			{
				this.mlblDjupV.Left = (int)Math.Round(unchecked((double)this.mPicBox.Width / 2.0 - (double)FrånC - (double)this.mlblDjupV.Width));
				this.mlblDjupH.Top = Över;
				this.mlblDjupH.Left = (int)Math.Round(unchecked((double)this.mPicBox.Width / 2.0 + (double)FrånC));
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0002658C File Offset: 0x0002498C
		public void Tryck(float Pressure)
		{
			if (!this.Init)
			{
				return;
			}
			this.mVrör.tryck = Pressure;
			this.mlblTryck.Text = Strings.Format(Pressure, "0.00");
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000265C0 File Offset: 0x000249C0
		// (set) Token: 0x06000030 RID: 48 RVA: 0x000265D8 File Offset: 0x000249D8
		public float BorrLängd
		{
			get
			{
				return this.mBorrLängd;
			}
			set
			{
				this.mBorrLängd = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000265E4 File Offset: 0x000249E4
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000265FC File Offset: 0x000249FC
		public float JordBotten
		{
			get
			{
				return this.mJordBotten;
			}
			set
			{
				this.mJordBotten = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00026608 File Offset: 0x00024A08
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00026620 File Offset: 0x00024A20
		public float StoppDjup
		{
			get
			{
				return this.mStoppDjup;
			}
			set
			{
				this.mStoppDjup = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0002662C File Offset: 0x00024A2C
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00026644 File Offset: 0x00024A44
		public int JordYta
		{
			get
			{
				return this.mJordYta;
			}
			set
			{
				this.mJordYta = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00026650 File Offset: 0x00024A50
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00026668 File Offset: 0x00024A68
		public float VerktygsHöjd
		{
			get
			{
				return this.mVerktygsHöjd;
			}
			set
			{
				this.mVerktygsHöjd = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00026674 File Offset: 0x00024A74
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0002668C File Offset: 0x00024A8C
		public bool VisaMeter
		{
			get
			{
				return this.mVisaMeter;
			}
			set
			{
				this.mVisaMeter = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00026698 File Offset: 0x00024A98
		// (set) Token: 0x0600003C RID: 60 RVA: 0x000266B0 File Offset: 0x00024AB0
		public float VerktygsBredd
		{
			get
			{
				return this.mVerktygsBredd;
			}
			set
			{
				this.mVerktygsBredd = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000266BC File Offset: 0x00024ABC
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000266D4 File Offset: 0x00024AD4
		public float StartDjup
		{
			get
			{
				return this.mStartDjup;
			}
			set
			{
				this.mStartDjup = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000266E0 File Offset: 0x00024AE0
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000266F8 File Offset: 0x00024AF8
		public float Djupet
		{
			get
			{
				return this.mDjupet;
			}
			set
			{
				this.mDjupet = value;
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00026704 File Offset: 0x00024B04
		public void Rita()
		{
			if (!this.Init)
			{
				return;
			}
			float Djup = this.mDjupet;
			this.mPicBox.CreateGraphics().Clear(this.mPicBox.BackColor);
			int totHöjd = this.mPicBox.Height;
			int totBredd = this.mPicBox.Width;
			bool VUnderYtan = false;
			if (Djup > 0f)
			{
				VUnderYtan = true;
			}
			float SkalFaktÖver = (float)this.JordYta / this.MastLängd;
			checked
			{
				float SkalFaktUnder = (float)(totHöjd - this.JordYta) / this.JordBotten;
				float SkalFaktBredd = (float)((double)totBredd / 1.0);
				int BreddRör = (int)Math.Round(unchecked(0.13 * (double)SkalFaktBredd));
				Point pktVerktygÖv = default(Point);
				Point pktVerktygUh = default(Point);
				Point pktRörÖv = default(Point);
				Point pktRörUh = default(Point);
				pktRörÖv.X = (int)Math.Round(unchecked((double)totBredd / 2.0 - (double)BreddRör / 2.0));
				pktRörUh.X = (int)Math.Round(unchecked((double)totBredd / 2.0 + (double)BreddRör / 2.0));
				if (!VUnderYtan)
				{
					pktVerktygÖv.X = (int)Math.Round(unchecked((double)totBredd / 2.0 - (double)(this.mVerktygsBredd * SkalFaktBredd / 3f)));
					pktVerktygUh.X = (int)Math.Round(unchecked((double)totBredd / 2.0 + (double)(this.mVerktygsBredd * SkalFaktBredd / 3f)));
					pktVerktygÖv.Y = (int)Math.Round((double)(unchecked((float)this.JordYta + Djup * SkalFaktÖver)));
					pktVerktygUh.Y = (int)Math.Round((double)(unchecked((float)this.JordYta + (Djup + this.mVerktygsHöjd) * SkalFaktÖver)));
					pktRörUh.Y = pktVerktygÖv.Y;
					pktRörÖv.Y = (int)Math.Round((double)(unchecked((float)pktVerktygUh.Y - this.mBorrLängd * SkalFaktÖver)));
				}
				else
				{
					pktVerktygÖv.X = (int)Math.Round(unchecked((double)totBredd / 2.0 - (double)(this.mVerktygsBredd * SkalFaktBredd / 2f)));
					pktVerktygUh.X = (int)Math.Round(unchecked((double)totBredd / 2.0 + (double)(this.mVerktygsBredd * SkalFaktBredd / 2f)));
					pktVerktygÖv.Y = (int)Math.Round((double)(unchecked((float)this.JordYta + Djup * SkalFaktUnder)));
					pktVerktygUh.Y = (int)Math.Round((double)(unchecked((float)this.JordYta + (Djup + this.mVerktygsHöjd) * SkalFaktUnder)));
					pktRörUh.Y = pktVerktygÖv.Y;
					pktRörÖv.Y = (int)Math.Round((double)(unchecked((float)this.JordYta - (this.mBorrLängd - Djup) * SkalFaktÖver)));
				}
				Point pktVlådaÖv = default(Point);
				Point pktVlådaUh = default(Point);
				Point pktMotorÖv = default(Point);
				Point pktMotorUh = default(Point);
				Point pktSvivelÖv = default(Point);
				Point pktSvivelUh = default(Point);
				pktVlådaÖv.X = (int)Math.Round(unchecked((double)totBredd / 2.0 - 0.1 * (double)SkalFaktBredd));
				pktVlådaÖv.Y = (int)Math.Round(unchecked((double)pktRörÖv.Y - 0.6 * (double)SkalFaktÖver));
				pktVlådaUh.X = (int)Math.Round(unchecked((double)totBredd / 2.0 + 0.1 * (double)SkalFaktBredd));
				pktVlådaUh.Y = pktRörÖv.Y;
				pktMotorUh.X = (int)Math.Round(unchecked((double)totBredd / 2.0 + 0.2 * (double)SkalFaktBredd));
				pktMotorUh.Y = pktVlådaÖv.Y;
				pktMotorÖv.X = (int)Math.Round(unchecked((double)totBredd / 2.0 - 0.2 * (double)SkalFaktBredd));
				pktMotorÖv.Y = (int)Math.Round(unchecked((double)pktVlådaÖv.Y - 1.2 * (double)SkalFaktÖver));
				pktSvivelUh.X = (int)Math.Round(unchecked((double)totBredd / 2.0 + 0.07 * (double)SkalFaktBredd));
				pktSvivelUh.Y = pktMotorÖv.Y;
				pktSvivelÖv.X = (int)Math.Round(unchecked((double)totBredd / 2.0 - 0.07 * (double)SkalFaktBredd));
				pktSvivelÖv.Y = (int)Math.Round(unchecked((double)pktSvivelUh.Y - 0.6 * (double)SkalFaktÖver));
				Rectangle rectVerktyg = new Rectangle(pktVerktygÖv.X, pktVerktygÖv.Y, pktVerktygUh.X - pktVerktygÖv.X, pktVerktygUh.Y - pktVerktygÖv.Y);
				Pen StoppPen = new Pen(Color.Red);
				StoppPen.Width = 1f;
				int StoppDjupInt = (int)Math.Round((double)(unchecked((float)this.JordYta + this.mStoppDjup * SkalFaktUnder)));
				this.mPicBox.CreateGraphics().DrawLine(StoppPen, 0, StoppDjupInt, totBredd, StoppDjupInt);
				Pen Jordpen = new Pen(Color.Brown);
				Jordpen.Width = 2f;
				this.mPicBox.CreateGraphics().DrawLine(Jordpen, 0, this.JordYta, totBredd, this.JordYta);
				GraphicsPath pathRörV = new GraphicsPath();
				GraphicsPath pathRörH = new GraphicsPath();
				GraphicsPath pathLådaV = new GraphicsPath();
				GraphicsPath pathLådaH = new GraphicsPath();
				GraphicsPath pathMotorV = new GraphicsPath();
				GraphicsPath pathMotorH = new GraphicsPath();
				GraphicsPath pathSvivelV = new GraphicsPath();
				GraphicsPath pathSvivelH = new GraphicsPath();
				GraphicsPath pathStommeV = new GraphicsPath();
				GraphicsPath pathStommeH = new GraphicsPath();
				Point pktStommeÖv = new Point((int)Math.Round(unchecked((double)totBredd / 2.0 - 4.0)), pktVerktygÖv.Y);
				Point pktStommeÖm = new Point((int)Math.Round(unchecked((double)totBredd / 2.0 - 2.0)), pktVerktygÖv.Y);
				Point pktStommeÖh = new Point((int)Math.Round(unchecked((double)totBredd / 2.0 + 4.0)), pktVerktygÖv.Y);
				Rectangle rectStommeV = new Rectangle(pktStommeÖv.X, pktStommeÖv.Y, pktStommeÖm.X - pktStommeÖv.X, pktVerktygUh.Y - pktStommeÖv.Y);
				Rectangle rectStommeH = new Rectangle(pktStommeÖm.X, pktStommeÖm.Y, pktStommeÖh.X - pktStommeÖm.X, pktVerktygUh.Y - pktStommeÖm.Y);
				pathStommeV.AddRectangle(rectStommeV);
				pathStommeH.AddRectangle(rectStommeH);
				Point pktRörÖm = new Point((int)Math.Round(unchecked((double)pktRörÖv.X + 0.3 * (double)BreddRör)), pktRörÖv.Y);
				Point pktRörÖh = new Point(pktRörUh.X, pktRörÖv.Y);
				Point pktVLådaÖm = new Point((int)Math.Round(unchecked((double)pktVlådaÖv.X + 0.3 * (double)(checked(pktVlådaUh.X - pktVlådaÖv.X)))), pktVlådaÖv.Y);
				Point pktVLådaÖh = new Point(pktVlådaUh.X, pktVlådaÖv.Y);
				Point pktMotorÖm = new Point((int)Math.Round(unchecked((double)pktMotorÖv.X + 0.3 * (double)(checked(pktMotorUh.X - pktMotorÖv.X)))), pktMotorÖv.Y);
				Point pktMotorÖh = new Point(pktMotorUh.X, pktMotorÖv.Y);
				Point pktSvivelÖm = new Point((int)Math.Round(unchecked((double)pktSvivelÖv.X + 0.3 * (double)(checked(pktSvivelUh.X - pktSvivelÖv.X)))), pktSvivelÖv.Y);
				Point pktSvivelÖh = new Point(pktSvivelUh.X, pktSvivelÖv.Y);
				Rectangle rörRectV = new Rectangle(pktRörÖv.X, pktRörÖv.Y, pktRörÖm.X - pktRörÖv.X, pktRörUh.Y - pktRörÖh.Y);
				Rectangle rörRectH = new Rectangle(pktRörÖm.X, pktRörÖm.Y, pktRörÖh.X - pktRörÖm.X, pktRörUh.Y - pktRörÖh.Y);
				pathRörV.AddRectangle(rörRectV);
				pathRörH.AddRectangle(rörRectH);
				Rectangle vlådaRectV = new Rectangle(pktVlådaÖv.X, pktVlådaÖv.Y, pktVLådaÖm.X - pktVlådaÖv.X, pktVlådaUh.Y - pktVLådaÖh.Y);
				Rectangle vlådaRectH = new Rectangle(pktVLådaÖm.X, pktVLådaÖm.Y, pktVLådaÖh.X - pktVLådaÖm.X, pktVlådaUh.Y - pktVLådaÖh.Y);
				pathLådaV.AddRectangle(vlådaRectV);
				pathLådaH.AddRectangle(vlådaRectH);
				Rectangle motorRectV = new Rectangle(pktMotorÖv.X, pktMotorÖv.Y, pktMotorÖm.X - pktMotorÖv.X, pktMotorUh.Y - pktMotorÖh.Y);
				Rectangle motorRectH = new Rectangle(pktMotorÖm.X, pktMotorÖm.Y, pktMotorÖh.X - pktMotorÖm.X, pktMotorUh.Y - pktMotorÖh.Y);
				pathMotorV.AddRectangle(motorRectV);
				pathMotorH.AddRectangle(motorRectH);
				Rectangle svivelRectV = new Rectangle(pktSvivelÖv.X, pktSvivelÖv.Y, pktSvivelÖm.X - pktSvivelÖv.X, pktSvivelUh.Y - pktSvivelÖh.Y);
				Rectangle svivelRectH = new Rectangle(pktSvivelÖm.X, pktSvivelÖm.Y, pktSvivelÖh.X - pktSvivelÖm.X, pktSvivelUh.Y - pktSvivelÖh.Y);
				pathSvivelV.AddRectangle(svivelRectV);
				pathSvivelH.AddRectangle(svivelRectH);
				Color Färg = default(Color);
				Color Färg2 = default(Color);
				Färg = Color.LightGray;
				Färg2 = Color.DarkSlateGray;
				Pen Pen = new Pen(Color.White);
				Pen.Width = 1f;
				Pen Pen2 = new Pen(Färg2);
				Pen2.Width = 2f;
				LinearGradientBrush PenselRörV = new LinearGradientBrush(pktRörÖv, pktRörÖm, Färg2, Färg);
				LinearGradientBrush PenselRörH = new LinearGradientBrush(pktRörÖm, pktRörÖh, Färg, Färg2);
				LinearGradientBrush PenselLådaV = new LinearGradientBrush(pktVlådaÖv, pktVLådaÖm, Färg2, Färg);
				LinearGradientBrush PenselLådaH = new LinearGradientBrush(pktVLådaÖm, pktVLådaÖh, Färg, Färg2);
				LinearGradientBrush PenselmotorV = new LinearGradientBrush(pktMotorÖv, pktMotorÖm, Färg2, Färg);
				LinearGradientBrush PenselmotorH = new LinearGradientBrush(pktMotorÖm, pktMotorÖh, Färg, Färg2);
				LinearGradientBrush PenselsvivelV = new LinearGradientBrush(pktSvivelÖv, pktSvivelÖm, Färg2, Färg);
				LinearGradientBrush PenselsvivelH = new LinearGradientBrush(pktSvivelÖm, pktSvivelÖh, Färg, Färg2);
				LinearGradientBrush PenselStommeV = new LinearGradientBrush(pktStommeÖv, pktStommeÖm, Färg2, Färg);
				LinearGradientBrush PenselStommeH = new LinearGradientBrush(pktStommeÖm, pktStommeÖh, Färg, Färg2);
				this.mPicBox.CreateGraphics().FillPath(PenselRörV, pathRörV);
				this.mPicBox.CreateGraphics().FillPath(PenselRörH, pathRörH);
				this.mPicBox.CreateGraphics().FillPath(PenselLådaV, pathLådaV);
				this.mPicBox.CreateGraphics().FillPath(PenselLådaH, pathLådaH);
				this.mPicBox.CreateGraphics().FillPath(PenselmotorV, pathMotorV);
				this.mPicBox.CreateGraphics().FillPath(PenselmotorH, pathMotorH);
				this.mPicBox.CreateGraphics().FillPath(PenselsvivelV, pathSvivelV);
				this.mPicBox.CreateGraphics().FillPath(PenselsvivelH, pathSvivelH);
				this.mPicBox.CreateGraphics().FillPath(PenselStommeV, pathStommeV);
				this.mPicBox.CreateGraphics().FillPath(PenselStommeH, pathStommeH);
				int ÖvreHöjd = (int)Math.Round(unchecked((double)pktVerktygÖv.Y + (double)rectVerktyg.Height * 0.25));
				int UndreHöjd = (int)Math.Round(unchecked((double)pktVerktygÖv.Y + (double)rectVerktyg.Height * 0.75));
				this.mPicBox.CreateGraphics().DrawLine(Pen, pktVerktygÖv.X, ÖvreHöjd, pktStommeÖv.X, ÖvreHöjd);
				this.mPicBox.CreateGraphics().DrawLine(Pen2, pktVerktygÖv.X, ÖvreHöjd + 2, pktStommeÖv.X, ÖvreHöjd + 2);
				int UndreXstart = (int)Math.Round((double)(pktStommeÖv.X + pktVerktygÖv.X) / 2.0);
				this.mPicBox.CreateGraphics().DrawLine(Pen, UndreXstart, UndreHöjd, pktStommeÖv.X, UndreHöjd);
				this.mPicBox.CreateGraphics().DrawLine(Pen2, UndreXstart, UndreHöjd + 2, pktStommeÖv.X, UndreHöjd + 2);
				this.mPicBox.CreateGraphics().DrawLine(Pen, pktStommeÖh.X, ÖvreHöjd, pktVerktygUh.X, ÖvreHöjd);
				this.mPicBox.CreateGraphics().DrawLine(Pen2, pktStommeÖh.X, ÖvreHöjd + 2, pktVerktygUh.X, ÖvreHöjd + 2);
				int UndreXslut = (int)Math.Round((double)(pktStommeÖh.X + pktVerktygUh.X) / 2.0);
				this.mPicBox.CreateGraphics().DrawLine(Pen, pktStommeÖh.X, UndreHöjd, UndreXslut, UndreHöjd);
				this.mPicBox.CreateGraphics().DrawLine(Pen2, pktStommeÖh.X, UndreHöjd + 2, UndreXslut, UndreHöjd + 2);
				this.TryckLabelPlacering();
				this.RpmLabelPlacering(rörRectV.Top, (int)Math.Round(unchecked((double)this.mPicBox.Width / 2.0 - (double)rörRectV.X + 2.0)));
				string djupStr = Strings.Format(Djup, "0.00");
				string djupStrV = " ";
				string djupStrH = Strings.Right(djupStr, 2);
				if (Strings.Len(djupStr) == 4)
				{
					djupStrV = Strings.Left(djupStr, 1);
				}
				if (Strings.Len(djupStr) == 5)
				{
					djupStrV = Strings.Left(djupStr, 2);
				}
				if (Strings.Len(djupStr) == 6)
				{
					djupStrV = Strings.Left(djupStr, 3);
				}
				djupStrV += ".";
				djupStrH += "m";
				this.mlblDjupV.Text = djupStrV;
				this.mlblDjupH.Text = djupStrH;
				this.djupLabelPlacering(rectVerktyg.Top - this.mlblDjupV.Height - 2, (int)Math.Round(unchecked((double)BreddRör / 2.0 + 2.0)));
				this.mPicBox.CreateGraphics().Flush();
				this.Rörpic.Height = pktSvivelÖv.Y;
				this.mVrör.tryck = this.mVrör.tryck;
				StoppPen.Dispose();
				Jordpen.Dispose();
				Pen.Dispose();
				Pen2.Dispose();
				PenselRörV.Dispose();
				PenselRörH.Dispose();
				PenselLådaV.Dispose();
				PenselmotorV.Dispose();
				PenselmotorH.Dispose();
				PenselLådaH.Dispose();
				PenselsvivelV.Dispose();
				PenselsvivelH.Dispose();
				PenselStommeV.Dispose();
				PenselStommeH.Dispose();
				this.mPicBox.CreateGraphics().Dispose();
			}
		}

		// Token: 0x0400000D RID: 13
		private PictureBox mPicBox;

		// Token: 0x0400000E RID: 14
		private int mJordYta;

		// Token: 0x0400000F RID: 15
		private float MastLängd;

		// Token: 0x04000010 RID: 16
		private bool Init;

		// Token: 0x04000011 RID: 17
		private RitaRörV mVrör;

		// Token: 0x04000012 RID: 18
		private PictureBox Rörpic;

		// Token: 0x04000013 RID: 19
		private float mBorrLängd;

		// Token: 0x04000014 RID: 20
		private float mJordBotten;

		// Token: 0x04000015 RID: 21
		private float mStoppDjup;

		// Token: 0x04000016 RID: 22
		private float mVerktygsHöjd;

		// Token: 0x04000017 RID: 23
		private bool mVisaMeter;

		// Token: 0x04000018 RID: 24
		private float mVerktygsBredd;

		// Token: 0x04000019 RID: 25
		private int mRotation;

		// Token: 0x0400001A RID: 26
		private float mStartDjup;

		// Token: 0x0400001B RID: 27
		private Label mlblTryck;

		// Token: 0x0400001C RID: 28
		private Label mlblBar;

		// Token: 0x0400001D RID: 29
		private Label mlblRot;

		// Token: 0x0400001E RID: 30
		private Label mlblRpm;

		// Token: 0x0400001F RID: 31
		private Label mlblDjupV;

		// Token: 0x04000020 RID: 32
		private Label mlblDjupH;

		// Token: 0x04000021 RID: 33
		private float mDjupet;
	}
}
