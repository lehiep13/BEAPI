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
	public class ProductConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.ToTable("MON_AN");
			builder.HasKey(x => x.MAMONAN);
			builder.Property(x=>x.TENMON).IsRequired();
			builder.Property(x => x.MALOAI).IsRequired();
			builder.Property(x => x.DONVITINh).IsRequired();
			builder.Property(x => x.DONGIA).IsRequired();

			builder.HasOne(x=>x.Loaimon).WithMany(x=>x.products).HasForeignKey(x=>x.MALOAI);
		}
	}
}
