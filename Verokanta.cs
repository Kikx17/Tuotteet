using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuotteet
{
	class Verokanta : INimi
	{
		//Kentät
		public float _veroprosentti;

		//Ominaisuudet
		public int _Nimi { get; set; }
		public float Veroprosentti
		{
			set { _veroprosentti = value; }
		}
	}
}
