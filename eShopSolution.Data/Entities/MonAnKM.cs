using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class MonAnKM 
	{
		public String MAKM { get; set; }

		public DateTime NGAYBD { get; set; }
		public DateTime NGAYKT { get; set; }

		public String NDKM { get; set; }
		public decimal GIATRIKM { get; set; }

		public Product Product { get; set; }
		public String MAMONAN { get; set; }

		public KhuyenMai KhuyenMai { get; set; }
	}
}
