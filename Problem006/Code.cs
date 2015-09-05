using System;

namespace Problem006
{
    public static class Code
    {
        public static long SumSquareDifference(int min, int max)
        {
            return Math.Abs(SumOfSquares(min, max) - SquaredSum(min, max));
        }

        private static long SumOfSquares(int min, int max)
        {
            var sum = 0;
            for (var i = min; i <= max; i++)
            {
                sum += Convert.ToInt32(Math.Pow(i, 2));
            }
            return sum;
        }

        private static long SquaredSum(int min, int max)
        {
            var sum = 0;
            for (var i = min; i <= max; i++)
            {
                sum += i;
            }
            return Convert.ToInt32(Math.Pow(sum, 2));
        }
    }
}