using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Configuration
{
	public class PhieuNhapConfiguration : IEntityTypeConfiguration<PhieuNhap>
	{
		public void Configure(EntityTypeBuilder<PhieuNhap> builder)
		{
			builder.ToTable("PhieuNhap");
			builder.HasKey(x => x.SOPHIEUNHAP);
			builder.HasOne(t => t.NguyenLieu).WithMany(pc => pc.PhieuNhaps).HasForeignKey(pc => pc.MANGUYENLIEU);
			builder.HasOne(t => t.NhanVien).WithMany(pc => pc.PhieuNhaps).HasForeignKey(pc => pc.MANV);
			builder.Property(x => x.DonGiaNhap).IsRequired();
			builder.Property(x => x.NgayNhap).IsRequired();
			builder.Property(x => x.SoLuongNhap).IsRequired();
		}
	}
}
