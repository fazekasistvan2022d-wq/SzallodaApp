using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzallodaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szoba szoba1 = new Szoba(101, 20000 );
            Lakosztaly lakosztaly1 = new Lakosztaly(501, 40000, 15000);

            szoba1.Alapar = -5000;

            Console.WriteLine(szoba1);
            Console.WriteLine(lakosztaly1);

            Console.WriteLine(szoba1.ArKiszamitas(3));
            Console.WriteLine(lakosztaly1.ArKiszamitas(3));
        }
    }
}
