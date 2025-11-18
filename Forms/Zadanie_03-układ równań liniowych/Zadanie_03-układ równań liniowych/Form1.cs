//zrobiłem zadanie jako pierwszy, ale źle nazwałem projekt i się za późno zorientowałem, dlatego wysyłam zadanie po czasie. Przepraszam :p
namespace Zadanie_03_układ_równań_liniowych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double a1 = double.Parse(txtA1.Text);
                double b1 = double.Parse(txtB1.Text);
                double c1 = double.Parse(txtC1.Text);
                double a2 = double.Parse(txtA2.Text);
                double b2 = double.Parse(txtB2.Text);
                double c2 = double.Parse(txtC2.Text);

                double w = a1 * b2 - b1 * a2;
                double wx = c1 * b2 - b1 * c2;
                double wy = a1 * c2 - c1 * a2;

                if (w != 0)
                {
                    double x = wx / w;
                    double y = wy / w;
                    lblWynik.Text = $"Jedno rozwiązanie:\n x = {x:F2},  y = {y:F2}";
                }
                else if (wx == 0 && wy == 0)
                {
                    lblWynik.Text = "Wynik: Układ nieoznaczony - nieskończenie wiele rozwiązań";
                }
                else
                {
                    lblWynik.Text = "Wynik: Układ sprzeczny - brak rozwiązań";
                }
            }
            catch
            {
                lblWynik.Text = "Błąd wprowadzania danych. Sprawdź poprawność wartości.";
            }
        }
    }
}