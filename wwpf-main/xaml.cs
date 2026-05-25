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
using System.IO;
using System.Linq;

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<Cellovo> list = new List<Cellovo>();

        public MainWindow()
        {
            InitializeComponent();
            string[] osszes = File.ReadAllLines("lovesek.csv");

            foreach (var item in osszes)
            {
                list.Add(new Cellovo(item));
            }

            dg.ItemsSource = list;
            dg.Items.Refresh();
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {
            string nev = nev_box.Text;
            int loves1 = Convert.ToInt32(l1.Text);
            int loves2 = Convert.ToInt32(l2.Text);
            int loves3 = Convert.ToInt32(l3.Text);
            int loves4 = Convert.ToInt32(l4.Text);

            if (loves1 > 99 || loves1 < 0 || loves2 > 99 || loves2 < 0 || loves3 > 99 || loves3 < 0 || loves4 > 99 || loves4 < 0)
            {
                MessageBox.Show("szar");
            }
            else
            {
                Cellovo c = new Cellovo(nev, loves1, loves2, loves3, loves4);
                list.Add(c);

                dg.ItemsSource = list;
                dg.Items.Refresh();
            }
        }

        private void mentes_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("lovesek2.csv");

            try
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
                MessageBox.Show("Sikeres mentés");
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba");
            }
        }
    }
}
