namespace source._3400._3405;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-the-number-of-arrays-with-k-matching-adjacent-elements">
///         3405. Count the Number of Arrays with K Matching Adjacent Elements
///     </a>
/// </summary>
public class Solution
{
    private const int MOD = 1_000_000_007;
    private const int MX = 100000;
    private static readonly long[] s_fact = new long[MX];
    private static readonly long[] s_invFact = new long[MX];

    private long Qpow(long x, int n)
    {
        long res = 1;
        while (n > 0)
        {
            if ((n & 1) == 1)
            {
                res = res * x % MOD;
            }

            x = x * x % MOD;
            n >>= 1;
        }

        return res;
    }

    private void Init()
    {
        if (s_fact[0] != 0)
        {
            return;
        }

        s_fact[0] = 1;
        for (int i = 1; i < MX; i++)
        {
            s_fact[i] = s_fact[i - 1] * i % MOD;
        }

        s_invFact[MX - 1] = Qpow(s_fact[MX - 1], MOD - 2);
        for (int i = MX - 1; i > 0; i--)
        {
            s_invFact[i - 1] = s_invFact[i] * i % MOD;
        }
    }

    private long Comb(int n, int m)
    {
        return s_fact[n] * s_invFact[m] % MOD * s_invFact[n - m] % MOD;
    }

    public int CountGoodArrays(int n, int m, int k)
    {
        Init();
        return (int)(Comb(n - 1, k) * m % MOD * Qpow(m - 1, n - k - 1) % MOD);
    }
}