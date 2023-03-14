using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.EF
{
	public class EShopDbContext : DbContext
	{
		public EShopDbContext(DbContextOptions options) : base(options)
		{
			
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Loaimon> Loaimons { get; set; }
		public DbSet<NhanVien> NhanViens { get; set; }
		public DbSet<NguyenLieu> NguyenLieus { get; set; }
		public DbSet<NhaCungCap> NhaCungCaps { get; set; }
		public DbSet<CaLamViec> CaLamViecs { get; set; }
		public DbSet<BoPhan> BoPhans { get; set; }
		public DbSet<Khach> Khachs { get; set; }
		public DbSet<KhachNV> KhachNVs { get; set; }
	}
}
