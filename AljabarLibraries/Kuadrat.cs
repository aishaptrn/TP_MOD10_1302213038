using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AljabarLibraries
{
    public class Kuadrat
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double r = Math.Sqrt((b * b) - (4 * a * c));

            double x1, x2;

            if (r >= 0)
            {
                x1 = (-b + r) / (2 * a);
                x2 = (-b - r) / (2 * a);

                return new double[] { x1, x2 };
            } 
            else
            {
                return new double[] { };
            }
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            double a2 = a * a;
            double b2 = b * b;
            double ab = 2 * a * b;

            return new double[] { a2, ab, b2 };
        }
    }
}
