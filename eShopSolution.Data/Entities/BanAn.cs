using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class BanAn
	{
		public String SOBAN { get; set; }
		public int SOGHE { get; set; }
		public List<PhieuDat> PhieuDats { get; set; }

	}
}
