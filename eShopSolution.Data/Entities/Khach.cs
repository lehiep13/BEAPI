﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
	public class Khach

	{
		public String MAKH { get; set; }
		public String TENKH { get; set; }

		public String DIACHIKH { get; set; }

		
		public String SDTKH { get; set; }
		public List<ThanhToan> ThanhToans { get; set; }
		public List<PhieuDat> PhieuDats { get; set; }
		public List<PhieuGoi> phieuGois { get; set; }
	}
}
