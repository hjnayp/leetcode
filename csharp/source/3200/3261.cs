namespace source._3200._3261;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-substrings-that-satisfy-k-constraint-ii">
///         Count Substrings That Satisfy k-Constraint II
///     </a>
/// </summary>
public class Solution
{
    public long[] CountKConstraintSubstrings(string s, int k, int[][] queries)
    {
        int n = s.Length;
        int[] digitCounts = new int[2];
        int[] substringCountPrefix = new int[n + 1];
        int[] right = new int[n];
        Array.Fill(right, n);

        for (int i = 0, j = 0; j < n; ++j)
        {
            digitCounts[s[j] - '0']++;
            while (digitCounts.All(count => count > k))
            {
                --digitCounts[s[i] - '0'];
                right[i] = j;
                ++i;
            }

            substringCountPrefix[j + 1] = substringCountPrefix[j] + j - i + 1;
        }

        IList<long> res = new List<long>();
        foreach (int[] query in queries)
        {
            int l = query[0];
            int r = query[1];
            int i = Math.Min(right[l], r + 1);
            long part1 = 1L * (i - l) * (i - l + 1) / 2;
            long part2 = 1L * substringCountPrefix[r + 1] - substringCountPrefix[i];
            res.Add(part1 + part2);
        }

        return res.ToArray();
    }
}