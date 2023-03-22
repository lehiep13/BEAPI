using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class NguyenLieu
	{
		public String MANGUYENLIEU { get; set; }
		public String TENNGUYENLIEU { get; set; }

		public String DONVITINH { get; set; }

		public String MAKHO { get; set; }
		public Kho Kho { get; set; }
		public List<PhieuCC> PhieuCCs { get; set; }
		public List<ChiTietMA> ChiTietMAs { get; set; }

		public List<PhieuNhap> PhieuNhaps { get; set; }
	}
}
