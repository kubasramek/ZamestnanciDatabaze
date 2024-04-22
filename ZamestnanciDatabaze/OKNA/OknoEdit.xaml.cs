﻿using System;
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
    /// Interakční logika pro OknoEdit.xaml
    /// </summary>
    public partial class OknoEdit : Window
    {
        public Zamestnanec Z {  get; set; }
        public OknoEdit(Zamestnanec z)
        {
            InitializeComponent();
            Z = z;
            DataContext = Z;
        }


        //ulozit
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Z.Jmeno = ProJmeno.Text;
            Z.Prijmeni = ProPrijmeni.Text;
            Z.Datumnarozeni = DateTime.Parse(ProDatum.Text);


            this.Close();
        }

        //zahodit
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
