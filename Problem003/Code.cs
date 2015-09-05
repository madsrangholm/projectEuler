using System.Collections.Generic;
using System.Linq;

namespace Problem003
{
    public class Code
    {
        public static IEnumerable<long> PrimeFactors(long num)
        {
            var result = new List<long>();
            var remainder = num;
            var notDone = true;
            while (notDone)
            {
                notDone = false;
                for (var i = 2; i < num/2; i++)
                {
                    if (remainder%i == 0)
                    {
                        result.Add(i);
                        remainder = remainder/i;
                        notDone = 1 < remainder;
                        break;
                    }
                }
            }

            return result.Distinct().OrderBy(x => x);
        }
    }
}