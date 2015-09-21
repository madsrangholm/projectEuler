
namespace Problem015
{
    public static class Code
    {
        public static long LatticeRoutes(int xDim, int yDim)
        {
            var array = new long[xDim + 1, yDim + 1];
            array[0, 0] = 1;
            for (var i = 1; i <= xDim + yDim; i++)
            {
                for (var x = 0; x <= xDim; x++)
                {
                    for (var y = 0; y <= yDim; y++) //This loop should be eliminated.
                    {
                        if (x + y == i)
                        {
                            array[x, y] = (x > 0 ? array[x - 1, y] : 0) + (y > 0 ? array[x, y - 1] : 0);
                            break;
                        }
                    }
                }
            }
            return array[xDim, yDim];
        }
    }
}
