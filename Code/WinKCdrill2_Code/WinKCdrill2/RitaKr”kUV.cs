using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x02000015 RID: 21
	public class RitaKrökUV
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0002FB48 File Offset: 0x0002DF48
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0002FB60 File Offset: 0x0002DF60
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

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0002FB7C File Offset: 0x0002DF7C
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0002FB8C File Offset: 0x0002DF8C
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

		// Token: 0x060003AC RID: 940 RVA: 0x0002FBB4 File Offset: 0x0002DFB4
		public void Rita()
		{
			if (!this.Init)
			{
				return;
			}
			GraphicsPath pathRakH = new GraphicsPath();
			pathRakH.AddArc(0, 0, this.mPicBox.Width, this.mPicBox.Height, 270f, 90f);
			pathRakH.AddLine(this.mPicBox.Width, this.mPicBox.Height, 0, this.mPicBox.Height);
			pathRakH.AddLine(0, this.mPicBox.Height, 0, 0);
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
			PointF center = new PointF(0f, (float)this.mPicBox.Height);
			pthGrBrush.SurroundColors = FärgY;
			pthGrBrush.CenterPoint = center;
			pthGrBrush.CenterColor = Färg2;
			this.mPicBox.CreateGraphics().FillPath(pthGrBrush, pathRakH);
			this.mPicBox.CreateGraphics().Dispose();
			pthGrBrush.Dispose();
		}

		// Token: 0x0400025B RID: 603
		private PictureBox mPicBox;

		// Token: 0x0400025C RID: 604
		private bool mTryck;

		// Token: 0x0400025D RID: 605
		private bool Init;
	}
}
