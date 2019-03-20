using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuotteet
{
	class Tuote : IId, INimi
	{
		//Kentät
		public float _hinta;

		//Automaattiset ominaisuudet
		public int Id { get; set; }
		public string Nimi { get; set; }
		public Verokanta Alvkanta { get; set; }
	}
}
