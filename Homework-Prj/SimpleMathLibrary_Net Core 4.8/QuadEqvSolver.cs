using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary_Net_Core_4._8
{
    public static class QuadEqvSolver
    {
        public static (string, string) Solve(double a, double b, double c)
        {
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D > 0) 
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);

                double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                return ($"x1 = {x1}, ", $"x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);

                return ($"x = {x}", "");
            }
            else
            {
                throw new Exception("Discriminant can't be less then zero. There aren't any solutions for your equation.");
            }
        }
    }
}