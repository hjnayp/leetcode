using System.Numerics;

namespace source._0500._552;

public class Solution
{
    private const int Mod = (int)1e9 + 7;

    public int CheckRecord(int n)
    {
        long[,] counts = new long[2, 3];
        counts[0, 0] = 1;

        for (int i = 0; i < n; ++i)
        {
            long[,] newCounts = new long[2, 3];

            // End with 'P'
            for (int j = 0; j < 2; ++j)
            for (int k = 0; k < 3; ++k)
            {
                newCounts[j, 0] = (newCounts[j, 0] + counts[j, k]) % Mod;
            }

            // End with 'A'
            for (int j = 0; j < 3; ++j)
            {
                newCounts[1, 0] = (newCounts[1, 0] + counts[0, j]) % Mod;
            }

            // End with 'L'
            for (int j = 0; j < 2; ++j)
            for (int k = 1; k < 3; ++k)
            {
                newCounts[j, k] = (newCounts[j, k] + counts[j, k - 1]) % Mod;
            }

            counts = newCounts;
        }

        long count = 0;
        for (int i = 0; i < 2; ++i)
        for (int j = 0; j < 3; j++)
        {
            count = (counts[i, j] + count) % Mod;
        }

        return (int)count;
    }
}