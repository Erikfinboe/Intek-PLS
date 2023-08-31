using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using winKCdrill2.My;

namespace winKCdrill2
{
	// Token: 0x0200000A RID: 10
	public class clsPelare
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00027934 File Offset: 0x00025D34
		public int DagTotKg
		{
			get
			{
				return this.mDagTotKg;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00027948 File Offset: 0x00025D48
		public string Datum
		{
			get
			{
				return this.mDatum;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0002795C File Offset: 0x00025D5C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00027974 File Offset: 0x00025D74
		public string Installer
		{
			get
			{
				return Conversions.ToString(this.mInstaller);
			}
			set
			{
				this.mInstaller = Conversions.ToInteger(value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00027984 File Offset: 0x00025D84
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00027994 File Offset: 0x00025D94
		public string dummy
		{
			get
			{
				string dummy = "";
				return dummy;
			}
			set
			{
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00027998 File Offset: 0x00025D98
		public void SparaOmDagRapp()
		{
			this.File_Path_DayR = string.Concat(new string[]
			{
				MySettingsProperty.Settings.ProjectBib,
				"\\",
				this.mDatum,
				"KC",
				Conversions.ToString(this.mInstaller),
				"ny.day"
			});
			StreamWriter swDayR = new StreamWriter(this.File_Path_DayR, false);
			string T = ",";
			string[] FilS = new string[12];
			DataRow Datarad = this.mDagTabell.NewRow();
			checked
			{
				try
				{
					int num = 0;
					int num2 = this.mAntal - 1;
					for (int i = num; i <= num2; i++)
					{
						Datarad = this.mDagTabell.Rows[i];
						int j = 0;
						do
						{
							FilS[j] = Conversions.ToString(Datarad[j]);
							j++;
						}
						while (j <= 11);
						swDayR.WriteLine(string.Concat(new string[]
						{
							FilS[0],
							T,
							FilS[1],
							T,
							FilS[2],
							T,
							FilS[3],
							T,
							FilS[4],
							T,
							FilS[5],
							T,
							FilS[6],
							T,
							FilS[7],
							T,
							FilS[8],
							T,
							FilS[9],
							T,
							FilS[10],
							T,
							FilS[11]
						}));
					}
					swDayR.Close();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("The Dayreport-file could not be saved:", MsgBoxStyle.OkOnly, null);
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00027B7C File Offset: 0x00025F7C
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00027B94 File Offset: 0x00025F94
		public float TotMBinder
		{
			get
			{
				return this.mTotMBinder;
			}
			set
			{
				this.mTotMBinder = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00027BA0 File Offset: 0x00025FA0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00027BB8 File Offset: 0x00025FB8
		public float TotBorrat
		{
			get
			{
				return this.mTotMBorrat;
			}
			set
			{
				this.mTotMBorrat = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00027BC4 File Offset: 0x00025FC4
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00027BDC File Offset: 0x00025FDC
		public int AntalPel
		{
			get
			{
				return this.mAntal;
			}
			set
			{
				this.mAntal = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00027BE8 File Offset: 0x00025FE8
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00027C00 File Offset: 0x00026000
		public DataTable Tabell
		{
			get
			{
				return this.mDagTabell;
			}
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00027C04 File Offset: 0x00026004
		public Label LabelMättUt
		{
			set
			{
				this.mLabelMätt = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00027C10 File Offset: 0x00026010
		public Label LabelTeoUt
		{
			set
			{
				this.mLabelTeo = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00027C1C File Offset: 0x0002601C
		public Label LabelDjup
		{
			set
			{
				this.mLabelDjup = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00027C28 File Offset: 0x00026028
		public PictureBox PicBoxMark
		{
			set
			{
				this.mPicMark = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00027C34 File Offset: 0x00026034
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00027C4C File Offset: 0x0002604C
		public bool ViktAUt
		{
			get
			{
				return this.mViktA;
			}
			set
			{
				this.mViktA = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00027C58 File Offset: 0x00026058
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00027C70 File Offset: 0x00026070
		public bool ViktBUt
		{
			get
			{
				return this.mViktB;
			}
			set
			{
				this.mViktB = value;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00027C7C File Offset: 0x0002607C
		public void PelareFärdig()
		{
			this.File_Path_pel = string.Concat(new string[]
			{
				MySettingsProperty.Settings.ProjectBib,
				"\\",
				this.mDatum,
				"KC",
				Conversions.ToString(this.mInstaller),
				".pel"
			});
			StreamWriter swPel = new StreamWriter(this.File_Path_pel, true);
			this.File_Path_DayR = string.Concat(new string[]
			{
				MySettingsProperty.Settings.ProjectBib,
				"\\",
				this.mDatum,
				"KC",
				Conversions.ToString(this.mInstaller),
				"ny.day"
			});
			StreamWriter swDayR = new StreamWriter(this.File_Path_DayR, true);
			checked
			{
				int PelarRader = 39 + Information.UBound(this.mDmVektor, 1) + 1 + 3 + this.mSekund + 1;
				string[] Pr = new string[PelarRader + 1];
				this.StoppBinder();
				this.mSekUsed = Information.UBound(this.mSekAvektor, 1);
				this.mViktAEfter = this.mSignal.MätViktAhg;
				this.mViktBEfter = this.mSignal.MätViktBhg;
				this.mRättStoppDjup = Conversions.ToInteger(this.mSignal.MätDjup);
				int utmatatKg = 0;
				if (this.mViktA)
				{
					utmatatKg = this.mViktAInnan - this.mViktAEfter;
				}
				if (this.mViktB)
				{
					utmatatKg += this.mViktBinnan - this.mViktBEfter;
				}
				float EffLängdM = (float)((double)(this.mTotBorrDjup - this.mRättStoppDjup) / 1000.0);
				if (EffLängdM != 0f)
				{
					this.mMättBinderM = (float)this.mTotaltKg / EffLängdM;
				}
				else
				{
					this.mMättBinderM = (float)this.mTotaltKg;
				}
				int AntalSek = Information.UBound(this.mSekBorrRpmV, 1);
				int num = 0;
				int num2 = AntalSek;
				int TotSpeed = 0;
				for (int i = num; i <= num2; i++)
				{
					TotSpeed += this.mSekBorrRpmV[i];
				}
				if (AntalSek > 0)
				{
					this.mRotMedel = (int)Math.Round((double)TotSpeed / (double)AntalSek);
				}
				int AntalRot = (int)Math.Round(unchecked((double)this.mRotMedel / 60.0 * (double)AntalSek));
				if (this.mTotBorrDjup - this.mRättStoppDjup > 0)
				{
					this.mStignMedel = (int)Math.Round((double)AntalRot / (double)(this.mTotBorrDjup - this.mRättStoppDjup));
				}
				else
				{
					this.mStignMedel = 0;
				}
				this.mSekUsed = AntalSek;
				this.mColId = this.frmHuvud.txtColNr.Text;
				this.mNote = this.frmHuvud.txtNotes.Text;
				this.mSite = this.frmHuvud.txtArea.Text;
				this.mDriver = this.frmHuvud.lblDriver.Text;
				this.frmHuvud.txtStartAvikt.Text = Conversions.ToString((int)Math.Round((double)this.mViktAInnan / 10.0));
				this.frmHuvud.txtStartBvikt.Text = Conversions.ToString((int)Math.Round((double)this.mViktBinnan / 10.0));
				this.frmHuvud.txtStoppAvikt.Text = Conversions.ToString((int)Math.Round((double)this.mViktAEfter / 10.0));
				this.frmHuvud.txtStoppBvikt.Text = Conversions.ToString((int)Math.Round((double)this.mViktBEfter / 10.0));
				this.frmHuvud.txtSekunder.Text = Conversions.ToString(this.mSekUsed);
				float sngViktTot = (float)(this.mViktAInnan - this.mViktAEfter + this.mViktBinnan - this.mViktBEfter);
				sngViktTot /= 10f;
				this.frmHuvud.txtTotUt.Text = Strings.Format(Conversions.ToString((int)Math.Round((double)(sngViktTot / 10f))), "0");
				this.mTempKomp = (float)((double)Conversions.ToInteger(this.mSignal.MätTempKompr) / 100.0);
				this.mRHKomp = (float)((double)Conversions.ToInteger(this.mSignal.MätLuftFukt) / 100.0);
				this.mTempA = (float)((double)Conversions.ToInteger(this.mSignal.MätTempLuftA) / 100.0);
				this.mTempB = (float)((double)Conversions.ToInteger(this.mSignal.MätTempLuftB) / 100.0);
				Pr[0] = "***** KC " + Conversions.ToString(this.mInstaller) + " *****";
				Pr[1] = "3.10";
				Pr[2] = this.mDatum;
				Pr[3] = this.mStartBinder;
				Pr[4] = this.mStoppBinder;
				Pr[5] = this.mStartDownDrill;
				Pr[6] = Conversions.ToString(this.mInstaller);
				Pr[7] = Conversions.ToString(this.mCarrier);
				Pr[8] = this.mSite;
				Pr[9] = this.mNote;
				Pr[10] = this.mColId;
				Pr[11] = this.mDriver;
				Pr[12] = Conversions.ToString(this.mDiameter);
				Pr[13] = Conversions.ToString(this.mTeoKg);
				Pr[14] = Conversions.ToString(this.mTeoKgTopp);
				Pr[15] = Conversions.ToString(this.mTeoDjupTopp);
				Pr[16] = Conversions.ToString(this.mTeoKgBott);
				Pr[17] = Conversions.ToString(this.mTeoDjupBott);
				Pr[18] = Conversions.ToString(this.mStigning);
				Pr[19] = Conversions.ToString(this.mMaxRpm);
				Pr[20] = Conversions.ToString(this.mTolerans);
				Pr[21] = Conversions.ToString(this.mMixFrånA);
				Pr[22] = Conversions.ToString(this.mAutoStopp);
				Pr[23] = Conversions.ToString(this.mTotBorrDjup);
				Pr[24] = Conversions.ToString(this.mRättStoppDjup);
				Pr[25] = Strings.Format(this.mMättBinderM, "0.00");
				Pr[26] = Conversions.ToString(this.mRotMedel);
				Pr[27] = Conversions.ToString(this.mStignMedel);
				Pr[28] = Conversions.ToString(this.mSekUsed);
				Pr[29] = Conversions.ToString(this.mViktAInnan);
				Pr[30] = Conversions.ToString(this.mViktAEfter);
				Pr[31] = Conversions.ToString(this.mViktBinnan);
				Pr[32] = Conversions.ToString(this.mViktBEfter);
				Pr[33] = Strings.Format(this.mTempKomp, "0.00");
				Pr[34] = Strings.Format(this.mRHKomp, "0.00");
				Pr[35] = Strings.Format(this.mTempA, "0.00");
				Pr[36] = Strings.Format(this.mTempB, "0.00");
				Pr[37] = "Dm Vektor nästa antal dm med 0 som bas";
				Pr[38] = Conversions.ToString(Information.UBound(this.mDmVektor, 1));
				Pr[39] = "Dm Vektor start nästa rad";
				int StartRad = 40;
				int num3 = StartRad;
				int num4 = StartRad + Information.UBound(this.mDmVektor, 1);
				for (int i = num3; i <= num4; i++)
				{
					Pr[i] = Conversions.ToString(i - StartRad) + "," + Conversions.ToString(this.mDmVektor[i - StartRad]);
				}
				int NästaRad = StartRad + Information.UBound(this.mDmVektor, 1) + 1;
				Pr[NästaRad] = "Sekund vektor antal är nästa rad med 0 som bas";
				Pr[NästaRad + 1] = Conversions.ToString(this.mSekund - 1);
				Pr[NästaRad + 2] = "Sekund vektor start nästa rad = sek(antal) AVikt(kg) BVikt(kg) Djup(mm) ABar(mbar) BBar(mbar) SlangBar(mbar) Svivel(mbar) Borr(rpm)AtankAktive BtankAktive";
				int SekStartRad = NästaRad + 3;
				int num5 = SekStartRad;
				int num6 = SekStartRad + this.mSekund - 1;
				for (int i = num5; i <= num6; i++)
				{
					int pek = i - SekStartRad;
					Pr[i] = string.Concat(new string[]
					{
						Conversions.ToString(pek),
						",",
						Conversions.ToString(this.mSekAvektor[pek]),
						",",
						Conversions.ToString(this.mSekBvektor[pek]),
						",",
						Conversions.ToString(this.mSekDjupvektor[pek]),
						",",
						Conversions.ToString(this.mSekAtryckv[pek]),
						",",
						Conversions.ToString(this.mSekBtryckv[pek]),
						",",
						Conversions.ToString(this.mSekSlangtryckv[pek]),
						",",
						Conversions.ToString(this.mSekSviveltryckv[pek]),
						",",
						Conversions.ToString(this.mSekBorrRpmV[pek]),
						",",
						Conversions.ToString(this.mTankA[pek]),
						",",
						Conversions.ToString(this.mTankB[pek]),
						",",
						Conversions.ToString(this.mSekBitBorrUpp[pek]),
						",",
						Conversions.ToString(this.mSekBitCellA[pek]),
						",",
						Conversions.ToString(this.msekBitCellB[pek]),
						",",
						Conversions.ToString(this.mSekCellArpm[pek]),
						",",
						Conversions.ToString(this.mSekCellBrpm[pek])
					});
				}
				try
				{
					int num7 = 0;
					int num8 = PelarRader;
					for (int i = num7; i <= num8; i++)
					{
						swPel.WriteLine(Pr[i]);
					}
					swPel.Close();
				}
				catch (Exception Ex)
				{
					Interaction.MsgBox("The KC-file could not be saved:", MsgBoxStyle.OkOnly, null);
					Interaction.MsgBox(Ex.Message, MsgBoxStyle.OkOnly, null);
					return;
				}
				string Punkt = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
				if (Operators.CompareString(Punkt, ",", false) == 0)
				{
				}
				this.mAntal++;
				string T = ",";
				try
				{
					swDayR.WriteLine(string.Concat(new string[]
					{
						Conversions.ToString(this.mAntal),
						T,
						this.mStartBinder,
						T,
						this.mColId,
						T,
						Strings.Format((double)this.mTotBorrDjup / 1000.0, "0.00"),
						T,
						Strings.Format((double)this.mRättStoppDjup / 1000.0, "0.00"),
						T,
						Strings.Format((int)Math.Round((double)(this.mMättBinderM / 10f)), "0.00"),
						T,
						Conversions.ToString((int)Math.Round((double)this.mTotaltKg / 10.0)),
						T,
						this.mNote,
						T,
						this.mColId,
						T,
						this.mNote,
						T,
						this.mSite,
						T,
						this.mSite
					}));
					swDayR.Close();
				}
				catch (Exception ex)
				{
					Interaction.MsgBox("The Dayreport-file could not be saved:", MsgBoxStyle.OkOnly, null);
					Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
					return;
				}
				int AntalPel = this.mDagTabell.Rows.Count;
				DataRow PelRad = this.mDagTabell.NewRow();
				PelRad[0] = this.mAntal;
				PelRad[1] = this.mStartBinder;
				PelRad[2] = this.mColId;
				PelRad[3] = Strings.Format((double)this.mTotBorrDjup / 1000.0, "0.00");
				PelRad[4] = Strings.Format((double)this.mRättStoppDjup / 1000.0, "0.00");
				PelRad[5] = Strings.Format(this.mMättBinderM / 10f, "0.00");
				PelRad[6] = Conversions.ToString((int)Math.Round((double)this.mTotaltKg / 10.0));
				PelRad[7] = this.mNote;
				PelRad[8] = this.mColId;
				PelRad[9] = this.mNote;
				PelRad[10] = this.mSite;
				PelRad[11] = this.mSite;
				this.mDagTabell.Rows.Add(PelRad);
			}
			float EffLängd = (float)((double)this.mTotBorrDjup / 1000.0 - (double)this.mRättStoppDjup / 1000.0);
			this.mTotMBorrat = (float)((double)this.mTotMBorrat + (double)this.mTotBorrDjup / 1000.0);
			this.mTotMBinder += EffLängd;
			checked
			{
				this.mDagTotKg += (int)Math.Round((double)this.mTotaltKg / 10.0);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000289E4 File Offset: 0x00026DE4
		public void NyPelareStart()
		{
			this.frmHuvud = MyProject.Forms.TestarKom.HuvudForm;
			this.mSignal = MyProject.Forms.TestarKom.Signaler;
			this.StartBinder();
			this.mViktAInnan = this.mSignal.MätViktAhg;
			this.mViktBinnan = this.mSignal.MätViktBhg;
			this.mTotBorrDjup = Conversions.ToInteger(this.mSignal.MätDjup);
			this.mLabelDjup.Text = "Depth = " + Strings.Format((double)this.mTotBorrDjup / 1000.0, "0.00");
			this.frmHuvud.Röret.JordBotten = (float)((double)this.mTotBorrDjup / 1000.0);
			this.mAutoStopp = Conversions.ToInteger(this.mSignal.PelStoppDjup);
			this.frmHuvud.Röret.StoppDjup = (float)((double)this.mAutoStopp / 1000.0);
			checked
			{
				int AntalDm = (int)Math.Round((double)(this.mTotBorrDjup - this.mAutoStopp) / 100.0);
				this.mDmVektor = new int[AntalDm + 1];
				this.mDiameter = Conversions.ToInteger(MySettingsProperty.Settings.Diameter);
				this.mTeoKg = Conversions.ToInteger(this.mSignal.PelTeoHg);
				this.mTeoKgTopp = Conversions.ToInteger(this.mSignal.PelEkgTopp);
				this.mTeoDjupTopp = Conversions.ToInteger(this.mSignal.PelEmmtopp);
				this.mTeoKgBott = Conversions.ToInteger(this.mSignal.PelEkgBott);
				this.mTeoDjupBott = Conversions.ToInteger(this.mSignal.PelEmmBott);
				this.mStigning = Conversions.ToInteger(this.mSignal.PelStigning);
				this.mMaxRpm = Conversions.ToInteger(this.mSignal.PelRotBegräns);
				this.mTolerans = 10;
				this.mMixFrånA = Conversions.ToInteger(this.mSignal.PelFrånTankA);
				if (this.mTeoKgTopp > 1)
				{
					this.mÖvreBinder = true;
				}
				else
				{
					this.mÖvreBinder = false;
				}
				if (this.mTeoKgBott > 1)
				{
					this.mBottBinder = true;
				}
				else
				{
					this.mBottBinder = false;
				}
				this.mSekAvektor = new int[1];
				this.mSekBvektor = new int[1];
				this.mSekDjupvektor = new int[1];
				this.mSekAtryckv = new int[1];
				this.mSekBtryckv = new int[1];
				this.mSekSlangtryckv = new int[1];
				this.mSekSviveltryckv = new int[1];
				this.mSekBorrRpmV = new int[1];
				this.mSekBitBorrUpp = new int[1];
				this.mSekBitCellA = new int[1];
				this.msekBitCellB = new int[1];
				this.mSekCellArpm = new int[1];
				this.mSekCellBrpm = new int[1];
				this.mTankA = new bool[1];
				this.mTankB = new bool[1];
				this.mSekund = 0;
				this.AdderaSekund();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00028CD8 File Offset: 0x000270D8
		public void AdderaSekund()
		{
			checked
			{
				this.mSekAvektor = (int[])Utils.CopyArray((Array)this.mSekAvektor, new int[this.mSekund + 1]);
				this.mSekBvektor = (int[])Utils.CopyArray((Array)this.mSekBvektor, new int[this.mSekund + 1]);
				this.mSekDjupvektor = (int[])Utils.CopyArray((Array)this.mSekDjupvektor, new int[this.mSekund + 1]);
				this.mSekAtryckv = (int[])Utils.CopyArray((Array)this.mSekAtryckv, new int[this.mSekund + 1]);
				this.mSekBtryckv = (int[])Utils.CopyArray((Array)this.mSekBtryckv, new int[this.mSekund + 1]);
				this.mSekSlangtryckv = (int[])Utils.CopyArray((Array)this.mSekSlangtryckv, new int[this.mSekund + 1]);
				this.mSekSviveltryckv = (int[])Utils.CopyArray((Array)this.mSekSviveltryckv, new int[this.mSekund + 1]);
				this.mSekBorrRpmV = (int[])Utils.CopyArray((Array)this.mSekBorrRpmV, new int[this.mSekund + 1]);
				this.mSekBitBorrUpp = (int[])Utils.CopyArray((Array)this.mSekBitBorrUpp, new int[this.mSekund + 1]);
				this.mSekBitCellA = (int[])Utils.CopyArray((Array)this.mSekBitCellA, new int[this.mSekund + 1]);
				this.msekBitCellB = (int[])Utils.CopyArray((Array)this.msekBitCellB, new int[this.mSekund + 1]);
				this.mSekCellArpm = (int[])Utils.CopyArray((Array)this.mSekCellArpm, new int[this.mSekund + 1]);
				this.mSekCellBrpm = (int[])Utils.CopyArray((Array)this.mSekCellBrpm, new int[this.mSekund + 1]);
				this.mTankA = (bool[])Utils.CopyArray((Array)this.mTankA, new bool[this.mSekund + 1]);
				this.mTankB = (bool[])Utils.CopyArray((Array)this.mTankB, new bool[this.mSekund + 1]);
				this.mSekAvektor[this.mSekund] = this.mSignal.MätViktAhg;
				this.mSekBvektor[this.mSekund] = this.mSignal.MätViktBhg;
				this.mSekDjupvektor[this.mSekund] = Conversions.ToInteger(this.mSignal.MätDjup);
				this.mSekAtryckv[this.mSekund] = Conversions.ToInteger(this.mSignal.MätTtankA);
				this.mSekBtryckv[this.mSekund] = Conversions.ToInteger(this.mSignal.MätTtankB);
				this.mSekSlangtryckv[this.mSekund] = Conversions.ToInteger(this.mSignal.MätTslang);
				this.mSekSviveltryckv[this.mSekund] = Conversions.ToInteger(this.mSignal.MätTsvivel);
				this.mSekBorrRpmV[this.mSekund] = Conversions.ToInteger(this.mSignal.MätVarvBorr);
				this.mSekBitBorrUpp[this.mSekund] = Conversions.ToInteger(this.mSignal.MätUtUNer);
				this.mSekBitCellA[this.mSekund] = Conversions.ToInteger(this.mSignal.MätUtCellA);
				this.msekBitCellB[this.mSekund] = Conversions.ToInteger(this.mSignal.MätUtCellB);
				this.mSekCellArpm[this.mSekund] = Conversions.ToInteger(this.mSignal.MätVarvCellA);
				this.mSekCellBrpm[this.mSekund] = Conversions.ToInteger(this.mSignal.MätVarvCellB);
				this.mTankA[this.mSekund] = this.mViktA;
				this.mTankB[this.mSekund] = this.mViktB;
				if (this.mSekund == 0)
				{
					this.STATIC_AdderaSekund_2001_lastAvikt = this.mSekAvektor[0];
					this.STATIC_AdderaSekund_2001_lastBvikt = this.mSekBvektor[0];
					this.STATIC_AdderaSekund_2001_lastDjup = this.mSekDjupvektor[0];
					this.STATIC_AdderaSekund_2001_oldViktA = this.mViktAInnan;
					this.STATIC_AdderaSekund_2001_oldViktB = this.mViktBinnan;
					this.STATIC_AdderaSekund_2001_TotUtmatat = 0;
				}
				if (this.mSekund > 0)
				{
					if (!this.mTankA[this.mSekund - 1] & this.mTankA[this.mSekund])
					{
						this.STATIC_AdderaSekund_2001_oldViktA = this.mSekAvektor[this.mSekund];
					}
					if (!this.mTankB[this.mSekund - 1] & this.mTankB[this.mSekund])
					{
						this.STATIC_AdderaSekund_2001_oldViktB = this.mSekBvektor[this.mSekund];
					}
					if (this.mViktA)
					{
						this.STATIC_AdderaSekund_2001_TotUtmatat = this.STATIC_AdderaSekund_2001_TotUtmatat + this.STATIC_AdderaSekund_2001_oldViktA - this.mSekAvektor[this.mSekund];
						this.STATIC_AdderaSekund_2001_oldViktA = this.mSekAvektor[this.mSekund];
					}
					if (this.mViktB)
					{
						this.STATIC_AdderaSekund_2001_TotUtmatat = this.STATIC_AdderaSekund_2001_TotUtmatat + this.STATIC_AdderaSekund_2001_oldViktB - this.mSekBvektor[this.mSekund];
						this.STATIC_AdderaSekund_2001_oldViktB = this.mSekBvektor[this.mSekund];
					}
					this.mTotaltKg = this.STATIC_AdderaSekund_2001_TotUtmatat;
				}
				int plats = (int)Math.Round((double)(this.mTotBorrDjup - this.mSekDjupvektor[this.mSekund]) / 100.0);
				if (plats > Information.UBound(this.mDmVektor, 1))
				{
					plats = Information.UBound(this.mDmVektor, 1);
				}
				int ViktDiff = 0;
				if (this.mViktA)
				{
					ViktDiff = this.STATIC_AdderaSekund_2001_lastAvikt - this.mSekAvektor[this.mSekund];
				}
				if (this.mViktB)
				{
					ViktDiff += this.STATIC_AdderaSekund_2001_lastBvikt - this.mSekBvektor[this.mSekund];
				}
				this.mDmVektor[plats] = this.mDmVektor[plats] + ViktDiff;
				this.STATIC_AdderaSekund_2001_lastAvikt = this.mSekAvektor[this.mSekund];
				this.STATIC_AdderaSekund_2001_lastBvikt = this.mSekBvektor[this.mSekund];
				this.STATIC_AdderaSekund_2001_lastDjup -= 100;
				this.mLabelMätt.Text = "Measured  =  " + Strings.Format((double)this.STATIC_AdderaSekund_2001_TotUtmatat / 10.0, "0") + "  kg";
				int BinderTeo = 0;
				if (!this.mÖvreBinder & !this.mBottBinder)
				{
					BinderTeo = (int)Math.Round(unchecked((double)this.mTeoKg * ((double)(checked(this.mTotBorrDjup - this.mSekDjupvektor[this.mSekund])) / 1000.0)));
				}
				if (this.mÖvreBinder & !this.mBottBinder)
				{
					if (this.mSekDjupvektor[this.mSekund] > this.mTeoDjupTopp)
					{
						BinderTeo = (int)Math.Round(unchecked((double)this.mTeoKg * ((double)(checked(this.mTotBorrDjup - this.mSekDjupvektor[this.mSekund])) / 1000.0)));
					}
					else
					{
						if (this.mTotBorrDjup > this.mTeoDjupTopp)
						{
							BinderTeo = (int)Math.Round((double)(this.mTeoKg * (this.mTotBorrDjup - this.mTeoDjupTopp)) / 1000.0);
						}
						else
						{
							BinderTeo = 0;
						}
						BinderTeo += (int)Math.Round((double)(this.mTeoKgTopp * (this.mTeoDjupTopp - this.mSekDjupvektor[this.mSekund])) / 1000.0);
					}
				}
				if (this.mÖvreBinder & this.mBottBinder)
				{
					if (this.mSekDjupvektor[this.mSekund] < this.mTeoDjupTopp)
					{
						BinderTeo = (int)Math.Round((double)(this.mTeoKgBott * (this.mTotBorrDjup - this.mTeoDjupBott)) / 1000.0);
						BinderTeo += (int)Math.Round((double)(this.mTeoKg * (this.mTeoDjupBott - this.mTeoDjupTopp)) / 1000.0);
						BinderTeo += (int)Math.Round((double)(this.mTeoKgTopp * (this.mTeoDjupTopp - this.mSekDjupvektor[this.mSekund])) / 1000.0);
					}
					if (this.mSekDjupvektor[this.mSekund] < this.mTeoDjupBott & this.mSekDjupvektor[this.mSekund] > this.mTeoDjupTopp)
					{
						BinderTeo = (int)Math.Round((double)(this.mTeoKgBott * (this.mTotBorrDjup - this.mTeoDjupBott)) / 1000.0);
						BinderTeo += (int)Math.Round((double)(this.mTeoKg * (this.mTeoDjupBott - this.mSekDjupvektor[this.mSekund])) / 1000.0);
					}
					if (this.mSekDjupvektor[this.mSekund] > this.mTeoDjupBott)
					{
						BinderTeo += (int)Math.Round((double)(this.mTeoKgBott * (this.mTotBorrDjup - this.mSekDjupvektor[this.mSekund])) / 1000.0);
					}
				}
				this.mLabelTeo.Text = "Teoretical  =  " + Strings.Format((double)BinderTeo / 10.0, "0") + "  kg";
				this.mSekund++;
				this.RitaUtmatKurva();
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000295D4 File Offset: 0x000279D4
		private void RitaUtmatKurva()
		{
			this.mPicMark.CreateGraphics().SmoothingMode = SmoothingMode.HighQuality;
			Pen StoppPenna = new Pen(Color.Red);
			StoppPenna.Width = 1f;
			Pen UtmatGränsPenna = new Pen(Color.Brown);
			UtmatGränsPenna.Width = 1f;
			UtmatGränsPenna.DashStyle = DashStyle.Dash;
			Pen BegränsPenna = new Pen(Color.Blue);
			BegränsPenna.Width = 1f;
			Pen TeoPenna = new Pen(Color.BlueViolet);
			TeoPenna.Width = 1f;
			Pen BinderPenna = new Pen(Color.Green);
			BinderPenna.Width = 2f;
			this.mPicMark.CreateGraphics().Clear(this.mPicMark.BackColor);
			float skalFaktHöjd = (float)((double)this.mPicMark.Height / (double)this.mTotBorrDjup);
			float scalFaktBredd;
			checked
			{
				int BinderTeoTotalt = 0;
				if (!this.mÖvreBinder & !this.mBottBinder)
				{
					BinderTeoTotalt = (int)Math.Round((double)(this.mTeoKg * this.mTotBorrDjup) / 1000.0);
				}
				if (this.mÖvreBinder & !this.mBottBinder)
				{
					if (this.mTotBorrDjup > this.mTeoDjupTopp)
					{
						BinderTeoTotalt = (int)Math.Round((double)(this.mTeoKg * (this.mTotBorrDjup - this.mTeoDjupTopp)) / 1000.0);
						BinderTeoTotalt += (int)Math.Round((double)(this.mTeoKgTopp * this.mTeoDjupTopp) / 1000.0);
					}
					else
					{
						BinderTeoTotalt = (int)Math.Round((double)(this.mTeoKgTopp * this.mTotBorrDjup) / 1000.0);
					}
				}
				if (this.mÖvreBinder & this.mBottBinder)
				{
					if (this.mTotBorrDjup > this.mTeoDjupBott)
					{
						BinderTeoTotalt = (int)Math.Round((double)(this.mTeoKg * (this.mTeoDjupBott - this.mTeoDjupTopp)) / 1000.0);
						BinderTeoTotalt += (int)Math.Round((double)(this.mTeoKgBott * (this.mTotBorrDjup - this.mTeoDjupBott)) / 1000.0);
						BinderTeoTotalt += (int)Math.Round((double)(this.mTeoKgTopp * this.mTeoDjupTopp) / 1000.0);
					}
					if (this.mTotBorrDjup < this.mTeoDjupBott)
					{
						if (this.mTotBorrDjup > this.mTeoDjupTopp)
						{
							BinderTeoTotalt = (int)Math.Round((double)(this.mTeoKg * (this.mTotBorrDjup - this.mTeoDjupTopp)) / 1000.0);
							BinderTeoTotalt += (int)Math.Round((double)(this.mTeoKgTopp * this.mTeoDjupTopp) / 1000.0);
						}
						else
						{
							BinderTeoTotalt = (int)Math.Round((double)(this.mTeoKgTopp * this.mTotBorrDjup) / 1000.0);
						}
					}
				}
				scalFaktBredd = (float)((double)this.mPicMark.Width / (double)BinderTeoTotalt);
			}
			this.mPicMark.CreateGraphics().DrawLine(StoppPenna, 0f, (float)this.mAutoStopp * skalFaktHöjd, (float)this.mPicMark.Width, (float)this.mAutoStopp * skalFaktHöjd);
			checked
			{
				if (!this.mÖvreBinder & !this.mBottBinder)
				{
					this.mPicMark.CreateGraphics().DrawLine(TeoPenna, 0, this.mPicMark.Height, this.mPicMark.Width, 0);
					int LimitU = (int)Math.Round(unchecked((double)this.mPicMark.Width - (double)(checked(this.mPicMark.Width * this.mTolerans)) / 100.0));
					int LimitÖ = (int)Math.Round(unchecked((double)this.mPicMark.Width + (double)(checked(this.mPicMark.Width * this.mTolerans)) / 100.0));
					this.mPicMark.CreateGraphics().DrawLine(BegränsPenna, 0, this.mPicMark.Height, LimitU, 0);
					this.mPicMark.CreateGraphics().DrawLine(BegränsPenna, 0, this.mPicMark.Height, LimitÖ, 0);
				}
				if (this.mÖvreBinder & !this.mBottBinder)
				{
					if (this.mTotBorrDjup > this.mTeoDjupTopp)
					{
						unchecked
						{
							this.mPicMark.CreateGraphics().DrawLine(BegränsPenna, 0f, (float)this.mTeoDjupTopp * skalFaktHöjd, (float)this.mPicMark.Width, (float)this.mTeoDjupTopp * skalFaktHöjd);
						}
						int BinderTeoMellan = (int)Math.Round((double)(this.mTeoKg * (this.mTotBorrDjup - this.mTeoDjupTopp)) / 1000.0);
						int BreddMellan = (int)Math.Round((double)(unchecked((float)BinderTeoMellan * scalFaktBredd)));
						int HöjdÖvreBegr = (int)Math.Round((double)(unchecked((float)this.mTeoDjupTopp * skalFaktHöjd)));
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, 0, this.mPicMark.Height, BreddMellan, HöjdÖvreBegr);
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, BreddMellan, HöjdÖvreBegr, this.mPicMark.Width, 0);
					}
					else
					{
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, 0, this.mPicMark.Height, this.mPicMark.Width, 0);
						int LimitU2 = (int)Math.Round(unchecked((double)this.mPicMark.Width - (double)(checked(this.mPicMark.Width * this.mTolerans)) / 100.0));
						int LimitÖ2 = (int)Math.Round(unchecked((double)this.mPicMark.Width + (double)(checked(this.mPicMark.Width * this.mTolerans)) / 100.0));
						this.mPicMark.CreateGraphics().DrawLine(BegränsPenna, 0, this.mPicMark.Height, LimitU2, 0);
						this.mPicMark.CreateGraphics().DrawLine(BegränsPenna, 0, this.mPicMark.Height, LimitÖ2, 0);
					}
				}
				int BreddTolerans = (int)Math.Round((double)(unchecked(scalFaktBredd * (float)this.mTeoKg * (float)this.mTolerans) / 100f));
				if (this.mÖvreBinder & this.mBottBinder)
				{
					unchecked
					{
						this.mPicMark.CreateGraphics().DrawLine(UtmatGränsPenna, 0f, (float)this.mTeoDjupTopp * skalFaktHöjd, (float)this.mPicMark.Width, (float)this.mTeoDjupTopp * skalFaktHöjd);
						this.mPicMark.CreateGraphics().DrawLine(UtmatGränsPenna, 0f, (float)this.mTeoDjupBott * skalFaktHöjd, (float)this.mPicMark.Width, (float)this.mTeoDjupBott * skalFaktHöjd);
					}
					if (this.mTotBorrDjup > this.mTeoDjupBott)
					{
						int BreddUndreBegr = (int)Math.Round(unchecked((double)(checked(this.mTeoKgBott * (this.mTotBorrDjup - this.mTeoDjupBott))) / 1000.0 * (double)scalFaktBredd));
						int HöjdUndreBegr = (int)Math.Round((double)(unchecked((float)this.mTeoDjupBott * skalFaktHöjd)));
						int BreddÖvrebegr = BreddUndreBegr + (int)Math.Round(unchecked((double)(checked(this.mTeoKg * (this.mTeoDjupBott - this.mTeoDjupTopp))) / 1000.0 * (double)scalFaktBredd));
						int HöjdÖvreBegr2 = (int)Math.Round((double)(unchecked((float)this.mTeoDjupTopp * skalFaktHöjd)));
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, 0, this.mPicMark.Height, BreddUndreBegr, HöjdUndreBegr);
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, BreddUndreBegr, HöjdUndreBegr, BreddÖvrebegr, HöjdÖvreBegr2);
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, BreddÖvrebegr, HöjdÖvreBegr2, this.mPicMark.Width, 0);
					}
					if (this.mTotBorrDjup > this.mTeoDjupTopp & this.mTotBorrDjup < this.mTeoDjupBott)
					{
						int BinderTeoMellan2 = (int)Math.Round((double)(this.mTeoKg * (this.mTotBorrDjup - this.mTeoDjupTopp)) / 1000.0);
						int BreddMellan2 = (int)Math.Round((double)(unchecked((float)BinderTeoMellan2 * scalFaktBredd)));
						int HöjdÖvreBegr3 = (int)Math.Round((double)(unchecked((float)this.mTeoDjupTopp * skalFaktHöjd)));
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, 0, this.mPicMark.Height, BreddMellan2, HöjdÖvreBegr3);
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, BreddMellan2, HöjdÖvreBegr3, this.mPicMark.Width, 0);
					}
					if (this.mTotBorrDjup < this.mTeoDjupTopp)
					{
						this.mPicMark.CreateGraphics().DrawLine(TeoPenna, 0, this.mPicMark.Height, this.mPicMark.Width, 0);
					}
				}
				Monitor.Enter(this.STATIC_RitaUtmatKurva_2001_UppDjup_Init);
				try
				{
					if (this.STATIC_RitaUtmatKurva_2001_UppDjup_Init.State == 0)
					{
						this.STATIC_RitaUtmatKurva_2001_UppDjup_Init.State = 2;
						this.STATIC_RitaUtmatKurva_2001_UppDjup = new int[5];
					}
					else if (this.STATIC_RitaUtmatKurva_2001_UppDjup_Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.STATIC_RitaUtmatKurva_2001_UppDjup_Init.State = 1;
					Monitor.Exit(this.STATIC_RitaUtmatKurva_2001_UppDjup_Init);
				}
				Monitor.Enter(this.STATIC_RitaUtmatKurva_2001_Rot_Init);
				try
				{
					if (this.STATIC_RitaUtmatKurva_2001_Rot_Init.State == 0)
					{
						this.STATIC_RitaUtmatKurva_2001_Rot_Init.State = 2;
						this.STATIC_RitaUtmatKurva_2001_Rot = new int[5];
					}
					else if (this.STATIC_RitaUtmatKurva_2001_Rot_Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.STATIC_RitaUtmatKurva_2001_Rot_Init.State = 1;
					Monitor.Exit(this.STATIC_RitaUtmatKurva_2001_Rot_Init);
				}
				Monitor.Enter(this.STATIC_RitaUtmatKurva_2001_ViktA_Init);
				try
				{
					if (this.STATIC_RitaUtmatKurva_2001_ViktA_Init.State == 0)
					{
						this.STATIC_RitaUtmatKurva_2001_ViktA_Init.State = 2;
						this.STATIC_RitaUtmatKurva_2001_ViktA = new int[5];
					}
					else if (this.STATIC_RitaUtmatKurva_2001_ViktA_Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.STATIC_RitaUtmatKurva_2001_ViktA_Init.State = 1;
					Monitor.Exit(this.STATIC_RitaUtmatKurva_2001_ViktA_Init);
				}
				Monitor.Enter(this.STATIC_RitaUtmatKurva_2001_ViktB_Init);
				try
				{
					if (this.STATIC_RitaUtmatKurva_2001_ViktB_Init.State == 0)
					{
						this.STATIC_RitaUtmatKurva_2001_ViktB_Init.State = 2;
						this.STATIC_RitaUtmatKurva_2001_ViktB = new int[5];
					}
					else if (this.STATIC_RitaUtmatKurva_2001_ViktB_Init.State == 2)
					{
						throw new IncompleteInitialization();
					}
				}
				finally
				{
					this.STATIC_RitaUtmatKurva_2001_ViktB_Init.State = 1;
					Monitor.Exit(this.STATIC_RitaUtmatKurva_2001_ViktB_Init);
				}
				int DjupAktMM = Conversions.ToInteger(this.mSignal.MätDjup);
				int RotAktRpm = Conversions.ToInteger(this.mSignal.MätVarvBorr);
				int ViktAktA = this.mSignal.MätViktAhg;
				int ViktAktB = this.mSignal.MätViktBhg;
				this.STATIC_RitaUtmatKurva_2001_UppDjup[4] = this.STATIC_RitaUtmatKurva_2001_UppDjup[3];
				this.STATIC_RitaUtmatKurva_2001_UppDjup[3] = this.STATIC_RitaUtmatKurva_2001_UppDjup[2];
				this.STATIC_RitaUtmatKurva_2001_UppDjup[2] = this.STATIC_RitaUtmatKurva_2001_UppDjup[1];
				this.STATIC_RitaUtmatKurva_2001_UppDjup[1] = this.STATIC_RitaUtmatKurva_2001_UppDjup[0];
				this.STATIC_RitaUtmatKurva_2001_UppDjup[0] = DjupAktMM;
				this.STATIC_RitaUtmatKurva_2001_Rot[4] = this.STATIC_RitaUtmatKurva_2001_Rot[3];
				this.STATIC_RitaUtmatKurva_2001_Rot[3] = this.STATIC_RitaUtmatKurva_2001_Rot[2];
				this.STATIC_RitaUtmatKurva_2001_Rot[2] = this.STATIC_RitaUtmatKurva_2001_Rot[1];
				this.STATIC_RitaUtmatKurva_2001_Rot[1] = this.STATIC_RitaUtmatKurva_2001_Rot[0];
				this.STATIC_RitaUtmatKurva_2001_Rot[0] = RotAktRpm;
				this.STATIC_RitaUtmatKurva_2001_ViktA[4] = this.STATIC_RitaUtmatKurva_2001_ViktA[3];
				this.STATIC_RitaUtmatKurva_2001_ViktA[3] = this.STATIC_RitaUtmatKurva_2001_ViktA[2];
				this.STATIC_RitaUtmatKurva_2001_ViktA[2] = this.STATIC_RitaUtmatKurva_2001_ViktA[1];
				this.STATIC_RitaUtmatKurva_2001_ViktA[1] = this.STATIC_RitaUtmatKurva_2001_ViktA[0];
				this.STATIC_RitaUtmatKurva_2001_ViktA[0] = ViktAktA;
				this.STATIC_RitaUtmatKurva_2001_ViktB[4] = this.STATIC_RitaUtmatKurva_2001_ViktB[3];
				this.STATIC_RitaUtmatKurva_2001_ViktB[3] = this.STATIC_RitaUtmatKurva_2001_ViktB[2];
				this.STATIC_RitaUtmatKurva_2001_ViktB[2] = this.STATIC_RitaUtmatKurva_2001_ViktB[1];
				this.STATIC_RitaUtmatKurva_2001_ViktB[1] = this.STATIC_RitaUtmatKurva_2001_ViktB[0];
				this.STATIC_RitaUtmatKurva_2001_ViktB[0] = ViktAktB;
				int DiffDjup = this.STATIC_RitaUtmatKurva_2001_UppDjup[4] - this.STATIC_RitaUtmatKurva_2001_UppDjup[0];
				int RotMedel = (int)Math.Round((double)(this.STATIC_RitaUtmatKurva_2001_Rot[0] + this.STATIC_RitaUtmatKurva_2001_Rot[1] + this.STATIC_RitaUtmatKurva_2001_Rot[2] + this.STATIC_RitaUtmatKurva_2001_Rot[3] + this.STATIC_RitaUtmatKurva_2001_Rot[4]) / 5.0);
				int stignMM;
				if (RotMedel > 0)
				{
					stignMM = (int)Math.Round((double)(DiffDjup * 15) / (double)RotMedel);
				}
				else
				{
					stignMM = 0;
				}
				this.frmHuvud.txtStign.Text = Conversions.ToString(stignMM);
				int utmatatTot = 0;
				if (this.mViktA)
				{
					utmatatTot = this.STATIC_RitaUtmatKurva_2001_ViktA[4] - this.STATIC_RitaUtmatKurva_2001_ViktA[0];
				}
				if (this.mViktB)
				{
					utmatatTot += this.STATIC_RitaUtmatKurva_2001_ViktB[4] - this.STATIC_RitaUtmatKurva_2001_ViktB[0];
				}
				this.frmHuvud.txtBindOut.Text = Strings.Format(unchecked((double)utmatatTot * 0.1) / 4.0, "0.0");
				int DmAntal = (int)Math.Round((double)(this.mTotBorrDjup - DjupAktMM) / 100.0);
				if (DmAntal > Information.UBound(this.mDmVektor, 1))
				{
					DmAntal = Information.UBound(this.mDmVektor, 1);
				}
				float DjupStegUpp = unchecked(skalFaktHöjd * 100f);
				int SummaVikt = 0;
				float StartW = 0f;
				float StartH = (float)this.mPicMark.Height;
				int num = 1;
				int num2 = DmAntal;
				for (int i = num; i <= num2; i++)
				{
					SummaVikt += this.mDmVektor[i];
					unchecked
					{
						float TillW = (float)SummaVikt * scalFaktBredd;
						float TillH = StartH - DjupStegUpp;
						this.mPicMark.CreateGraphics().DrawLine(BinderPenna, StartW, StartH, TillW, TillH);
						StartW = TillW;
						StartH = TillH;
					}
				}
				int dumma = 0;
				dumma = 1 + dumma;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0002A2A0 File Offset: 0x000286A0
		public void StartDownDrill()
		{
			this.mStartDownDrill = this.TidenNu();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0002A2B0 File Offset: 0x000286B0
		public void StoppBinder()
		{
			this.mStoppBinder = this.TidenNu();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0002A2C0 File Offset: 0x000286C0
		public void StartBinder()
		{
			this.mStartBinder = this.TidenNu();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0002A2D0 File Offset: 0x000286D0
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0002A2E8 File Offset: 0x000286E8
		public FestoCom Signaler
		{
			get
			{
				return this.mSignal;
			}
			set
			{
				this.mSignal = value;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0002A2F4 File Offset: 0x000286F4
		public clsPelare()
		{
			this.mInstaller = 10;
			this.mCarrier = 0;
			this.mSite = "Site";
			this.mNote = "No note";
			this.mColId = "A45";
			this.mDriver = "Förare";
			this.mDiameter = 600;
			this.mTeoKg = 25;
			this.mTeoKgTopp = 0;
			this.mTeoDjupTopp = 0;
			this.mTeoKgBott = 0;
			this.mTeoDjupBott = 0;
			this.mStigning = 20;
			this.mMaxRpm = 200;
			this.mTolerans = 10;
			this.mMixFrånA = 0;
			this.mAutoStopp = 500;
			this.mTeoLutBäring = 0f;
			this.mTeoFBLutning = 0f;
			this.mTotBorrDjup = 10000;
			this.mRättStoppDjup = 500;
			this.mMättBinderM = 100f;
			this.mRotMedel = 250;
			this.mStignMedel = 13;
			this.mSekUsed = 0;
			this.mViktAInnan = 0;
			this.mViktAEfter = 0;
			this.mViktBinnan = 0;
			this.mViktBEfter = 0;
			this.mStoppLutFB = 0f;
			this.mStoppLutSida = 0f;
			this.mTempKomp = 20f;
			this.mRHKomp = 10f;
			this.mTempA = 20f;
			this.mTempB = 22f;
			this.mViktA = true;
			this.mViktB = true;
			this.mDagTabell = new DataTable("DagRapport");
			this.STATIC_RitaUtmatKurva_2001_UppDjup_Init = new StaticLocalInitFlag();
			this.STATIC_RitaUtmatKurva_2001_Rot_Init = new StaticLocalInitFlag();
			this.STATIC_RitaUtmatKurva_2001_ViktA_Init = new StaticLocalInitFlag();
			this.STATIC_RitaUtmatKurva_2001_ViktB_Init = new StaticLocalInitFlag();
			DateTime NuTid = DateAndTime.Today;
			this.mDatum = this.DatumNu();
			this.mStartBinder = this.TidenNu();
			this.mStoppBinder = this.TidenNu();
			this.mStartDownDrill = this.TidenNu();
			this.mInstaller = MySettingsProperty.Settings.Installer;
			DataTable dataTable = this.mDagTabell;
			dataTable.Columns.Add("Today");
			dataTable.Columns[0].DataType = Type.GetType("System.Int32");
			dataTable.Columns.Add("Tid").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("ID").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("Depth").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("Length").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("kg/m").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("Totkg").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("Comment").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("oldID").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("oldComment").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("Area").DataType = Type.GetType("System.String");
			dataTable.Columns.Add("oldArea").DataType = Type.GetType("System.String");
			this.File_Path_DayR = string.Concat(new string[]
			{
				MySettingsProperty.Settings.ProjectBib,
				"\\",
				this.mDatum,
				"KC",
				Conversions.ToString(this.mInstaller),
				"ny.day"
			});
			checked
			{
				if (File.Exists(this.File_Path_DayR))
				{
					StreamReader sr = new StreamReader(this.File_Path_DayR);
					int[] pos = new int[13];
					string Rad;
					string[] rader = null;
					try
					{
						do
						{
							Rad = sr.ReadLine();
							int i = 0;
							rader = (string[])Utils.CopyArray((Array)rader, new string[i + 1]);
							rader[i] = Rad;
							i++;
						}
						while (Rad != null);
					}
					catch (Exception ex)
					{
						Interaction.MsgBox("The Dayreport-file could not be opened", MsgBoxStyle.OkOnly, null);
						Interaction.MsgBox(ex.Message, MsgBoxStyle.OkOnly, null);
						return;
					}
					int num = 0;
					int num2 = Information.UBound(rader, 1);
					for (int j = num; j <= num2; j++)
					{
						if (Operators.CompareString(rader[j], "", false) == 0)
						{
							break;
						}
						int k = 1;
						int num3 = 1;
						int num4 = Strings.Len(rader[j]);
						for (int i = num3; i <= num4; i++)
						{
							Rad = rader[j];
							if (Operators.CompareString(Strings.Mid(Rad, i, 1), ",", false) == 0)
							{
								pos[k] = i;
								k++;
							}
						}
						DataRow PelRad = this.mDagTabell.NewRow();
						PelRad[0] = Strings.Mid(Rad, 1, pos[1] - 1);
						PelRad[1] = Strings.Mid(Rad, pos[1] + 1, pos[2] - (pos[1] + 1));
						PelRad[2] = Strings.Mid(Rad, pos[2] + 1, pos[3] - (pos[2] + 1));
						string Djup = Conversions.ToString(PelRad[2]);
						PelRad[3] = Strings.Mid(Rad, pos[3] + 1, pos[4] - (pos[3] + 1));
						Djup = Conversions.ToString(PelRad[3]);
						PelRad[4] = Strings.Mid(Rad, pos[4] + 1, pos[5] - (pos[4] + 1));
						string StoppDjup = Conversions.ToString(PelRad[4]);
						PelRad[5] = Strings.Mid(Rad, pos[5] + 1, pos[6] - (pos[5] + 1));
						PelRad[6] = Strings.Mid(Rad, pos[6] + 1, pos[7] - (pos[6] + 1));
						string KgUtmat = Conversions.ToString(PelRad[6]);
						PelRad[7] = Strings.Mid(Rad, pos[7] + 1, pos[8] - (pos[7] + 1));
						PelRad[8] = Strings.Mid(Rad, pos[8] + 1, pos[9] - (pos[8] + 1));
						PelRad[9] = Strings.Mid(Rad, pos[9] + 1, pos[10] - (pos[9] + 1));
						PelRad[10] = Strings.Mid(Rad, pos[10] + 1, pos[11] - (pos[10] + 1));
						PelRad[11] = Strings.Mid(Rad, pos[11] + 1, Strings.Len(Rad) - pos[11]);
						this.mDagTabell.Rows.Add(PelRad);
						float EffLängd = unchecked(Conversions.ToSingle(Djup) - Conversions.ToSingle(StoppDjup));
						this.mAntal = this.AntalPel + 1;
						unchecked
						{
							this.mTotMBorrat += Conversions.ToSingle(Djup);
							this.mTotMBinder += EffLängd;
						}
						this.mDagTotKg += Conversions.ToInteger(KgUtmat);
					}
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0002AA10 File Offset: 0x00028E10
		private string TidenNu()
		{
			DateTime dt = DateTime.Now;
			int Tim = dt.Hour;
			int Min = dt.Minute;
			int Sek = dt.Second;
			return string.Concat(new string[]
			{
				Strings.Format(Tim, "00"),
				":",
				Strings.Format(Min, "00"),
				":",
				Strings.Format(Sek, "00")
			});
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0002AA9C File Offset: 0x00028E9C
		private string DatumNu()
		{
			DateTime dt = DateTime.Now;
			int År = dt.Year;
			int Mån = dt.Month;
			int Dag = dt.Day;
			return string.Concat(new string[]
			{
				Conversions.ToString(År),
				"-",
				Strings.Format(Mån, "00"),
				"-",
				Strings.Format(Dag, "00")
			});
		}

		// Token: 0x04000027 RID: 39
		private const string FilVersion = "3.10";

		// Token: 0x04000028 RID: 40
		private int mInstaller;

		// Token: 0x04000029 RID: 41
		private int mCarrier;

		// Token: 0x0400002A RID: 42
		private string mDatum;

		// Token: 0x0400002B RID: 43
		private string mStartBinder;

		// Token: 0x0400002C RID: 44
		private string mStoppBinder;

		// Token: 0x0400002D RID: 45
		private string mStartDownDrill;

		// Token: 0x0400002E RID: 46
		private string mSite;

		// Token: 0x0400002F RID: 47
		private string mNote;

		// Token: 0x04000030 RID: 48
		private string mColId;

		// Token: 0x04000031 RID: 49
		private string mDriver;

		// Token: 0x04000032 RID: 50
		private int mDiameter;

		// Token: 0x04000033 RID: 51
		private int mTeoKg;

		// Token: 0x04000034 RID: 52
		private int mTeoKgTopp;

		// Token: 0x04000035 RID: 53
		private int mTeoDjupTopp;

		// Token: 0x04000036 RID: 54
		private int mTeoKgBott;

		// Token: 0x04000037 RID: 55
		private int mTeoDjupBott;

		// Token: 0x04000038 RID: 56
		private int mStigning;

		// Token: 0x04000039 RID: 57
		private int mMaxRpm;

		// Token: 0x0400003A RID: 58
		private int mTolerans;

		// Token: 0x0400003B RID: 59
		private int mMixFrånA;

		// Token: 0x0400003C RID: 60
		private int mAutoStopp;

		// Token: 0x0400003D RID: 61
		private float mTeoLutBäring;

		// Token: 0x0400003E RID: 62
		private float mTeoFBLutning;

		// Token: 0x0400003F RID: 63
		private string File_Path_pel;

		// Token: 0x04000040 RID: 64
		private string File_Path_DayR;

		// Token: 0x04000041 RID: 65
		private int mTotBorrDjup;

		// Token: 0x04000042 RID: 66
		private int mRättStoppDjup;

		// Token: 0x04000043 RID: 67
		private float mMättBinderM;

		// Token: 0x04000044 RID: 68
		private int mRotMedel;

		// Token: 0x04000045 RID: 69
		private int mStignMedel;

		// Token: 0x04000046 RID: 70
		private int mSekUsed;

		// Token: 0x04000047 RID: 71
		private int mViktAInnan;

		// Token: 0x04000048 RID: 72
		private int mViktAEfter;

		// Token: 0x04000049 RID: 73
		private int mViktBinnan;

		// Token: 0x0400004A RID: 74
		private int mViktBEfter;

		// Token: 0x0400004B RID: 75
		private float mStoppLutFB;

		// Token: 0x0400004C RID: 76
		private float mStoppLutSida;

		// Token: 0x0400004D RID: 77
		private float mTempKomp;

		// Token: 0x0400004E RID: 78
		private float mRHKomp;

		// Token: 0x0400004F RID: 79
		private float mTempA;

		// Token: 0x04000050 RID: 80
		private float mTempB;

		// Token: 0x04000051 RID: 81
		private int[] mDmVektor;

		// Token: 0x04000052 RID: 82
		private int[] mSekAvektor;

		// Token: 0x04000053 RID: 83
		private int[] mSekBvektor;

		// Token: 0x04000054 RID: 84
		private int[] mSekDjupvektor;

		// Token: 0x04000055 RID: 85
		private int[] mSekAtryckv;

		// Token: 0x04000056 RID: 86
		private int[] mSekBtryckv;

		// Token: 0x04000057 RID: 87
		private int[] mSekSlangtryckv;

		// Token: 0x04000058 RID: 88
		private int[] mSekSviveltryckv;

		// Token: 0x04000059 RID: 89
		private int[] mSekBorrRpmV;

		// Token: 0x0400005A RID: 90
		private int[] mSekBitBorrUpp;

		// Token: 0x0400005B RID: 91
		private int[] mSekBitCellA;

		// Token: 0x0400005C RID: 92
		private int[] msekBitCellB;

		// Token: 0x0400005D RID: 93
		private int[] mSekCellArpm;

		// Token: 0x0400005E RID: 94
		private int[] mSekCellBrpm;

		// Token: 0x0400005F RID: 95
		private bool[] mTankA;

		// Token: 0x04000060 RID: 96
		private bool[] mTankB;

		// Token: 0x04000061 RID: 97
		private int mSekund;

		// Token: 0x04000062 RID: 98
		private bool mViktA;

		// Token: 0x04000063 RID: 99
		private bool mViktB;

		// Token: 0x04000064 RID: 100
		private PictureBox mPicMark;

		// Token: 0x04000065 RID: 101
		private Label mLabelDjup;

		// Token: 0x04000066 RID: 102
		private Label mLabelTeo;

		// Token: 0x04000067 RID: 103
		private Label mLabelMätt;

		// Token: 0x04000068 RID: 104
		private bool mÖvreBinder;

		// Token: 0x04000069 RID: 105
		private bool mBottBinder;

		// Token: 0x0400006A RID: 106
		private int mTotaltKg;

		// Token: 0x0400006B RID: 107
		private int mDagTotKg;

		// Token: 0x0400006C RID: 108
		private DataTable mDagTabell;

		// Token: 0x0400006D RID: 109
		private int mAntal;

		// Token: 0x0400006E RID: 110
		private float mTotMBorrat;

		// Token: 0x0400006F RID: 111
		private float mTotMBinder;

		// Token: 0x04000070 RID: 112
		private FestoCom mSignal;

		// Token: 0x04000071 RID: 113
		private frmTestDrill frmHuvud;

		// Token: 0x04000072 RID: 114
		private int[] STATIC_RitaUtmatKurva_2001_UppDjup;

		// Token: 0x04000073 RID: 115
		private int[] STATIC_RitaUtmatKurva_2001_Rot;

		// Token: 0x04000074 RID: 116
		private int[] STATIC_RitaUtmatKurva_2001_ViktA;

		// Token: 0x04000075 RID: 117
		private int[] STATIC_RitaUtmatKurva_2001_ViktB;

		// Token: 0x04000076 RID: 118
		private StaticLocalInitFlag STATIC_RitaUtmatKurva_2001_UppDjup_Init;

		// Token: 0x04000077 RID: 119
		private StaticLocalInitFlag STATIC_RitaUtmatKurva_2001_Rot_Init;

		// Token: 0x04000078 RID: 120
		private int STATIC_AdderaSekund_2001_lastAvikt;

		// Token: 0x04000079 RID: 121
		private StaticLocalInitFlag STATIC_RitaUtmatKurva_2001_ViktA_Init;

		// Token: 0x0400007A RID: 122
		private int STATIC_AdderaSekund_2001_lastBvikt;

		// Token: 0x0400007B RID: 123
		private StaticLocalInitFlag STATIC_RitaUtmatKurva_2001_ViktB_Init;

		// Token: 0x0400007C RID: 124
		private int STATIC_AdderaSekund_2001_lastDjup;

		// Token: 0x0400007D RID: 125
		private int STATIC_AdderaSekund_2001_oldViktA;

		// Token: 0x0400007E RID: 126
		private int STATIC_AdderaSekund_2001_oldViktB;

		// Token: 0x0400007F RID: 127
		private int STATIC_AdderaSekund_2001_TotUtmatat;
	}
}
