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

        var memo = new long[m + 1, n + 1];
        for (var i = 0; i <= m; ++i)
        for (var j = 0; j <= n; ++j)
            memo[i, j] = -1;

        return Dfs(m, n);

        long Dfs(int a, int b)
        {
            if (memo[m, n] > -1) return memo[m, n];

            long key = PairHash(a, b);
            long res = value.GetValueOrDefault(key, 0);

            if (a > 1)
                for (var i = 1; i < a; ++i)
                    res = Math.Max(res, Dfs(i, b) + Dfs(a - i, b));

            if (b > 1)
                for (var i = 1; i < b; ++i)
                    res = Math.Max(res, Dfs(a, i) + Dfs(a, b - i));

            memo[a, b] = res;
            return res;
        }

        long PairHash(int a, int b)
        {
            return ((long)a << 16) ^ b;
        }
    }
}