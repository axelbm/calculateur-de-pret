﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Calculateur_de_Pret
{
	class Calculateur : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string property)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(property));
		}


		private double maxAmount = 60000;
		public double MaxAmount
		{
			get
			{
				return maxAmount;
			}
			set
			{
				maxAmount = value;
			}
		}

		private int maxDuree = 96;
		public int MaxDuree
		{
			get
			{
				return maxDuree;
			}
			set
			{
				maxDuree = value;
			}
		}

		private double maxTaux = 15;
		public double MaxTaux
		{
			get
			{
				return maxTaux;
			}
			set
			{
				maxTaux = value;
			}
		}

		private double maxTaxe = 15;
		public double MaxTaxe
		{
			get
			{
				return maxTaxe;
			}
			set
			{
				maxTaxe = value;
			}
		}

		private double prix;
		public double Prix
		{
			get
			{
				return prix;
			}
			set
			{
				prix = Math.Max(Math.Min(Math.Round(value, 2), MaxAmount), 0);

				OnPropertyChanged("Prix");
				Calculer();
			}
		}

		private double echange = 0;
		public double Echange
		{
			get { return echange; }


			set
			{
				echange = Math.Max(Math.Min(Math.Round(value, 2), MaxAmount), 0);
				
				OnPropertyChanged("Echange");
				Calculer();
			}
		}

		private double solde = 0;
		public double Solde
		{
			get { return solde; }


			set
			{
				solde = Math.Max(Math.Min(Math.Round(value, 2), MaxAmount), 0);

				OnPropertyChanged("Solde");
				Calculer();
			}
		}

		private double mdf = 0;
		public double Mdf
		{
			get { return mdf; }


			set
			{
				mdf = Math.Max(Math.Min(Math.Round(value, 2), MaxAmount), 0);

				OnPropertyChanged("Mdf");
				Calculer();
			}
		}

		private int duree = 0;
		public int Duree
		{
			get { return duree; }


			set
			{
				duree = Math.Max(Math.Min(value, MaxDuree), 6) / 6 * 6;

				OnPropertyChanged("Duree");
				Calculer();
			}
		}

		private double tvp = 0;
		public double Tvp
		{
			get { return tvp; }


			set
			{
				tvp = Math.Max(Math.Min(Math.Round(value, 2), MaxTaxe), 0);

				OnPropertyChanged("Tvp");
				Calculer();
			}
		}

		private double taux = 0;
		public double Taux
		{
			get { return taux; }


			set
			{
				taux = Math.Max(Math.Min(Math.Round(value, 2), MaxTaux), 0);

				OnPropertyChanged("Taux");
				Calculer();
			}
		}



		public double Total { get; set; }
		public double Mensualites { get; set; }
		public double Difference { get; set; }
		public void Calculer()
		{
			try
			{	
				Total = Math.Max((Prix - Echange) * (Tvp/100 + 1) - Mdf + Solde, 0);
				Mensualites = -Financial.Pmt((Taux/100)/12, Duree, Total, 0, DueDate.EndOfPeriod);
				Difference = Mensualites * Duree - Total;
			} catch (ArgumentException e)
			{

			}

			OnPropertyChanged("Total");
			OnPropertyChanged("Mensualites");
			OnPropertyChanged("Difference");
		}

	}
}
