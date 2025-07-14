namespace source._2400._2414;

/// <summary>
///     <a href="https://leetcode.cn/problems/length-of-the-longest-alphabetical-continuous-substring">
///         Length of the Longest Alphabetical Continuous Substring
///     </a>
/// </summary>
public class Solution
{
    public int LongestContinuousSubstring(string s)
    {
        int maxLen = 0;
        int len = 1;
        for (int i = 1; i < s.Length; ++i)
        {
            bool isContinuous = s[i] - s[i - 1] == 1;
            if (isContinuous)
            {
                ++len;
            }
            else
            {
                maxLen = Math.Max(maxLen, len);
                len = 1;
            }
        }

        maxLen = Math.Max(maxLen, len);
        return maxLen;
    }
}