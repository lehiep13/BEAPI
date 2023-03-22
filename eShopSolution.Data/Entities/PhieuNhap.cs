using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class PhieuNhap
	{
		public String SOPHIEUNHAP { get; set; }
		public DateTime NgayNhap { get; set; }
		public decimal DonGiaNhap { get; set; }
		public int SoLuongNhap { get; set; }

		public NhanVien NhanVien { get; set; }
		public String MANV { get; set; }
		public NguyenLieu NguyenLieu { get; set; }
		public String MANGUYENLIEU { get; set; }


	}
}
