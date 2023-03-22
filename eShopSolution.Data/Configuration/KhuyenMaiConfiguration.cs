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
	public class KhuyenMaiConfiguration : IEntityTypeConfiguration<KhuyenMai>
	{
		public void Configure(EntityTypeBuilder<KhuyenMai> builder)
		{
			builder.ToTable("KhuyenMai");
			builder.HasKey(x => x.MAKM);
			builder.Property(x => x.TENKM).IsRequired();
		}
	}
}
