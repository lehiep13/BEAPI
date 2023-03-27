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
	public class NVCaConfiguration : IEntityTypeConfiguration<NVCa>
	{
		public void Configure(EntityTypeBuilder<NVCa> builder)
		{
			builder.HasKey(t => new { t.MANV, t.MACA });
			

			builder.ToTable("NV_CA");
			builder.HasOne(t => t.NhanVien).WithMany(pc => pc.NVCas).HasForeignKey(pc => pc.MANV);
			builder.HasOne(t => t.CaLamViec).WithMany(pc => pc.NVCas).HasForeignKey(pc => pc.MACA);
		}
	}
}
