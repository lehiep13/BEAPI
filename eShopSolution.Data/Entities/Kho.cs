using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class Kho
	{
		public String MAKHO { get; set; }
		public int Soluong { get; set; }

		public List<NguyenLieu> NguyenLieus { get; set; }
	}
}
