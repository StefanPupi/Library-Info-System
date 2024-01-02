using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjizaraprojekat
{
    public class Knjiga
    {
        int id_knjiga;
        string autor;
        string naziv;
        double cena;
        double popust;
        int broj_strana;

        public Knjiga() { }

        public Knjiga(int id,string aut,string naz,double cen,double pop,int brs)
        {
            id_knjiga = id+1;
            autor = aut;
            naziv = naz;
            cena = cen;
            popust = pop;
            broj_strana = brs;
        }

        public int Id_knjiga { get => id_knjiga; set => id_knjiga = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cena { get => cena; set => cena = value; }
        public double Popust { get => popust; set => popust = value; }
        public int Broj_strana { get => broj_strana; set => broj_strana = value; }

        public override string ToString()
        {
            return $"Naziv:{naziv}, Autor:{autor}, cena:{cena}";
        }
    }
}
