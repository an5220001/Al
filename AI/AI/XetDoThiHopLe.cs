using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    public class XetDoThiHopLe
    {
		public struct DoThi
		{
			public int iSodinh;
			public int[,] iMaTran;

		};
		bool kiemTraMaTranKeVoHuongHopLe(DoThi dt)
		{
			for (int i = 0; i < dt.iSodinh; i++)
			{
				if (dt.iMaTran[i, i] != int.MinValue) return false;
			}
			return true;
		}
		bool kiemTraMaTranKeVoHuong(DoThi dt)
		{
			for (int i = 0; i < dt.iSodinh; i++)
			{
				for (int j = i + 1; j < dt.iSodinh; j++)
				{
					if (dt.iMaTran[i, j] != dt.iMaTran[j, i]) return false;
				}
			}
			return true;
		}
		public bool KiemTraDonDoThiDonVoHuong(DoThi dt)
		{
			if (kiemTraMaTranKeVoHuong(dt) == true && kiemTraMaTranKeVoHuongHopLe(dt) == true)
			{
				return true;
			}
			return false;
		}
	}
}
