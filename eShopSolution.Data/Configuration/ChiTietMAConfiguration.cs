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
	internal class ChiTietMAConfiguration : IEntityTypeConfiguration<ChiTietMA>
	{
		public void Configure(EntityTypeBuilder<ChiTietMA> builder)
		{
			builder.HasKey(t => new { t.MAMONAN, t.MANGUYENLIEU });

			builder.ToTable("ChiTietMonAn");
			builder.HasOne(t => t.Product).WithMany(pc => pc.ChiTietMAs).HasForeignKey(pc => pc.MAMONAN);
			builder.HasOne(t => t.NguyenLieu).WithMany(pc => pc.ChiTietMAs).HasForeignKey(pc => pc.MANGUYENLIEU);
		}
	}
}
