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
	public class NhaCungCapConfiguration : IEntityTypeConfiguration<NhaCungCap>

	{
		public void Configure(EntityTypeBuilder<NhaCungCap> builder)
		{
			builder.ToTable("NHACUNGCAP");
			builder.HasKey(x => x.MANCC);
			builder.Property(x => x.TENCC).IsRequired();
			builder.Property(x => x.SDTNCC).IsRequired();
			builder.Property(x => x.DIACHINCC).IsRequired();
			
		}
	}
}
