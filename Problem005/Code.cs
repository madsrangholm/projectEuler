namespace Problem005
{
    public static class Code
    {
        public static long SmallestMultiple(int min, int max)
        {
            var testedNumber = max;
            while (true)
            {
                for (var i = min; i <= max; i++)
                {
                    if (testedNumber%i != 0)
                    {
                        break;
                    }
                    if (i == max)
                    {
                        return testedNumber;
                    }
                }
                testedNumber++;
            }
        }
    }
}