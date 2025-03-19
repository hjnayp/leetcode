namespace source._1900._1963;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-number-of-swaps-to-make-the-string-balanced">
///         1963. Minimum Number of Swaps to Make the String Balanced
///     </a>
/// </summary>
public class Solution
{
    public int MinSwaps(string s)
    {
        int leftCount = 0;
        int rightCount = 0;
        int l = 0;
        int r = s.Length - 1;
        int res = 0;

        while (l < r)
        {
            leftCount += s[l++] == '[' ? 1 : -1;

            if (leftCount >= 0) continue;

            while (rightCount >= 0)
            {
                rightCount += s[r--] == ']' ? 1 : -1;
            }

            ++res;
            leftCount = 1;
        }

        return res;
    }
}