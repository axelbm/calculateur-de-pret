using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur_de_Pret
{
	class Calculateur
	{
		private double prix;
		public double Prix
		{
			get
			{
				return prix;
			}
			set
			{
				if (value >= 0 & value <= 60000)
				{
					prix = Math.Round(value, 2);
				}
			}
		}

		private double echange = 0;
		public double Echange
		{
			get { return echange; }


			set
			{
				if (value >= 0 & value <= 60000)
				{
					echange = Math.Round(value, 2);
				}
			}
		}

		private double solde = 0;
		public double Solde
		{
			get { return solde; }


			set
			{
				if (value >= 0 & value <= 60000)
				{
					solde = Math.Round(value, 2);
				}
			}
		}

		private double mdf = 0;
		public double Mdf
		{
			get { return mdf; }


			set
			{
				if (value >= 0 & value <= 60000)
				{
					mdf = Math.Round(value, 2);
				}
			}
		}

		private int duree = 0;
		public int Duree
		{
			get { return duree; }


			set
			{
				if (value >= 0 & value <= 96)
				{
					duree = value/6*6;
				}
			}
		}

		private double tvp = 0;
		public double Tvp
		{
			get { return tvp; }


			set
			{
				if (value >= 0 & value <= 15)
				{
					tvp = Math.Round(value, 2);
				}
			}
		}

		private double taux = 0;
		public double Taux
		{
			get { return taux; }


			set
			{
				if (value >= 0 & value <= 15)
				{
					taux = Math.Round(value, 2);
				}
			}
		}

		//    public Calculateur()
		//    {
		//        
		//    }
	}
}
