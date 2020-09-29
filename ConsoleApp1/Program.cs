using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A legkisebb címlet 1000 Ft, a maximálisan felvehető összeg 300 000 Ft.");
            Console.Write("Afja meg mekkora összeget kíván felvenni! " );
                int osszeg = Convert.ToInt32(Console.ReadLine());
            if (osszeg >= 1000 && osszeg <= 300000)
            {
                Console.WriteLine("A kiadott bankjegyek: " );
                Console.WriteLine(osszeg / 10000 +"* 10000 = " + (osszeg/10000)*1000);
            }


            Console.WriteLine("Összeg:    " +osszeg);

            //második feladat
            Console.Write("Add meg a megtett utat km-ben! ");
            double megtettut = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg az autó fogyasztását 100 kmre literben! ");
            double fogyasztas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg az uzemanyagárat ft-ban! ");
            double ár = Convert.ToDouble(Console.ReadLine());

           

            if (megtettut <= 100)
            {
                Console.WriteLine("költségtérités: " + (megtettut * fogyasztas * ár) / 100 + " ft");
            }
            else
            {
                Console.WriteLine("költségtérités: " + ((megtettut * 25)* fogyasztas * ár) / 100 + " ft");
            }

            //harmadik feladat

            Console.Write("adja meg a tömegét kg-ban! ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("adja meg a magasságát cm-ben! ");
            double cm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a tti-d : " + kg /((cm/100)*(cm/100)));

            Console.ReadKey();
        }
    }
}
