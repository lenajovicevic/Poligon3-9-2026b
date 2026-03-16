using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon3_9_2026b
{
    internal class Vektor
    {
        public Tacka pocetak, kraj;
        public Vektor (Tacka A, Tacka B)
        {
            pocetak = A;
            kraj = B;
        }
        public Tacka Centriraj()
        {
            Tacka Nova = new Tacka(kraj.x - pocetak.x, kraj.y - pocetak.y);
            return Nova;
        }
        public static double SP(Vektor a, Vektor b) 
        {
            Tacka aC = a.Centriraj();
            Tacka bC = b.Centriraj();
            return aC.x * bC.x + aC.y * bC.y;
        }
        public static double VP(Vektor a, Vektor b)
        {
            Tacka aC = a.Centriraj();
            Tacka bC = b.Centriraj();
            return aC.x * bC.y - bC.x * aC.y;
        }
    }
}
