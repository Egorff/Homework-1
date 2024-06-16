using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Console_IO
{
    public static class ConsoleIO<Tout>
    {
        public delegate Tout Converter(string value, out bool state, out string error);

        public delegate bool Validator(Tout value, out string error);

        public static Tout Input(string inpMsg, Converter converter, Validator validator = null)
        {
            Tout res;

            string error = string.Empty;

            bool convertion_success = false;

            do
            {
                if (!String.IsNullOrEmpty(error))
                    Console.WriteLine(error);

                Console.WriteLine(inpMsg);

                string temp = Console.ReadLine();

                res = converter(temp, out convertion_success, out error);

                if(!convertion_success)
                    continue;

                if (!(validator?.Invoke(res, out error) ?? false))
                {
                    break;
                }

            } while (true);

            return res;
        }

        #region Static Functions

        public static Tout Convert(string value, out bool state, out string error)
        {
            Tout res;

            try
            {
                
            }
            catch (Exception e)
            {

                throw;
            }
        }

        #endregion
    }
}
