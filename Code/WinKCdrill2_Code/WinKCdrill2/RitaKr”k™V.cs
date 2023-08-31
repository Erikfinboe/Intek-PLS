using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x02000017 RID: 23
	public class RitaKrökÖV
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x0002FEA8 File Offset: 0x0002E2A8
		public RitaKrökÖV()
		{
			this.mRörVidd = 25;
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0002FEB8 File Offset: 0x0002E2B8
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x0002FED0 File Offset: 0x0002E2D0
		public PictureBox PicBox
		{
			get
			{
				return this.mPicBox;
			}
			set
			{
				this.mPicBox = value;
				this.Init = true;
				this.mPicBox.BorderStyle = BorderStyle.None;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0002FEEC File Offset: 0x0002E2EC
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0002FEFC File Offset: 0x0002E2FC
		public float tryck
		{
			get
			{
				float tryck = 0.0f;
				return tryck;
			}
			set
			{
				if ((double)value < 0.1)
				{
					this.mTryck = false;
				}
				else
				{
					this.mTryck = true;
				}
				this.Rita();
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0002FF24 File Offset: 0x0002E324
		public void Rita()
		{
			if (!this.Init)
			{
				return;
			}
			if (this.mPicBox.Height == 0 | this.mPicBox.Width == 0)
			{
				return;
			}
			GraphicsPath pathRakH = new GraphicsPath();
			pathRakH.AddArc(0, 0, this.mPicBox.Width, this.mPicBox.Height, 0f, 90f);
			pathRakH.AddLine(0, this.mPicBox.Height, 0, 0);
			pathRakH.AddLine(0, 0, this.mPicBox.Width, 0);
			pathRakH.CloseFigure();
			PathGradientBrush pthGrBrush = new PathGradientBrush(pathRakH);
			Color Färg;
			Color Färg2;
			if (!this.mTryck)
			{
				Färg = Color.Khaki;
				Färg2 = Color.DarkKhaki;
			}
			else
			{
				Färg = Color.LightGoldenrodYellow;
				Färg2 = Color.Goldenrod;
			}
			Color[] FärgY = new Color[]
			{
				Färg2
			};
			PointF center = new PointF(0f, 0f);
			pthGrBrush.SurroundColors = FärgY;
			pthGrBrush.CenterPoint = center;
			pthGrBrush.CenterColor = Färg;
			this.mPicBox.CreateGraphics().FillPath(pthGrBrush, pathRakH);
			this.mPicBox.CreateGraphics().Dispose();
			pthGrBrush.Dispose();
		}

		// Token: 0x04000262 RID: 610
		private PictureBox mPicBox;

		// Token: 0x04000263 RID: 611
		private bool Init;

		// Token: 0x04000264 RID: 612
		private bool mTryck;

		// Token: 0x04000265 RID: 613
		private int mHöjd;

		// Token: 0x04000266 RID: 614
		private int mRörVidd;
	}
}
