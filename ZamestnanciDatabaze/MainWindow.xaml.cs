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
using ZamestnanciDatabaze.OKNA;

namespace ZamestnanciDatabaze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zamestnanec> Zamestnanci { get; set; } //vytvoří list
        public MainWindow()
        {
            Zamestnanci = new();
            InitializeComponent();
            Seznam.ItemsSource = Zamestnanci;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OknoPridat dialog = new(Zamestnanci);
            dialog.Closing += Dialog_Closing;
            dialog.ShowDialog();
        }

        private void Dialog_Closing(object? sender, EventArgs e)
        {
            Seznam.ItemsSource = null;
            Seznam.ItemsSource = Zamestnanci;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Zamestnanec? hledany = Seznam?.SelectedItem as Zamestnanec;
            if(hledany != null)
            {
                OknoEdit edit = new OknoEdit(hledany);
                edit.Closing += Dialog_Closing;
                edit.ShowDialog();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Zamestnanec info = Seznam?.SelectedItem as Zamestnanec ?? new Zamestnanec(-1, "Neznamý", "Nenalezen", DateTime.Now);
            MessageBox.Show($"{info.ID} {info.Jmeno} {info.Prijmeni} {info.Datumnarozeni.ToShortDateString()}");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Zamestnanec? hledany = Seznam?.SelectedItem as Zamestnanec;
            MessageBoxResult volba = MessageBox.Show($"Odebrat {hledany.Jmeno}?", "Odebrat",MessageBoxButton.YesNo );
            if( volba == MessageBoxResult.Yes )
            {
                Zamestnanci.Remove(hledany);
                Seznam.ItemsSource = null;
                Seznam.ItemsSource = Zamestnanci;
            }
        }
    }
}