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
	public class BoPhanConfiguration : IEntityTypeConfiguration<BoPhan>
	{
		public void Configure(EntityTypeBuilder<BoPhan> builder)
		{
			builder.ToTable("BOPHAN");
			builder.HasKey(x => x.MABOPHAN);
			builder.Property(x=>x.TENBOPHAN).IsRequired();
		}
	}
}
