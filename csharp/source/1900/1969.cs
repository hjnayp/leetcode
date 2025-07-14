namespace source._1900._1969;

public class Solution
{
    public int MinNonZeroProduct(int p)
    {
        if (p == 1) return 1;

        const int MOD = 1_000_000_007;
        long x = FastPow(2, p, MOD) - 1;
        long y = (long)1 << (p - 1);
        return (int)(FastPow(x - 1, y - 1, MOD) * x % MOD);

        long FastPow(long x, long n, long mod)
        {
            long res = 1;
            for (; n != 0; n >>= 1)
            {
                if ((n & 1) != 0)
                    res = res * x % mod;
                x = x * x % mod;
            }

            return res;
        }
    }
}