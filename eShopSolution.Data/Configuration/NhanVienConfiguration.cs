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
	public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
	{
		public void Configure(EntityTypeBuilder<NhanVien> builder)
		{
			builder.ToTable("NhanVien");
			builder.HasKey(x => x.MANV);
			builder.Property(x => x.HOTENNV).IsRequired();
			builder.Property(x => x.SDTNV).IsRequired();
			builder.Property(x => x.NGAYSINH).IsRequired();
			builder.Property(x => x.DIACHINV).IsRequired();
			builder.Property(x => x.GIOITINH).IsRequired();

			builder.HasOne(x => x.BoPhan).WithMany(x => x.nhanViens).HasForeignKey(x => x.MABOPHAN);
		}
	}
}
