using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuotteet
{
	class Tuoteryhmä : IId, INimi
	{
		//Automaattiset ominaisuudet
		public int Id { get; set; }
		public string Nimi { get; set; }

		//Konstruktorit
		public IdJaNimi(int id, string nimi)
		{
			Id = id;
			Nimi = nimi;
		}

		//Metodit
		public string ToString()
		{
			return Id + Nimi;
		}
	}
}
