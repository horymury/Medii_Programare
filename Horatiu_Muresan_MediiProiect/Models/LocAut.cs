using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horatiu_Muresan_MediiProiect.Models
{
	public class LocAut
	{
		public int LocAutID { get; set; }
		public int ProdusID { get; set; }
		public int AutomatID { get; set; }
		public Automat Automat { get; set; }

		public int LocatieID { get; set; }
		public Locatie Locatie { get; set; }
	}
}
