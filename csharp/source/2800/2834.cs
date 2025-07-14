namespace source._2800._2834;

public class Solution
{
    public int MinimumPossibleSum(int n, int target)
    {
        const int Mod = (int)1e9 + 7;

        int m = target >> 1;
        if (m >= n)
            return (int)((1 + n) * (long)n / 2) % Mod;

        return (int)((long)(1 + m) * m / 2 % Mod
                     + ((long)target + (target + n - m - 1)) * (n - m) / 2 % Mod) % Mod;
    }
}