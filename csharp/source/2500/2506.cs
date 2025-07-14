using System.Text;

namespace source._2500._2506;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-pairs-of-similar-strings">
///         Count Pairs Of Similar Strings
///     </a>
/// </summary>
public class Solution
{
    public int SimilarPairs(string[] words)
    {
        words = words.Select(ToUniqueCharString).ToArray();
        Array.Sort(words);

        int pairCount = 0;
        int i = 0;
        while (i < words.Length)
        {
            int j = i;
            while (j < words.Length && words[i] == words[j])
            {
                ++j;
            }

            pairCount += (j - i) * (j - i - 1) / 2;
            i = j;
        }

        return pairCount;
    }

    /// <summary>
    ///     Converts a given string to a string that contains each unique character
    ///     from the original string exactly once, in sorted order.
    /// </summary>
    /// <example>
    ///     "abc" == ToUniqueCharString("bbacc");
    /// </example>
    /// <param name="str">The input string to process.</param>
    /// <returns>A string containing unique characters from the input string, sorted in alphabetical order.</returns>
    private static string ToUniqueCharString(string str)
    {
        var sb = new StringBuilder();
        int mask = str.Aggregate(0, (current, c) => current | (1 << (c - 'a')));
        for (int i = 0; i < 26; ++i)
        {
            if ((mask & (1 << i)) > 0)
            {
                sb.Append((char)('a' + i));
            }
        }

        return sb.ToString();
    }
}