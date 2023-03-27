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
	public class PhieuDatConfiguration : IEntityTypeConfiguration<PhieuDat>
	{
		public void Configure(EntityTypeBuilder<PhieuDat> builder)
		{
			builder.ToTable("PHIEUDAT");
			builder.HasKey(x => x.SOPHIEUDAT);
			builder.HasOne(t => t.Khach).WithMany(pc => pc.PhieuDats).HasForeignKey(pc => pc.MAKH);
			builder.HasOne(t => t.BanAn).WithMany(pc => pc.PhieuDats).HasForeignKey(pc => pc.SOBAN);
			builder.Property(x => x.SOLUONGBAN).IsRequired();
			builder.Property(x => x.NGAYGIODAT).IsRequired();
			
			
		}
	}
}
