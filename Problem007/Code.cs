using System;

namespace Problem007
{
    public static class Code
    {
        public static long FindPrime(long index)
        {
            var count = 1;
            var number = 2;
            while (count < index)
            {
                number++;
                if (IsPrime(number))
                {
                    count++;
                }
                if (count == index) break;
            }
            return number;
        }

        public static bool IsPrime(long num)
        {
            var numSquared = Convert.ToInt64(Math.Sqrt(num));
            for (var i = 2; i <= numSquared; i++)
            {
                if (num%i == 0) return false;
            }
            return true;
        }
    }
}