using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallodaApp
{
    internal class Szoba
    {
        public int SzobaSzam { get;}
        protected int alapar;
        public int Alapar
        {
            get { return alapar; }
            set
            {
                if (value > 0)
                {
                    alapar = value;
                }

            } 
        }

        public Szoba(int szobaszam, int alapAr)
        {
            SzobaSzam = szobaszam;
            Alapar = alapAr;
        }

        public virtual int ArKiszamitas(int ejszakakSzama)
        {
            return ejszakakSzama * Alapar;
        }
        public override string ToString()
        {
            return $"Szoba száma: {SzobaSzam} | Alapár: {Alapar} Ft/éj";
        }

    }
}
