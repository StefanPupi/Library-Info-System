using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjizaraprojekat
{
    public class StavkaRacuna
    {
        int id_racun;
        int id_knjiga;
        double cena;
        double popust;

        public StavkaRacuna() { }
        public StavkaRacuna(int idr,int idk,double cen, double pop)
        {
            id_racun = idr;
            id_knjiga = idk;
            cena = cen;
            popust = pop;
        }
        public int Id_racun { get => id_racun; set => id_racun = value; }
        public int Id_knjiga { get => id_knjiga; set => id_knjiga = value; }
        public double Cena { get => cena; set => cena = value; }
        public double Popust { get => popust; set => popust = value; }

        public override string ToString()
        {
            return $"ID Racuna:{id_racun}, ID Knjige: {id_knjiga}, Cena: {cena}";
        }
    }
}
