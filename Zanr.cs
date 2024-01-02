using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjizaraprojekat
{
    public class Zanr
    {
        int id_zanr;
        string naziv;

        public Zanr() { }

        public Zanr(string naz)
        {
            naziv = naz;
        }
        public int Id_zanr { get => id_zanr; set => id_zanr = value; }
        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            return $"{naziv}";
        }
    }
}
