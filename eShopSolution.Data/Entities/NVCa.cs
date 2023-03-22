using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class NVCa
	{
		public string MANV { get; set; }

		public NhanVien NhanVien { get; set; }
		public string MACA { get; set;}
		public CaLamViec CaLamViec { get; set; }
	}
}
