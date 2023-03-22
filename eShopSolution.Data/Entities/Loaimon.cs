using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class Loaimon
	{
		public String MALOAI { get; set; }
		public String TENLOAI { get; set; }

		public String MOTA { get; set; }
		
		public List<Product> products { get; set; }
	}
}
