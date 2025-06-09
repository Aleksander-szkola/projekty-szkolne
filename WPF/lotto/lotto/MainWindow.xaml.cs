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

namespace lotto
{
    public partial class MainWindow : Window
    {
        Random random = new Random();
        String wylosowane = "";

        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                int liczba = random.Next(1, 50);
                wylosowane += liczba.ToString() + " ";
            }
            liczby.Text = wylosowane;
        }

        private void los_bez_duplikatow()
        {
            HashSet<int> set = new HashSet<int>();

            while (set.Count != 6)
            {
                int liczba = random.Next(1, 50);
                set.Add(liczba);
            }
            String wylos = string.Join(" ", set);
            liczby.Text = wylos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            los_bez_duplikatow();
        }
    }
}