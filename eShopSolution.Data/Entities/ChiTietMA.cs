using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class ChiTietMA
	{
		public String MAMONAN {set; get; }
		public Product Product { set; get; }

		public String MANGUYENLIEU { set; get; }
		public NguyenLieu NguyenLieu { set; get; }
	}
}
