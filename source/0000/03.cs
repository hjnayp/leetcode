namespace source._0000._03;

/// <summary>
///     https://leetcode.cn/problems/longest-substring-without-repeating-characters
/// </summary>
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        int left = 0;
        int right = 0;
        var set = new HashSet<char>();
        while (right < s.Length)
        {
            char c = s[right];
            if (set.Add(c))
            {
                ++right;
                continue;
            }

            max = Math.Max(max, right - left);
            while (set.Contains(c))
            {
                set.Remove(s[left]);
                ++left;
            }

            set.Add(c);
            ++right;
        }

        return Math.Max(max, right - left);
    }
}