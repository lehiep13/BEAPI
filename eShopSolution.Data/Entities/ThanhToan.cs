using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class ThanhToan
	{
		
		public String SOPHIEUTT { set; get; }

		public String HINHTHUCTT { set; get; }

		public decimal SOTIEN { set; get; }
		public DateTime NGAYGIO { set; get; }
		public String SOPHIEUGOI { set; get; }
		public String MAKH { set; get; }

		public NhanVien NhanVien { set; get; }
		public String MANV { set; get; }
		public Khach Khach { set; get; }

	}
}
