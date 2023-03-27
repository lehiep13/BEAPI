using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class KhuyenMai
	{
		public String MAKM { get; set; }
		public String TENKM { get; set; }

		public List<MonAnKM> MonAnKMs { get; set; }
	}
}
