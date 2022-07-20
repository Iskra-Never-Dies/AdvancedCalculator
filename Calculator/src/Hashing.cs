using System;
using System.Security.Cryptography;
using System.Text;

namespace Calculator
{
    public class Hashing
    {
        public static string generateshastring(__arglist)
        {
            ArgIterator iterator = new(__arglist);
            var number = __refvalue(iterator.GetNextArg(), int);
            
            SHA512 shaM = new SHA512Managed();
            string result = Encoding.UTF8.GetString(shaM.ComputeHash(Encoding.UTF8.GetBytes(Convert.ToString(number))));
            return result;
        }
    }
}