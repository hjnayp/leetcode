namespace source._0500._521;

/// <summary>
///     https://leetcode.cn/problems/longest-uncommon-subsequence-i
/// </summary>
public class Solution
{
    public int FindLUSlength(string a, string b)
    {
        return a == b
            ? -1
            : Math.Max(a.Length, b.Length);
    }
}