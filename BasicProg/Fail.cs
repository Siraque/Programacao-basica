using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProg
{
    public class Fail : Exception
    {
        public static void FailException(string message)
        {
            Console.WriteLine("Error!");
        }

        internal static object FailException()
        {
            throw new NotImplementedException();
        }
    }
}
