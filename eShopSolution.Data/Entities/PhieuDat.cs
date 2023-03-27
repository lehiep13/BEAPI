using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class PhieuDat
	{
		public String SOPHIEUDAT { get; set; }
		public int SOLUONGBAN { get; set; }

		public DateTime NGAYGIODAT { get; set; }	
		public String MAKH { get; set; }

		public Khach Khach { get; set; }

		public String SOBAN { get; set; }
		public BanAn BanAn { get; set; }

	}
}
