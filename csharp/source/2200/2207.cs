namespace source._2200._2207;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximize-number-of-subsequences-in-a-string">
///         Maximize Number of Subsequences in a String
///     </a>
/// </summary>
public class Solution
{
    public long MaximumSubsequenceCount(string text, string pattern)
    {
        long count = 0L;
        int firstCount = 0;
        int secondCount = 0;

        foreach (char c in text)
        {
            if (c == pattern[1])
            {
                ++secondCount;
                count += firstCount;
            }

            if (c == pattern[0])
            {
                ++firstCount;
            }
        }

        count += Math.Max(firstCount, secondCount);
        return count;
    }
}