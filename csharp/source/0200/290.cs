namespace source._0200._290;

/// <summary>
///     <a href="https://leetcode.cn/problems/word-pattern/">
///         290. Word Pattern
///     </a>
/// </summary>
public class Solution
{
    public bool WordPattern(string pattern, string s)
    {
        string[] words = s.Split(' ');
        if (words.Length != pattern.Length) return false;

        var map = new Dictionary<object, object>();
        for (int i = 0; i < pattern.Length; i++)
        {
            char ch = pattern[i];
            string word = words[i];

            if (map.ContainsKey(ch) != map.ContainsValue(word)) return false;

            if (map.TryAdd(ch, word))
            {
                map.Add(word, ch);
                continue;
            }

            if (map[ch].Equals(word) == false || map[word].Equals(ch) == false) return false;
        }

        return true;
    }
}