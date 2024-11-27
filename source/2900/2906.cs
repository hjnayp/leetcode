namespace source._2900._2906;

/// <summary>
///     <a href="https://leetcode.cn/problems/construct-product-matrix">
///         Construct Product Matrix
///     </a>
/// </summary>
public class Solution
{
    private const int MOD = 12345;

    public int[][] ConstructProductMatrix(int[][] grid)
    {
        int n = grid.Length;
        int m = grid[0].Length;
        int[][] product = new int[n][];
        for (int i = 0; i < n; ++i)
        {
            product[i] = new int[m];
        }

        long suffix = 1;
        for (int i = n - 1; i >= 0; --i)
        for (int j = m - 1; j >= 0; --j)
        {
            product[i][j] = (int)suffix;
            suffix = suffix * grid[i][j] % MOD;
        }

        long prefix = 1;
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                product[i][j] = product[i][j] * (int)prefix % MOD;
                prefix = prefix * grid[i][j] % MOD;
            }
        }

        return product;
    }
}