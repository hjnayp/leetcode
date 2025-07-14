namespace source._3100._3110;

/// <summary>
///     <a href="https://leetcode.cn/problems/score-of-a-string">
///         3110. Score of a String
///     </a>
/// </summary>
public class Solution
{
    public int ScoreOfString(string s)
    {
        int ans = 0;
        for (var i = 1; i < s.Length; i++)
        {
            ans += Math.Abs(s[i] - s[i - 1]);
        }

        return ans;
    }
}