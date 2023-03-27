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
	public class ThanhToanConfiguration : IEntityTypeConfiguration<ThanhToan>
	{
		public void Configure(EntityTypeBuilder<ThanhToan> builder)
		{
			builder.HasKey(t => t.SOPHIEUTT);

			builder.ToTable("THANH_TOAN");
			builder.HasOne(t => t.Khach).WithMany(pc => pc.ThanhToans).HasForeignKey(pc => pc.MAKH);
			builder.HasOne(t => t.NhanVien).WithMany(pc => pc.ThanhToans).HasForeignKey(pc => pc.MANV);
			builder.Property(x => x.SOTIEN).IsRequired();
			builder.Property(x => x.NGAYGIO).IsRequired();
			builder.Property(x => x.SOPHIEUGOI).IsRequired();
			builder.Property(x => x.HINHTHUCTT).IsRequired();
		}

	}
}
