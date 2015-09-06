using System;

namespace Problem009
{
    public static class Code
    {
        public static long PytagorianTripletProduct(int sum)
        {
            for (long a = 1; a < sum; a++)
            {
                for (var b = a + 1; b < sum; b++)
                {
                    var c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    if (c == Math.Floor(c) && a + b + Convert.ToInt64(c) == sum)
                    {
                        return a*b*Convert.ToInt64(c);
                    }
                }
            }
            return -1;
        }
    }
}