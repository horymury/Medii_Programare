using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horatiu_Muresan_MediiProiect.Models
{
	public class Produs
	{
		public int ID { get; set; }

		[Display(Name = "Produs Denumire")]
		[Required(ErrorMessage = "Va rog sa completati campul."), MinLength(5, ErrorMessage = "Necesar minim 5 caractere."), MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
		public string produsNume { get; set; }


		[Display(Name = "Produs Descriere")]
		[Required(ErrorMessage = "Va rog sa completati campul."), MinLength(2, ErrorMessage = "Necesar minim 2 caractere."), MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
		public string produsDescriere { get; set; }

		[Display(Name = "Produs Umplere")]
		[Required(ErrorMessage = "Va rog sa completati campul.")]
		[DataType(DataType.Date)]

		public DateTime produsData { get; set; }

		[Display(Name = "Produs Data Expirare")]
		[Required(ErrorMessage = "Va rog sa completati campul.")]
		[DataType(DataType.Date)]
		public DateTime produsExp { get; set; }

		[Display(Name = "Automat ID")]
		[Required(ErrorMessage = "Va rog sa completati campul.")]
		public int AutomatID { get; set; }
		public Automat Automat { get; set; }

		[Display(Name = "Locatie")]
		[Required(ErrorMessage = "Va rog sa completati campul.")]
		public int LocatieID { get; set; }
		public Locatie Locatie { get; set; }
	}
}
