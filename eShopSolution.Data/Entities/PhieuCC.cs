using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class PhieuCC
	{
		public String MANCC { set; get; }
		public NhaCungCap NhaCungCap { set; get; }
		public String MANGUYENLIEU { set; get; }
		public NguyenLieu NguyenLieu { set; get; }
	}
}
