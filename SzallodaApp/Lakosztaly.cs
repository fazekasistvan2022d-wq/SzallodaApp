using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallodaApp
{
    public class Lakosztaly : Szoba
    {
        public int ExtraSzolgaltatasAr { get; set; }

        public Lakosztaly(int szobaszam, int alapAr, int extra) : base(szobaszam,alapAr)
        {
            ExtraSzolgaltatasAr = extra;
        }

        public override int ArKiszamitas(int ejszakakSzama)
        {
            return base.ArKiszamitas(ejszakakSzama) + ExtraSzolgaltatasAr;
        }

        public override string ToString()
        {
            return base.ToString()+$" | Extra Szolgáltatás: {ExtraSzolgaltatasAr} Ft";
        }
    }
}
