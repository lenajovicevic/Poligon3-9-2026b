using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon3_9_2026b
{
    internal class Ravan
    {
        public static int SIS (Vektor a, Tacka B, Tacka C)
        {
            // 0 sa iste strane
            // -1 sa raznih strana
            // 1 kolinearna bar jedna sa 4
            Vektor PB = new Vektor(a.pocetak, B);
            Vektor PC = new Vektor(a.pocetak, C);
            double PKPB = Vektor.VP(a, PB);
            double PKPC = Vektor.VP(a, PC);
            if (PKPB * PKPC > 0) return 0;
            if (PKPB * PKPC < 0) return -1;
            return 1;
        }
    }
}
