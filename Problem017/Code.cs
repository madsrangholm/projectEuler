using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem017
{
    public class Code
    {
        private static readonly IDictionary<int, string> texts = new Dictionary<int, string>()
        {
            { 0, "" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "fifteen" },
            { 16, "sixteen" },
            { 17, "seventeen" },
            { 18, "eighteen" },
            { 19, "nineteen" },
            { 20, "twenty" },
            { 30, "thirty" },
            { 40, "forty" },
            { 50, "fifty" },
            { 60, "sixty" },
            { 70, "seventy" },
            { 80, "eighty" },
            { 90, "ninety" },
            { 100, "hundred" },
            { 1000, "thousand" }
        };

        public static int LetterCountSum(int min, int max)
        {
            var sum = 0;
            for(var i= min; i <= max; i++)
            {
                sum += LetterCount(i);
            }
            return sum;
        }
        public static int LetterCount(int num)
        {
            var text = NumToText(num);
            Console.WriteLine(text);
            return text.Replace(" ", "").Count();
        }
        private static string NumToText(int num)
        {
            if(num >= 1000)
            {
                return texts[num / 1000] + texts[1000] + NumToText(num % 1000);
            }
            if(num >= 100)
            {
                return texts[num / 100] + " " + texts[100] + (num%100 != 0 ? " and " : "") + NumToText(num % 100);
            }
            if(num >= 20)
            {
                return texts[(num / 10) * 10] + " " + NumToText(num % 10);
            }
            return texts[num];
        }
    }
}
