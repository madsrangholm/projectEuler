using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem001
{
    public class Problem001
    {
        public static int Execute()
        {
            var sum = 0;
            for (var i = 0; i < 1000; i++)
            {
                if (i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
