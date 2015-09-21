using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem011
{
    public static class Code
    {
        public static long LargestProductInGrid(int[,] grid, int rowLength)
        {
            long largestProduct = 0;
            for (var x = 0; x < grid.GetLength(0); x++)
            {
                for (var y = 0; y < grid.GetLength(1); y++)
                {
                    var pointMax = PointMaximum(grid, rowLength, x, y);
                    if (largestProduct < pointMax)
                    {
                        largestProduct = pointMax;
                    }
                }
            }
            return 0;
        }

        private static long PointMaximum(int[,] grid, int rowLength, int x, int y)
        {
            //check right
            if (x + rowLength < grid.GetLength(0))
            {

                //check right up
                if (0 <= y - rowLength)
                {
                    
                }
                if (y + rowLength < grid.GetLength(1))
                {
                    
                }
            }
            return 0;

            //check right down
            //check down
        }
    }
}
