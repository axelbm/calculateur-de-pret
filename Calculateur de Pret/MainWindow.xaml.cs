using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculateur_de_Pret
{
	/// <summary>
	/// Logique d'interaction pour MainWindow.xaml
	/// </summary>


	public partial class MainWindow : Window
	{
		private Calculateur Calc;
		public static MainWindow Main;


		public MainWindow()
		{
			InitializeComponent();

			ShowVersement();

			Calc = new Calculateur();

			Main = this;
			Calc.Prix = 21;

		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			ShowVersement();
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			ShowMax();
		}

		private void ShowVersement()
		{
			this.CalVersement.Visibility = Visibility.Visible;
			this.CalMax.Visibility = Visibility.Hidden;

			this.BtnVersement.Background = Brushes.Red;
			this.BtnMax.Background = Brushes.White;
		}

		private void ShowMax()
		{
			this.CalVersement.Visibility = Visibility.Hidden;
			this.CalMax.Visibility = Visibility.Visible;

			this.BtnVersement.Background = Brushes.White;
			this.BtnMax.Background = Brushes.Red;
		}


		private void IsTextAllowed(object sender, TextCompositionEventArgs e)
		{
			Regex regex = new Regex("[^0-9]+");
			e.Handled = regex.IsMatch(e.Text);
		}


	}
}
