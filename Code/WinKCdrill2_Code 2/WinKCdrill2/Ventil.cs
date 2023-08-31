using System;
using System.Drawing;
using System.Windows.Forms;

namespace winKCdrill2
{
	// Token: 0x0200001C RID: 28
	public class Ventil
	{
		// Token: 0x060003F6 RID: 1014 RVA: 0x00032498 File Offset: 0x00030898
		public void Lägen(bool Öppen, bool Stängd)
		{
			if (Öppen & !Stängd)
			{
				this.mPicBox.Left = this.mVänsterÖ;
				this.mPicBox.Top = this.mToppÖ;
				this.mPicBox.Width = this.mBreddÖ;
				this.mPicBox.Height = this.mHöjdÖ;
				this.mPicBox.BackColor = Color.LightGreen;
				this.MtoolTip.SetToolTip(this.mPicBox, this.mValvNamn + " Valve Open");
				return;
			}
			if (!Öppen && Stängd)
			{
				this.mPicBox.Left = this.mVänsterS;
				this.mPicBox.Top = this.mToppS;
				this.mPicBox.Width = this.mBreddS;
				this.mPicBox.Height = this.mHöjdS;
				this.mPicBox.BackColor = Color.IndianRed;
				this.MtoolTip.SetToolTip(this.mPicBox, this.mValvNamn + " Valve Close");
				return;
			}
			this.mPicBox.Left = this.mVänsterM;
			this.mPicBox.Top = this.mToppM;
			this.mPicBox.Width = this.mBreddM;
			this.mPicBox.Height = this.mHöjdM;
			this.mPicBox.BackColor = Color.LightYellow;
			if (!Öppen & !Stängd)
			{
				this.MtoolTip.SetToolTip(this.mPicBox, this.mValvNamn + " Valve Neither open nor Closed");
			}
			else
			{
				this.MtoolTip.SetToolTip(this.mPicBox, this.mValvNamn + " Valve Both open and Closed");
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00032644 File Offset: 0x00030A44
		public void InitValve(ref PictureBox PicBox, bool VertikalRör, ref ToolTip Toltips, string ValvNamn)
		{
			if (this.mInit)
			{
				return;
			}
			this.mPicBox = PicBox;
			this.mVert = VertikalRör;
			this.MtoolTip = Toltips;
			this.mValvNamn = ValvNamn;
			this.mPicBox.BorderStyle = BorderStyle.FixedSingle;
			this.mPicBox.BringToFront();
			checked
			{
				if (this.mVert)
				{
					this.mVänsterÖ = this.mPicBox.Left + this.mPicBox.Width;
					this.mToppÖ = this.mPicBox.Top;
					this.mBreddÖ = this.mPicBox.Width * 2;
					this.mHöjdÖ = this.mPicBox.Height;
					this.mVänsterM = (int)Math.Round(unchecked((double)this.mPicBox.Left + (double)this.mPicBox.Width / 2.0));
					this.mToppM = this.mToppÖ;
					this.mBreddM = this.mBreddÖ;
					this.mHöjdM = this.mHöjdÖ;
					this.mVänsterS = this.mPicBox.Left;
					this.mToppS = this.mToppÖ;
					this.mBreddS = this.mBreddÖ;
					this.mHöjdS = this.mHöjdÖ;
				}
				else
				{
					this.mVänsterÖ = this.mPicBox.Left;
					this.mToppÖ = this.mPicBox.Top - this.mPicBox.Height * 2;
					this.mBreddÖ = this.mPicBox.Width;
					this.mHöjdÖ = this.mPicBox.Height * 2;
					this.mVänsterM = this.mVänsterÖ;
					this.mToppM = (int)Math.Round(unchecked((double)this.mPicBox.Top - 1.5 * (double)this.mPicBox.Height));
					this.mBreddM = this.mBreddÖ;
					this.mHöjdM = this.mHöjdÖ;
					this.mVänsterS = this.mVänsterÖ;
					this.mToppS = this.mPicBox.Top - this.mPicBox.Height;
					this.mBreddS = this.mBreddÖ;
					this.mHöjdS = this.mHöjdÖ;
				}
				this.mInit = true;
			}
		}

		// Token: 0x040002C3 RID: 707
		private bool mVert;

		// Token: 0x040002C4 RID: 708
		private PictureBox mPicBox;

		// Token: 0x040002C5 RID: 709
		private bool mInit;

		// Token: 0x040002C6 RID: 710
		private ToolTip MtoolTip;

		// Token: 0x040002C7 RID: 711
		private string mValvNamn;

		// Token: 0x040002C8 RID: 712
		private int mVänsterÖ;

		// Token: 0x040002C9 RID: 713
		private int mToppÖ;

		// Token: 0x040002CA RID: 714
		private int mBreddÖ;

		// Token: 0x040002CB RID: 715
		private int mHöjdÖ;

		// Token: 0x040002CC RID: 716
		private int mVänsterS;

		// Token: 0x040002CD RID: 717
		private int mToppS;

		// Token: 0x040002CE RID: 718
		private int mBreddS;

		// Token: 0x040002CF RID: 719
		private int mHöjdS;

		// Token: 0x040002D0 RID: 720
		private int mVänsterM;

		// Token: 0x040002D1 RID: 721
		private int mToppM;

		// Token: 0x040002D2 RID: 722
		private int mBreddM;

		// Token: 0x040002D3 RID: 723
		private int mHöjdM;
	}
}
