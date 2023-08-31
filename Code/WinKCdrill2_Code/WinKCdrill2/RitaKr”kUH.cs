using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x02000014 RID: 20
	public class RitaKrökUH
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0002F96C File Offset: 0x0002DD6C
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x0002F984 File Offset: 0x0002DD84
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

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0002F9A0 File Offset: 0x0002DDA0
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0002F9B0 File Offset: 0x0002DDB0
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

		// Token: 0x060003A6 RID: 934 RVA: 0x0002F9D8 File Offset: 0x0002DDD8
		public void Rita()
		{
			if (!this.Init)
			{
				return;
			}
			if (this.mPicBox.Width == 0 | this.mPicBox.Height == 0)
			{
				return;
			}
			GraphicsPath pathRakH = new GraphicsPath();
			pathRakH.AddArc(0, 0, this.mPicBox.Width, this.mPicBox.Height, 180f, 90f);
			pathRakH.AddLine(this.mPicBox.Width, 0, this.mPicBox.Width, this.mPicBox.Height);
			pathRakH.AddLine(this.mPicBox.Width, this.mPicBox.Height, 0, this.mPicBox.Height);
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
			PointF center = new PointF((float)this.PicBox.Width, (float)this.PicBox.Height);
			pthGrBrush.SurroundColors = FärgY;
			pthGrBrush.CenterPoint = center;
			pthGrBrush.CenterColor = Färg2;
			this.mPicBox.CreateGraphics().FillPath(pthGrBrush, pathRakH);
			this.mPicBox.CreateGraphics().Dispose();
			pthGrBrush.Dispose();
		}

		// Token: 0x04000256 RID: 598
		private PictureBox mPicBox;

		// Token: 0x04000257 RID: 599
		private bool mTryck;

		// Token: 0x04000258 RID: 600
		private int mHöjd;

		// Token: 0x04000259 RID: 601
		private int mRörVidd;

		// Token: 0x0400025A RID: 602
		private bool Init;
	}
}
