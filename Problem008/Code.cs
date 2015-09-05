using System;
using System.Linq;

namespace Problem008
{
    public class Code
    {
        public static long LargestProduct(string series, int numDigits)
        {
            long largestProduct = 0;
            for (var i = 0; i < series.Count() - numDigits; i++)
            {
                var numArray = series.Substring(i, numDigits).Select(x => Convert.ToInt64(x.ToString()));
                var product = numArray.Aggregate((long) 1, (current, num) => current*num);
                if (largestProduct < product)
                {
                    largestProduct = product;
                }
            }
            return largestProduct;
        }
    }
}