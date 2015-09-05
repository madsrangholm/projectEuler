using System;

namespace Problem004
{
    public static class Code
    {
        public static long LargestPalindrome(long digitsPerNumber)
        {
            long result = 0;
            var maxValue = Convert.ToInt64(Math.Pow(10, digitsPerNumber));
            var startValue = Convert.ToInt64(Math.Pow(10, digitsPerNumber - 1));
            for (long i = startValue; i < maxValue; i++)
            {
                for (long j = i; j < maxValue; j++)
                {
                    if (IsPalinDrome(i*j) && result < i *j)
                    {
                        result = i*j;
                    }
                }
            }
            return result;
        }

        private static bool IsPalinDrome(long num)
        {
            var numAsText = num.ToString();
            for (var i = 0; i < numAsText.Length; i++)
            {
                if (numAsText[i] != numAsText[numAsText.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}