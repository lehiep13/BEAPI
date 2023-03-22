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
	public class PhieuGoiConfiguration : IEntityTypeConfiguration<PhieuGoi>

	{
		public void Configure(EntityTypeBuilder<PhieuGoi> builder)
		{
			builder.ToTable("PHIEU_GOI");
			builder.HasKey(x => x.SOPHIEUGOI);
			builder.HasOne(t => t.Product).WithMany(pc => pc.phieuGois).HasForeignKey(pc => pc.MAMONAN);
			builder.HasOne(t => t.Khach).WithMany(pc => pc.phieuGois).HasForeignKey(pc => pc.MAKH);
			
		}
	}
}
