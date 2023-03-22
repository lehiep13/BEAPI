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
	public class PhieuCCConfiguration : IEntityTypeConfiguration<PhieuCC>
	{
		public void Configure(EntityTypeBuilder<PhieuCC> builder)
		{
			builder.HasKey(t => new { t.MANCC, t.MANGUYENLIEU });

			builder.ToTable("Phieu_CC");
			builder.HasOne(t => t.NhaCungCap).WithMany(pc => pc.PhieuCCs).HasForeignKey(pc => pc.MANCC);
			builder.HasOne(t => t.NguyenLieu).WithMany(pc => pc.PhieuCCs).HasForeignKey(pc => pc.MANGUYENLIEU);
		}
	}
}
