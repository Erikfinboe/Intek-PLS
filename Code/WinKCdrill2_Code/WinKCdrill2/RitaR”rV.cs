using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x02000019 RID: 25
	public class RitaRörV
	{
		// Token: 0x060003BF RID: 959 RVA: 0x000301C4 File Offset: 0x0002E5C4
		public RitaRörV()
		{
			this.mRörVidd = 25;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x000301D4 File Offset: 0x0002E5D4
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x000301EC File Offset: 0x0002E5EC
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

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00030208 File Offset: 0x0002E608
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00030220 File Offset: 0x0002E620
		public float tryck
		{
			get
			{
				return this.mTryck;
			}
			set
			{
				this.mTryck = value;
				if ((double)value < 0.1)
				{
					this.mTryckHög = false;
				}
				else
				{
					this.mTryckHög = true;
				}
				this.Rita();
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0003024C File Offset: 0x0002E64C
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
			this.mHöjd = this.mPicBox.Height;
			this.mRörVidd = this.mPicBox.Width;
			checked
			{
				Point pktÖ = new Point(0, (int)Math.Round((double)this.mHöjd / 2.0));
				Point pktU = new Point(this.mRörVidd, (int)Math.Round((double)this.mHöjd / 2.0));
				GraphicsPath pathRakH = new GraphicsPath();
				Rectangle rekt = new Rectangle(0, 0, this.mRörVidd, this.mHöjd);
				pathRakH.AddRectangle(rekt);
				Color Färg;
				Color Färg2;
				if (!this.mTryckHög)
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

		// Token: 0x0400026C RID: 620
		private PictureBox mPicBox;

		// Token: 0x0400026D RID: 621
		private bool mTryckHög;

		// Token: 0x0400026E RID: 622
		private float mTryck;

		// Token: 0x0400026F RID: 623
		private int mHöjd;

		// Token: 0x04000270 RID: 624
		private int mRörVidd;

		// Token: 0x04000271 RID: 625
		private bool Init;
	}
}
