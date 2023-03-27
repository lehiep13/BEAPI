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
	public class CaLamViecConfiguration : IEntityTypeConfiguration<CaLamViec>
	{
		public void Configure(EntityTypeBuilder<CaLamViec> builder)
		{
			builder.ToTable("CaLamViec");
			builder.HasKey(x => x.MACA);
			builder.Property(x => x.GioKetThuc).IsRequired();
			builder.Property(x => x.GioBatDau).IsRequired();
		}
	}
}
