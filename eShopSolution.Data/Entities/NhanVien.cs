using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class NhanVien
	{
		public String MANV { get; set; }
		public String HOTENNV { get; set; }

		public String SDTNV { get; set; }

		public DateTime NGAYSINH  { get; set; }
		public String GIOITINH { get; set; }
		public String DIACHINV { get; set; }
	}
}
