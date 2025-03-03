namespace source._1200._1278;

/// <summary>
///     <a href="https://leetcode.cn/problems/palindrome-partitioning-iii">
///         1278. Palindrome Partitioning III
///     </a>
/// </summary>
public class Solution
{
    public int PalindromePartition(string s, int k)
    {
        int n = s.Length;
        int[,] f = new int[n + 1, k + 1];

        for (int i = 0; i <= n; ++i)
        for (int j = 0; j <= k; ++j)
        {
            f[i, j] = int.MaxValue;
        }

        f[0, 0] = 0;
        for (int i = 1; i <= n; ++i)
        for (int j = 1; j <= Math.Min(k, i); ++j)
        {
            if (j == 1)
            {
                f[i, j] = PalindromePartition(s, 0, i - 1);
            }
            else
            {
                for (int v = j - 1; v < i; ++v)
                {
                    f[i, j] = Math.Min(f[i, j], f[v, j - 1] + PalindromePartition(s, v, i - 1));
                }
            }
        }

        return f[n, k];
    }

    private int PalindromePartition(string s, int start, int end)
    {
        int cost = 0;

        while (start < end)
        {
            if (s[start] != s[end])
            {
                ++cost;
            }

            ++start;
            --end;
        }

        return cost;
    }
}