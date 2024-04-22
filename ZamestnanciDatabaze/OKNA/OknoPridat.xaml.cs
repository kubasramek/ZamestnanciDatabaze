using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ZamestnanciDatabaze.OKNA
{
    /// <summary>
    /// Interakční logika pro OknoPridat.xaml
    /// </summary>
    public partial class OknoPridat : Window
    {
        List<Zamestnanec> _zamestnanci;
        public OknoPridat(List<Zamestnanec> zamestnanci)
        {
           
            InitializeComponent();
            _zamestnanci = zamestnanci;
        }

        private int VytvorID() => _zamestnanci.Count + 1;

        //buton pro uložení
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string jmeno = TBJmeno.Text;
            string prijmeni = TBPrijmeni.Text;
            DateTime narozeni = DateTime.Parse(DPDatum.Text); //takto uložíme datum z datepickeru

            Zamestnanec Novy = new Zamestnanec(VytvorID(),jmeno, prijmeni, narozeni);
            _zamestnanci.Add(Novy);

            this.Close();
        }


        //button pro zavření
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
