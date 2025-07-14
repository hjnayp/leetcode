namespace source._3300._3330;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-the-original-typed-string-i">
///         3330. Find the Original Typed String I
///     </a>
/// </summary>
public class Solution
{
    public int PossibleStringCount(string word)
    {
        int res = 1;
        var ch = word[0];
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == ch) res++;

            ch = word[i];
        }

        return res;
    }
}