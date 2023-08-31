using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x02000016 RID: 22
	public class RitaKrökÖH
	{
		// Token: 0x060003AD RID: 941 RVA: 0x0002FCE0 File Offset: 0x0002E0E0
		public RitaKrökÖH()
		{
			this.mRörVidd = 25;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0002FCF0 File Offset: 0x0002E0F0
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0002FD08 File Offset: 0x0002E108
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

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0002FD24 File Offset: 0x0002E124
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x0002FD34 File Offset: 0x0002E134
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

		// Token: 0x060003B2 RID: 946 RVA: 0x0002FD5C File Offset: 0x0002E15C
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
			pathRakH.AddArc(0, 0, this.mPicBox.Width, this.mPicBox.Height, 90f, 90f);
			pathRakH.AddLine(0, 0, this.mPicBox.Width, 0);
			pathRakH.AddLine(this.mPicBox.Width, 0, this.mPicBox.Width, this.mPicBox.Height);
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
				Färg
			};
			PointF center = new PointF((float)this.mPicBox.Width, 0f);
			pthGrBrush.SurroundColors = FärgY;
			pthGrBrush.CenterPoint = center;
			pthGrBrush.CenterColor = Färg2;
			this.mPicBox.CreateGraphics().FillPath(pthGrBrush, pathRakH);
			this.mPicBox.CreateGraphics().Dispose();
			pthGrBrush.Dispose();
		}

		// Token: 0x0400025E RID: 606
		private PictureBox mPicBox;

		// Token: 0x0400025F RID: 607
		private bool mTryck;

		// Token: 0x04000260 RID: 608
		private int mRörVidd;

		// Token: 0x04000261 RID: 609
		private bool Init;
	}
}
