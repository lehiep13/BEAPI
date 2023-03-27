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
	public class KhachConfiguration : IEntityTypeConfiguration<Khach>
	{
		public void Configure(EntityTypeBuilder<Khach> builder)
		{
			builder.ToTable("Khach");
			builder.HasKey(x => x.MAKH);
			builder.Property(x => x.DIACHIKH).IsRequired();
			builder.Property(x => x.TENKH).IsRequired();
			builder.Property(x => x.SDTKH).IsRequired();
		}
	}
}
