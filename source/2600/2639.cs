namespace source._2600._2639;

public class Solution
{
    public static int Length(int num)
    {
        if (num == 0) return 1;
        bool isNegative = num < 0;
        if (isNegative) num = -num;
        int length = 0;
        while (num > 0)
        {
            num /= 10;
            length++;
        }

        return length + (isNegative ? 1 : 0);
    }

    public int[] FindColumnWidth(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;

        int[] res = new int[n];
        for (int j = 0; j < n; ++j)
        {
            int maxLength = 0;
            for (int i = 0; i < m; ++i)
            {
                int length = Length(grid[i][j]);
                if (length > maxLength)
                    maxLength = length;
            }

            res[j] = maxLength;
        }

        return res;
    }
}