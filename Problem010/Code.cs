namespace Problem010
{
    public static class Code
    {
        public static long SumOfPrimes(long upperLimit)
        {
            long result = 0;
            for (var i = 2; i < upperLimit; i++)
            {
                if (Problem007.Code.IsPrime(i))
                {
                    result += i;
                }
            }
            return result;
        }
    }
}