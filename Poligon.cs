using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Poligon3_9_2026b
{
    internal class Poligon
    {
        public int br_temena;
        public Tacka[] teme;
        public Poligon(int n)
        {
            br_temena= n;
            teme = new Tacka[n];
        }
        public static Poligon unos()
        {
            Console.WriteLine("Koliko temena?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(n);
            for(int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                Console.WriteLine("x koord tacke {0}=", i + 1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y koord tacke {0}=", i + 1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public void stampa()
        {
            Console.WriteLine("Poligon ima {0} temena i ona su:", br_temena);
            for(int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("Tacka {0}: koordinata x - {0}, koordinata y - {0}", i + 1, teme[i].x, teme[i].y);
            }
        }
        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(br_temena);
            for(int i = 0; i < br_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        public static Poligon ucitaj()
        {
            return null;
        }
    }
}
