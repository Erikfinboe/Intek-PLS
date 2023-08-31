using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x02000009 RID: 9
	public class Cellmatare
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00027558 File Offset: 0x00025958
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00027570 File Offset: 0x00025970
		public float CellFart
		{
			get
			{
				return this.mCellFart;
			}
			set
			{
				this.mCellFart = value;
				if ((double)this.mCellFart > 0.1)
				{
					this.mSnurrar = true;
				}
				else
				{
					this.mSnurrar = false;
				}
				this.Rita();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000275A4 File Offset: 0x000259A4
		// (set) Token: 0x06000046 RID: 70 RVA: 0x000275BC File Offset: 0x000259BC
		public PictureBox PicBox
		{
			get
			{
				return this.mPicBox;
			}
			set
			{
				this.mPicBox = value;
				this.mInitierad = true;
				this.Rita();
				this.mPicBox.BorderStyle = BorderStyle.None;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000275E0 File Offset: 0x000259E0
		private void Rita()
		{
			if (!this.mInitierad)
			{
				return;
			}
			if (this.mPicBox.Height == 0 | this.mPicBox.Width == 0)
			{
				return;
			}
			int Höjd = this.mPicBox.Height;
			int Bredd = this.mPicBox.Width;
			int MellanFack = 4;
			checked
			{
				int FackHöjd;
				int AntalSnurr;
				if (Höjd > 7)
				{
					FackHöjd = (int)Math.Round((double)(Höjd - 2 * MellanFack) / 3.0);
					AntalSnurr = FackHöjd + 1;
				}
				else
				{
					FackHöjd = 0;
					AntalSnurr = 0;
				}
				if (this.mSnurrar)
				{
					if (this.STATIC_Rita_2001_SnurrLäge == AntalSnurr)
					{
						this.STATIC_Rita_2001_SnurrLäge = 0;
					}
					else
					{
						this.STATIC_Rita_2001_SnurrLäge++;
					}
				}
				else
				{
					this.STATIC_Rita_2001_SnurrLäge = 0;
				}
				int FackBredd;
				int VsidaFack;
				if (Bredd > 4)
				{
					FackBredd = Bredd - 7;
					VsidaFack = 3;
				}
				else
				{
					FackBredd = 0;
					VsidaFack = 0;
				}
				GraphicsPath pathCelliÖ = new GraphicsPath();
				GraphicsPath pathCellÖ = new GraphicsPath();
				GraphicsPath pathCellM = new GraphicsPath();
				GraphicsPath pathCellU = new GraphicsPath();
				GraphicsPath pathMataren = new GraphicsPath();
				int ÖFackTop = this.STATIC_Rita_2001_SnurrLäge;
				int IfackTop = ÖFackTop - MellanFack - FackHöjd;
				int MFackTop = ÖFackTop + MellanFack + FackHöjd;
				int UFackTop = MFackTop + MellanFack + FackHöjd;
				Rectangle rectMatare = new Rectangle(0, 0, Bredd, Höjd);
				Rectangle rectiÖvre = new Rectangle(VsidaFack, IfackTop, FackBredd, FackHöjd);
				Rectangle rectCÖvre = new Rectangle(VsidaFack, ÖFackTop, FackBredd, FackHöjd);
				Rectangle rectCMellan = new Rectangle(VsidaFack, MFackTop, FackBredd, FackHöjd);
				Rectangle rectCUndre = new Rectangle(VsidaFack, UFackTop, FackBredd, FackHöjd);
				int MatarMitt = (int)Math.Round((double)Bredd / 2.0);
				Point pktÖMatare = new Point((int)Math.Round((double)Bredd / 2.0), 0);
				Point pktUMatare = new Point((int)Math.Round((double)Bredd / 2.0), Höjd);
				Point pktiFackÖ = new Point(MatarMitt, IfackTop);
				Point pktiFackU = new Point(MatarMitt, IfackTop + FackHöjd);
				Point pktÖFackÖ = new Point(MatarMitt, ÖFackTop);
				Point pktÖFackU = new Point(MatarMitt, ÖFackTop + FackHöjd);
				Point pktMFackÖ = new Point(MatarMitt, MFackTop);
				Point pktMFackU = new Point(MatarMitt, MFackTop + FackHöjd);
				Point pktUFackÖ = new Point(MatarMitt, UFackTop);
				Point pktUFackU = new Point(MatarMitt, UFackTop + FackHöjd);
				Color FärgÖMatare = Color.LightGray;
				Color FärgUMatare = Color.DarkSlateGray;
				FärgÖMatare = Color.FromArgb(100, (int)FärgÖMatare.R, (int)FärgÖMatare.G, (int)FärgÖMatare.B);
				FärgUMatare = Color.FromArgb(100, (int)FärgUMatare.R, (int)FärgUMatare.G, (int)FärgUMatare.B);
				Color FärgÖFack = Color.LightGoldenrodYellow;
				Color FärgUFack = Color.Green;
				pathMataren.AddRectangle(rectMatare);
				pathCelliÖ.AddRectangle(rectiÖvre);
				pathCellÖ.AddRectangle(rectCÖvre);
				pathCellM.AddRectangle(rectCMellan);
				pathCellU.AddRectangle(rectCUndre);
				LinearGradientBrush PenselMatare = new LinearGradientBrush(pktÖMatare, pktUMatare, FärgÖMatare, FärgUMatare);
				LinearGradientBrush PenselFackiÖ = new LinearGradientBrush(pktiFackÖ, pktiFackU, FärgÖFack, FärgUFack);
				LinearGradientBrush PenselFackÖ = new LinearGradientBrush(pktÖFackÖ, pktÖFackU, FärgÖFack, FärgUFack);
				LinearGradientBrush PenselFackM = new LinearGradientBrush(pktMFackÖ, pktMFackU, FärgÖFack, FärgUFack);
				LinearGradientBrush PenselFackU = new LinearGradientBrush(pktUFackÖ, pktUFackU, FärgÖFack, FärgUFack);
				this.mPicBox.CreateGraphics().FillPath(PenselFackiÖ, pathCelliÖ);
				this.mPicBox.CreateGraphics().FillPath(PenselFackÖ, pathCellÖ);
				this.mPicBox.CreateGraphics().FillPath(PenselFackM, pathCellM);
				this.mPicBox.CreateGraphics().FillPath(PenselFackU, pathCellU);
				this.mPicBox.CreateGraphics().FillPath(PenselMatare, pathMataren);
				this.mPicBox.CreateGraphics().Dispose();
				PenselMatare.Dispose();
				PenselFackiÖ.Dispose();
				PenselFackÖ.Dispose();
				PenselFackM.Dispose();
				PenselFackU.Dispose();
			}
		}

		// Token: 0x04000022 RID: 34
		private PictureBox mPicBox;

		// Token: 0x04000023 RID: 35
		private bool mInitierad;

		// Token: 0x04000024 RID: 36
		private float mCellFart;

		// Token: 0x04000025 RID: 37
		private bool mSnurrar;

		// Token: 0x04000026 RID: 38
		private int STATIC_Rita_2001_SnurrLäge;
	}
}
