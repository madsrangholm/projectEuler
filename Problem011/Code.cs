using System;

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
            return largestProduct;
        }

        private static long PointMaximum(int[,] grid, int rowLength, int x, int y)
        {
            var maxSum = 0;
            //check right
            if (x + rowLength < grid.GetLength(0))
            {
                //check right
                var rightProduct = 1;
                for (var i = 0; i < rowLength; i++)
                {
                    rightProduct *= grid[x + i, y];
                }
                maxSum = Math.Max(maxSum, rightProduct);
                //check right up
                if (0 <= y - rowLength)
                {
                    var rightUpProduct = 1;
                    for (var i = 0; i < rowLength; i++)
                    {
                        rightUpProduct *= grid[x + i, y - i];
                    }
                    maxSum = Math.Max(maxSum, rightUpProduct);
                }
                if (y + rowLength < grid.GetLength(1))
                {
                    var rightDownProduct = 1;
                    for (var i = 0; i < rowLength; i++)
                    {
                        rightDownProduct *= grid[x + i, y + i];
                    }
                    maxSum = Math.Max(maxSum, rightDownProduct);
                }
            }
            if (y + rowLength < grid.GetLength(1))
            {
                var downProduct = 1;
                for (var i = 0; i < rowLength; i++)
                {
                    downProduct *= grid[x, y + i];
                }
                maxSum = Math.Max(maxSum, downProduct);
            }
            return maxSum;

            //check right down
            //check down
        }
    }
}