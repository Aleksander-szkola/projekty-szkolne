using System.Windows.Forms;

namespace Structure_List
{
    public partial class Form1 : Form
    {

        private Dane d;
        private List<Dane> list = new List<Dane>();
        private int idBiezacy = 0;

        struct Dane
        {
            public string nazwisko;
            public string imie;
            public string klasa;
        }

        private void dodaj()
        {
            czyscDana();
            d.nazwisko = textBox1.Text;
            d.imie = textBox2.Text;
            d.klasa = textBox3.Text;
            list.Add(d);
            idBiezacy = list.Count - 1;
        }

        private void czyscDana()
        {
            d.nazwisko = "";
            d.imie = "";
            d.klasa = "";

        }

        private void czyscEdycje()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;

        }
        private void pokazListe(TextBox tb)
        {
            tb.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                tb.AppendText((i + 1).ToString() + "********************" + Environment.NewLine);
                tb.AppendText(list[i].nazwisko + Environment.NewLine);
                tb.AppendText(list[i].imie + Environment.NewLine);
                tb.AppendText(list[i].klasa + Environment.NewLine);


            }
        }

        public void pokazRekord(int id, TextBox tb)
        {
            if (id < 0 || id > list.Count - 1) return;
            d = list[id];
            tb.Clear();
            tb.AppendText((id + 1).ToString() + Environment.NewLine);
            tb.AppendText(d.nazwisko + Environment.NewLine);
            tb.AppendText(d.imie + Environment.NewLine);
            tb.AppendText(d.klasa + Environment.NewLine);


        }

        public void pokazID(int id, TextBox tbID)
        {

            if (id < 0 || id > list.Count - 1) return;
            d = list[id];
            tbID.Clear();
            tbID.AppendText((id + 1).ToString() + Environment.NewLine);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dodaj();
            toolStripStatusLabel1.Text = list.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pokazListe(textBox4);
            czyscEdycje();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pokazListe(textBox4);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            idBiezacy = 0;
            pokazRekord(idBiezacy, textBox4);
            pokazID(idBiezacy, textBox5);
        }

        public void button6_Click(object sender, EventArgs e)
        {
            idBiezacy--;
            if (idBiezacy < 0) idBiezacy = 0;
            pokazRekord(idBiezacy, textBox4);
            pokazID(idBiezacy, textBox5);
        }

        public void button7_Click(object sender, EventArgs e)
        {
            idBiezacy++;
            if (idBiezacy < 0) idBiezacy = 0;
            pokazRekord(idBiezacy, textBox4);
            pokazID(idBiezacy, textBox5);
        }


        private void button9_Click(object sender, EventArgs e)
        {
            list.RemoveRange(idBiezacy, 1);
            toolStripStatusLabel1.Text = list.Count.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            list.Clear();
            toolStripStatusLabel1.Text = list.Count.ToString();
            textBox4.Text = "";


            if (list.Count == 0)
            {
                textBox5.Text = "";
            }
        }
        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {

            if (textBox5.Text.Length < 1)
            {
                idBiezacy = 0;
            }
            else
            {
                idBiezacy = Convert.ToInt16(textBox5.Text) - 1;
            }
            pokazRekord(idBiezacy, textBox4);

        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}