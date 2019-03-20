using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuotteet
{
	public class Verokanta : INimi
	{
		//Kentät
		public float _veroprosentti;
		public float _verokerroin;

		//Ominaisuudet
		public string Nimi { get; set; }
		public float Veroprosentti
		{
			get
			{
				return _veroprosentti;
			}
			set
			{
				if (_veroprosentti < 0 | _veroprosentti > 100)
				{
					throw new ApplicationException("Veroprosentti pitää olla välillä 0‐100.");
				}
				else
				{
					_veroprosentti = value;
				}
			}
		}
		public float Verokerroin
		{
			get
			{
				if (_veroprosentti == 24)
				{
					return (_verokerroin = 1,24);
				}
				if (_veroprosentti == 10)
				{
					return (_verokerroin = 1,1);
				}
			}
		}
		//Metodit
		public string ToString()
		{
			return _veroprosentti + "%";
		}
	}
}
