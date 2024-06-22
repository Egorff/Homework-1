using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary_Net_Core_4._8
{
    public static class Compl_Square_Selector
    {
        public static List<double> GetComplSquare(List<double> coeficients)
        {
            if (coeficients.Count != 3) throw new Exception("The count of coeficients must be 3!");

            //Perform calculation 

            double p = coeficients[1] / 2;
            double q = Math.Pow(coeficients[2], 2) - p * p;

            List<double> result = new List<double>();
            result.Add(Math.Sqrt(coeficients[0]));
            result.Add(p);
            result.Add(q);

            return result;
        }
    }
}
