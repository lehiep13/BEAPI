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
	public class BanAnConfiguration : IEntityTypeConfiguration<BanAn>
	{
		public void Configure(EntityTypeBuilder<BanAn> builder)
		{
			builder.ToTable("BANAN");
			builder.HasKey(x => x.SOBAN);
			builder.Property(x => x.SOGHE);
		}
	}
}
