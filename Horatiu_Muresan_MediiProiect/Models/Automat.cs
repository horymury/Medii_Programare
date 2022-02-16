﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Horatiu_Muresan_MediiProiect.Models
{
	public class Automat
	{
		public int ID { get; set; }

		[Display(Name = "Automat ID")]
		[Required(ErrorMessage = "Va rog sa completati campul.."), MinLength(3, ErrorMessage = "Necesar minim trei caractere."), MaxLength(30, ErrorMessage = "Admis maxim 30 de caractere.")]
		public string automatIdent { get; set; }
		public ICollection<LocAut> LocAut { get; set; }

	}
}
