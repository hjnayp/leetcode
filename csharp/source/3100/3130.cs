namespace source._3100;

public class Solution
{
    private const int Mod = (int)1e9 + 7;

    public int NumberOfStableArrays(int zero, int one, int limit)
    {
        long[,,] stableArrayCount = new long[zero + 1, one + 1, 2];
        for (int i = 0; i <= Math.Min(zero, limit); ++i)
        {
            stableArrayCount[i, 0, 0] = 1;
        }

        for (int i = 0; i <= Math.Min(one, limit); ++i)
        {
            stableArrayCount[0, i, 1] = 1;
        }

        for (int i = 1; i <= zero; ++i)
        for (int j = 1; j <= one; ++j)
        {
            stableArrayCount[i, j, 0] = stableArrayCount[i - 1, j, 0] + stableArrayCount[i - 1, j, 1];
            stableArrayCount[i, j, 1] = stableArrayCount[i, j - 1, 0] + stableArrayCount[i, j - 1, 1];

            if (i > limit)
            {
                stableArrayCount[i, j, 0] -= stableArrayCount[i - limit - 1, j, 1];
            }

            if (j > limit)
            {
                stableArrayCount[i, j, 1] -= stableArrayCount[i, j - limit - 1, 0];
            }

            stableArrayCount[i, j, 0] = (stableArrayCount[i, j, 0] % Mod + Mod) % Mod;
            stableArrayCount[i, j, 1] = (stableArrayCount[i, j, 1] % Mod + Mod) % Mod;
        }

        return (int)((stableArrayCount[zero, one, 0] + stableArrayCount[zero, one, 1]) % Mod);
    }
}