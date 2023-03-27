using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class Product
	{
		public String MAMONAN { get; set; }
		public String  TENMON { get; set; }

		public String DONVITINh { get; set; }

		public String MOTA { get; set; }
		public decimal DONGIA { get; set;}
		
		public String MALOAI { get; set; }	
		public List<MonAnKM> MonAnKMs { get; set; }
		public List<ChiTietMA> ChiTietMAs { get; set; }
		public Loaimon Loaimon { get; set; }
		public List<PhieuGoi> phieuGois { get; set; }
	}
}
