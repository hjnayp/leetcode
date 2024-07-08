namespace source._2300._2312;

public class Solution
{
    public long SellingWood(int m, int n, int[][] prices)
    {
        var value = new Dictionary<long, int>();
        foreach (int[] price in prices)
        {
            long key = PairHash(price[0], price[1]);
            value[key] = price[2];
        }

        long[,] memo = new long[m + 1, n + 1];
        for (int i = 0; i <= m; ++i)
        for (int j = 0; j <= n; ++j)
        {
            memo[i, j] = value.GetValueOrDefault(PairHash(i, j), 0);
        }

        for (int x = 1; x <= m; ++x)
        for (int y = 1; y <= n; ++y)
        {
            if (x > 1)
            {
                for (int i = 1; i < x / 2 + 1; ++i)
                {
                    memo[x, y] = Math.Max(memo[x, y], memo[i, y] + memo[x - i, y]);
                }
            }

            if (y > 1)
            {
                for (int j = 1; j < y / 2 + 1; ++j)
                {
                    memo[x, y] = Math.Max(memo[x, y], memo[x, j] + memo[x, y - j]);
                }
            }
        }

        return memo[m, n];

        long PairHash(int a, int b)
        {
            return ((long)a << 16) ^ b;
        }
    }
}