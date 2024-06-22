using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console_IO;
using SimpleMathLibrary_Net_Core_4;
using SimpleMathLibrary_Net_Core_4._8;

namespace Homework_Prj
{
    internal class Program
    {
        public static double ConvertToDouble(string value, out bool state, 
            out string error)
        {
            double res = 0;

            error = string.Empty;

            state = double.TryParse(value, out res);

            if (!state)
            {
                error = "Fail to convert to number!";
            }

            return res;
        }

        

        static void Main(string[] args)
        {
            var a = ConsoleIO<double>.Input("Input variable a", ConvertToDouble);

            var b = ConsoleIO<double>.Input("Input variable b", ConvertToDouble);

            var c = ConsoleIO<double>.Input("Input variable c", ConvertToDouble);

            

            List<double> list = new List<double>();
            list.Add(a);
            list.Add(b);
            list.Add(c);

            List<double> res = new List<double>();
            res = Compl_Square_Selector.GetComplSquare(list);

            Console.WriteLine(ConsoleIO<double>.Print(res));
        }
    }
}
