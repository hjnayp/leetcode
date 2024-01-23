namespace source._0000._03;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var max = 0;
        var left = 0;
        var right = 0;
        var set = new HashSet<char>();
        while (right < s.Length)
        {
            var c = s[right];
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