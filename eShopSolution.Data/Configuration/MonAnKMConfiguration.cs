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
	public class MonAnKMConfiguration : IEntityTypeConfiguration<MonAnKM>
	{
		public void Configure(EntityTypeBuilder<MonAnKM> builder)
		{
			builder.HasKey(t => new { t.MAKM, t.MAMONAN });

			builder.ToTable("MON_AN_KM");
			builder.HasOne(t => t.Product).WithMany(pc => pc.MonAnKMs).HasForeignKey(pc=>pc.MAMONAN);
			builder.HasOne(t => t.KhuyenMai).WithMany(pc => pc.MonAnKMs).HasForeignKey(pc => pc.MAKM);
			builder.Property(x => x.NDKM).IsRequired();
			builder.Property(x => x.NGAYBD).IsRequired();
			builder.Property(x => x.NGAYKT).IsRequired();
			builder.Property(x => x.GIATRIKM).IsRequired();
		} 
	}
}
