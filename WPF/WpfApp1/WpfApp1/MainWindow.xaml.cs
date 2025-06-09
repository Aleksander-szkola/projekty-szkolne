using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private int a = 0, b = 0, wynik = 0, reszta = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PobierzDane()
        {
            a = Convert.ToInt32(inputA.Text);
            b = Convert.ToInt32(inputB.Text);
        }

        private void dodaj(object sender, RoutedEventArgs e)
        {
            PobierzDane();
            wynik = a + b;
            result.Content = "Wynik dodawania: " + wynik.ToString();
        }

        private void odejmij(object sender, RoutedEventArgs e)
        {
            PobierzDane();
            wynik = a - b;
            result.Content = "Wynik odejmowania: " + wynik.ToString();
        }

        private void pomnoz(object sender, RoutedEventArgs e)
        {
            PobierzDane();
            wynik = a * b;
            result.Content = "Wynik mnożenia: " + wynik.ToString();
        }

        private void podziel(object sender, RoutedEventArgs e)
        {
            PobierzDane();
            if (a * b != 0)
            {
                wynik = a / b;
                result.Content = "Wynik dzielenia: " + wynik.ToString();
            }
            else
            {
                result.Content = "Nie można dzielić przez zero!";
            }
        }

        private void modulo(object sender, RoutedEventArgs e)
        {
            PobierzDane();
            if (a * b != 0)
            {
                wynik = a % b;
                result.Content = "Modulo: " + wynik.ToString();
            }
            else
            {
                result.Content = "Nie można dzielić przez zero!";
            }
        }
    }
}