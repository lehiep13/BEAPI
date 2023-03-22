using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class NhaCungCap
	{
		public String MANCC { get; set; }
		public String TENCC { get; set; }

		public String DIACHINCC { get; set; }
		public String SDTNCC { get; set; }

		public List<PhieuCC> PhieuCCs { get; set; }
	}
}
