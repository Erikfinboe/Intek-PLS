using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x02000018 RID: 24
	public class RitaRörH
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x00030054 File Offset: 0x0002E454
		public RitaRörH()
		{
			this.mRörVidd = 25;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00030064 File Offset: 0x0002E464
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0003007C File Offset: 0x0002E47C
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

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00030098 File Offset: 0x0002E498
		// (set) Token: 0x060003BD RID: 957 RVA: 0x000300A8 File Offset: 0x0002E4A8
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

		// Token: 0x060003BE RID: 958 RVA: 0x000300D0 File Offset: 0x0002E4D0
		public void Rita()
		{
			if (!this.Init)
			{
				return;
			}
			this.mRörVidd = this.mPicBox.Height;
			this.mVidd = this.mPicBox.Width;
			checked
			{
				Point pktÖ = new Point((int)Math.Round((double)this.mVidd / 2.0), 0);
				Point pktU = new Point((int)Math.Round((double)this.mVidd / 2.0), this.mRörVidd);
				GraphicsPath pathRakH = new GraphicsPath();
				Rectangle rekt = new Rectangle(0, 0, this.mVidd, this.mRörVidd);
				pathRakH.AddRectangle(rekt);
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
				LinearGradientBrush pensel = new LinearGradientBrush(pktÖ, pktU, Färg, Färg2);
				this.mPicBox.CreateGraphics().FillPath(pensel, pathRakH);
				this.mPicBox.CreateGraphics().Dispose();
				pensel.Dispose();
			}
		}

		// Token: 0x04000267 RID: 615
		private PictureBox mPicBox;

		// Token: 0x04000268 RID: 616
		private bool Init;

		// Token: 0x04000269 RID: 617
		private bool mTryck;

		// Token: 0x0400026A RID: 618
		private int mVidd;

		// Token: 0x0400026B RID: 619
		private int mRörVidd;
	}
}
