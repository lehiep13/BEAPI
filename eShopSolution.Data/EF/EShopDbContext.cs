using eShopSolution.Data.Configuration;
using eShopSolution.Data.Entities;
using eShopSolution.Data.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.EF
{
	public class EShopDbContext : IdentityDbContext
	{
		public EShopDbContext(DbContextOptions options) : base(options)
		{
			
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//configure using Fluent API
			modelBuilder.ApplyConfiguration(new BanAnConfiguration());
			modelBuilder.ApplyConfiguration(new BoPhanConfiguration());
			modelBuilder.ApplyConfiguration(new CaLamViecConfiguration());
			modelBuilder.ApplyConfiguration(new ChiTietMAConfiguration());
			modelBuilder.ApplyConfiguration(new KhachConfiguration());
			modelBuilder.ApplyConfiguration(new KhoConfiguration());
			modelBuilder.ApplyConfiguration(new KhuyenMaiConfiguration());
			modelBuilder.ApplyConfiguration(new LoaiMonConfiguration());
			modelBuilder.ApplyConfiguration(new MonAnKMConfiguration());
			modelBuilder.ApplyConfiguration(new NguyenLieuConfiguration());
			modelBuilder.ApplyConfiguration(new NhaCungCapConfiguration());
			modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
			modelBuilder.ApplyConfiguration(new NVCaConfiguration());
			modelBuilder.ApplyConfiguration(new PhieuCCConfiguration());
			modelBuilder.ApplyConfiguration(new PhieuDatConfiguration());
			modelBuilder.ApplyConfiguration(new PhieuGoiConfiguration());
			modelBuilder.ApplyConfiguration(new PhieuNhapConfiguration());
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			modelBuilder.ApplyConfiguration(new ThanhToanConfiguration());

			//Data seeding
			modelBuilder.Seed();
			
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Loaimon> Loaimons { get; set; }
		public DbSet<NhanVien> NhanViens { get; set; }
		public DbSet<NguyenLieu> NguyenLieus { get; set; }
		public DbSet<NhaCungCap> NhaCungCaps { get; set; }
		public DbSet<CaLamViec> CaLamViecs { get; set; }
		public DbSet<BoPhan> BoPhans { get; set; }
		public DbSet<Khach> Khachs { get; set; }
		

		public DbSet<BanAn> BanAns { get; set; }
		public DbSet<ChiTietMA> ChiTietMAs { get; set; }
		public DbSet<Kho> Khos { get; set; }

		public DbSet<KhuyenMai> KhuyenMais { get; set; }

		public DbSet<MonAnKM> monAnKMs { get; set; }

		public DbSet<NVCa> NVCas { get; set; }

		public DbSet<PhieuCC> PhieuCCs { get; set; }

		public DbSet<PhieuDat> PhieuDats { get; set; }

		public DbSet<PhieuNhap> PhieuNhaps { get; set; }
		public DbSet<ThanhToan> thanhToans { get; set; }
		public DbSet<PhieuGoi> phieuGois  { get; set; }

	}
}
