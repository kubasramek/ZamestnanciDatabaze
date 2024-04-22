using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamestnanciDatabaze
{
    public class Zamestnanec //nezapomenout na public !!
    {
        public Zamestnanec(int? iD, string jmeno, string prijmeni, DateTime datumnarozeni) //konstruktor který zařídí že si mužeme navolit nebo dosadit parametry
        {
            ID = iD;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Datumnarozeni = datumnarozeni;
        }


        // založení proměnných(parametrů)
        public int? ID { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime Datumnarozeni { get; set; }

        public override string ToString() // metoda která vypíše jednotlivé parametry 
        {
            return $"{Jmeno} {Prijmeni} {Datumnarozeni.ToShortDateString()}";
        }
    }
    
}
