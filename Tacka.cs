using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon3_9_2026b
{
    internal class Tacka
    {
        public double x, y;
        public Tacka()
        {
            x = 0;
            y = 0;
        }
        public Tacka(double a, double b)
        {
            x = a;
            y = b;
        }
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public static bool jednaka(Tacka A, Tacka B)
        {
            return (A.x == B.x) && (A.y == B.y);
        }
    }
}
