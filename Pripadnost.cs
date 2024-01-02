using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjizaraprojekat
{
    public class Pripadnost
    {
        int id_knjiga;
        int id_zanr;

        public Pripadnost() { }
        public Pripadnost(int idk,int idz)
        {
            id_knjiga = idk;
            id_zanr = idz;
        }

        public int Id_knjiga { get => id_knjiga; set => id_knjiga = value; }
        public int Id_zanr { get => id_zanr; set => id_zanr = value; }
    }
}
