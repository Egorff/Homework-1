using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary_Net_Core_4._8
{
    public class Compl_Square_Selector
    {
        #region Fields

        double p = 0;
        double q = 0;

        #endregion

        public static string GetComplSquare(List<double> coeficients)
        {
            if (coeficients.Count != 3) throw new Exception("The count of coeficients must be 3!");

            //Perform calculation 

            //double a = Math.Sqrt(coeficients[0]);
            double p = coeficients[1] / 2;
            double q = Math.Pow(coeficients[2], 2) - p * p;

            if (q >= 0)
                return $"({Math.Sqrt(coeficients[0])} + {p})2 + {q}";
            else
                return $"({Math.Sqrt(coeficients[0])} + {p})2 - {q}";
        }
    }
}
