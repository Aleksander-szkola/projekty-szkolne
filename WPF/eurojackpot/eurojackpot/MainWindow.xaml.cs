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

namespace eurojackpot
{
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void los_bez_duplikatow()
        {

            HashSet<int> numbers = new HashSet<int>();

            HashSet<int> euroNumbers = new HashSet<int>();

            while (numbers.Count < 5)
            {
                numbers.Add(random.Next(1, 51));
            }

            while (euroNumbers.Count < 2)
            {
                euroNumbers.Add(random.Next(1, 11));
            }

            string wylosowaneLiczby = string.Join(" ", numbers.OrderBy(n => n));
            string euroNumery = string.Join(" ", euroNumbers.OrderBy(n => n));

            wynikiTextBlock.Text = "Wylosowane liczby: " + wylosowaneLiczby;
            euroNumeryTextBlock.Text = "Euro Numery: " + euroNumery;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            los_bez_duplikatow();
        }
    }
}