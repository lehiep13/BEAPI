using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class BoPhan
	{
		public String MABOPHAN { get; set; }
		public String CHUCNANG { get; set; }

		public String TENBOPHAN { get; set; }
		public List<NhanVien> nhanViens { get; set; }
		
	}
}
