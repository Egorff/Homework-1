using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary_Net_Core_4._8
{
    public class Coeficients
    {
        public double a2 { get; }

        public double ab2 { get; }

        public double b2 { get; }

        public Coeficients(double a2, double ab2, double b2)
        {
            this.a2 = a2;
            this.ab2 = ab2;
            this.b2 = b2;
        }
    }

    public class Compl_Square_Selector
    {
        public static List<double>GetComplSquare(List<double> coeficients)
        {
            if (coeficients.Count != 3) throw new Exception("The count of coeficients must be 3!");

            //Perform calculation 
        }
    }
}
