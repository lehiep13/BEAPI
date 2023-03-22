using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class PhieuGoi
	{
		public String SOPHIEUGOI {  get; set; }

		

		public Khach Khach { get; set; }
		public String MAKH { get; set; }


		public Product Product { get; set; }	
		public String MAMONAN { get; set; }
		
	}
}
