namespace source._0900._935;

/// <summary>
///     <a href="https://leetcode.cn/problems/knight-dialer">
///         935. Knight Dialer
///     </a>
/// </summary>
public class Solution
{
    private const int MOD = 1000000007;

    public int KnightDialer(int n)
    {
        int[][] transform =
        [
            [0, 0, 0, 0, 1, 0, 1, 0, 0, 0],
            [0, 0, 0, 0, 0, 0, 1, 0, 1, 0],
            [0, 0, 0, 0, 0, 0, 0, 1, 0, 1],
            [0, 0, 0, 0, 1, 0, 0, 0, 1, 0],
            [1, 0, 0, 1, 0, 0, 0, 0, 0, 1],
            [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
            [1, 1, 0, 0, 0, 0, 0, 1, 0, 0],
            [0, 0, 1, 0, 0, 0, 1, 0, 0, 0],
            [0, 1, 0, 1, 0, 0, 0, 0, 0, 0],
            [0, 0, 1, 0, 1, 0, 0, 0, 0, 0],
        ];

        int[][] value = new int[10][];
        for (int i = 0; i < 10; i++)
        {
            value[i] = new int[10];
            value[i][i] = 1;
        }

        n--;
        while (n > 0)
        {
            if ((n & 1) != 0)
            {
                value = Mul(value, transform);
            }

            transform = Mul(transform, transform);
            n >>= 1;
        }

        int[][] res = [[1, 1, 1, 1, 1, 1, 1, 1, 1, 1]];
        res = Mul(res, value);
        return res[0].Aggregate(0, (current, x) => (current + x) % MOD);
    }

    private static int[][] Mul(int[][] lth, int[][] rth)
    {
        int[][] res = new int[lth.Length][];
        for (int i = 0; i < lth.Length; i++)
        {
            res[i] = new int[rth[0].Length];
        }

        for (int k = 0; k < lth[0].Length; k++)
        for (int i = 0; i < lth.Length; i++)
        for (int j = 0; j < rth[0].Length; j++)
        {
            res[i][j] = (int)((res[i][j] + 1L * lth[i][k] * rth[k][j] % MOD) % MOD);
        }

        return res;
    }
}