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
	public class LoaiMonConfiguration : IEntityTypeConfiguration<Loaimon>

	{
		public void Configure(EntityTypeBuilder<Loaimon> builder)
		{
			builder.ToTable("LoaiMon");
			builder.HasKey(x => x.MALOAI);
			
			builder.Property(x => x.TENLOAI).IsRequired();
			builder.Property(x => x.MOTA);


		}

	}
}
