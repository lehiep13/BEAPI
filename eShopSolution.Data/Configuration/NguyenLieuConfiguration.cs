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
	public class NguyenLieuConfiguration : IEntityTypeConfiguration<NguyenLieu>
	{
		public void Configure(EntityTypeBuilder<NguyenLieu> builder)
		{
			builder.ToTable("NGUYENLIEU");
			builder.HasKey(x => x.MANGUYENLIEU);
			builder.Property(x => x.TENNGUYENLIEU).IsRequired();
			builder.Property(x => x.DONVITINH).IsRequired();

			builder.HasOne(x => x.Kho).WithMany(x => x.NguyenLieus).HasForeignKey(x => x.MAKHO);
		}
	}
}
