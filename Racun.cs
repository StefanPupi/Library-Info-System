using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjizaraprojekat
{
    public class Racun
    {
        int id_racun;
        DateTime datum;
        double ukupna_cena;

        public Racun() { }
        public Racun(int idr,DateTime dat, double cen)
        {
            id_racun = idr+1;
            datum = dat;
            ukupna_cena = cen;
        }

        public int Id_racun { get => id_racun; set => id_racun = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public double Ukupna_cena { get => ukupna_cena; set => ukupna_cena = value; }

        public override string ToString()
        {
            return $"ID:{id_racun}, Datum:{datum}, Ukupna cena:{ukupna_cena}";
        }
    }
}
