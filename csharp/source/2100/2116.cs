namespace source._2100._2116;

/// <summary>
///     <a
///         href="https://leetcode.cn/problems/check-if-a-parentheses-string-can-be-valid">
///         2116. Check if a Parentheses String Can Be Valid
///     </a>
/// </summary>
public class Solution
{
    public bool CanBeValid(string s, string locked)
    {
        int maxValidCount = 0;
        int minValidCount = 0;
        int n = s.Length;

        for (int i = 0; i < n; i++)
        {
            bool isLocked = locked[i] == '1';
            if (isLocked)
            {
                char ch = s[i];
                int diff = ch is '(' ? 1 : -1;
                maxValidCount += diff;
                minValidCount = Math.Max(minValidCount + diff, (i + 1) % 2);
            }
            else
            {
                ++maxValidCount;
                minValidCount = Math.Max(minValidCount - 1, (i + 1) % 2);
            }

            if (maxValidCount < minValidCount)
            {
                return false;
            }
        }

        return minValidCount == 0;
    }
}