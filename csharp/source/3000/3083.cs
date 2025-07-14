using System.Text;

namespace source._3000._3083;

/// <summary>
///     <a href="https://leetcode.cn/problems/existence-of-a-substring-in-a-string-and-its-reverse">
///         3083. Existence of a Substring in a String and Its Reverse
///     </a>
/// </summary>
public class Solution
{
    public bool IsSubstringPresent(string s)
    {
        switch (s.Length)
        {
            case <= 1: return false;
            case 2: return s[0] == s[1];
        }

        var wordsFromStart = new HashSet<string>();
        var wordsFromEnd = new HashSet<string>();
        int n = s.Length;
        int i = 0;
        var sb = new StringBuilder();
        while (i < n - 1)
        {
            string word1 = s.Substring(i, 2);
            wordsFromStart.Add(word1);

            sb.Clear();
            string word2 = sb.Append(s[^(i + 1)]).Append(s[^(i + 2)]).ToString();
            wordsFromEnd.Add(word2);

            if (wordsFromEnd.Contains(word1)
                || wordsFromStart.Contains(word2))
            {
                return true;
            }

            ++i;
        }

        return false;
    }
}