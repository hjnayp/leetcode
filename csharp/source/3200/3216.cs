namespace source._3200._3216;

/// <summary>
///     <a href="https://leetcode.cn/problems/lexicographically-smallest-string-after-a-swap">
///     </a>
/// </summary>
public class Solution
{
    public string GetSmallestString(string s)
    {
        for (int i = 0; i < s.Length - 1; i++)
        {
            char prevChar = s[i];
            char nextChar = s[i + 1];

            if (prevChar % 2 != nextChar % 2) continue;
            if (prevChar > nextChar)
            {
                return s[..i] + nextChar + prevChar + s[(i + 2)..];
            }
        }

        return s;
    }
}