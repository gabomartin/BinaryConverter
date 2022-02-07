using System;

namespace BinaryConverterLogic
{
    public class Logic
    {
        public string IntToBinary(long x) {
            string result = "";
            long resto;
            if (x == 1)
            {
                return "1";
            }

            while (x != 0)
            {
                resto = x % 2;
                x = x / 2;
                result = (resto.ToString()) + result;

            }

            return result;
        }
        public long BinaryToInt(long x)
        {
            long dec = 0, rem, bas = 1;  //x: numero a convertir | dec: decimal (result) | rem: resto | bas: base

            while (x > 0)
            {
                rem = x % 10;
                dec = dec + rem * bas;
                x = x / 10; 
                bas = bas * 2;
            }
            return dec;
        }
    }
}
