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
	public class KhoConfiguration : IEntityTypeConfiguration<Kho>
	{
		public void Configure(EntityTypeBuilder<Kho> builder)
		{
			builder.ToTable("KHO");
			builder.HasKey(x => x.MAKHO);
			builder.Property(x => x.Soluong).IsRequired();

			
		}
	}
}
