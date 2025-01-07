namespace source._3000._3019;

/// <summary>
///     <a href="https://leetcode.cn/problems/number-of-changing-keys">
///         3019. Number of Changing Keys
///     </a>
/// </summary>
public class Solution
{
    public int CountKeyChanges(string s)
    {
        char preKey = char.ToLowerInvariant(s[0]);
        int count = 0;
        foreach (char ch in s.Select(char.ToLowerInvariant).Where(ch => ch != preKey))
        {
            ++count;
            preKey = ch;
        }

        return count;
    }
}