using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem002
{
    public class Problem002
    {
        public static int Execute()
        {
            var sum = 2;// starts at 2 to account for the initial value of num2
            var num1 = 1;
            var num2 = 2;
            var useNum1 = true; // determines what number to update
            do
            {
                var tmp = num1 + num2;
                Console.WriteLine(tmp);
                if (tmp%2 == 0)
                {
                    sum += tmp;
                }
                if (useNum1)
                {
                    num1 = tmp;
                }
                else
                {
                    num2 = tmp;
                }
                useNum1 = !useNum1;
            } while (num1 + num2 < 4000000);
            return sum;
        }
    }
}
