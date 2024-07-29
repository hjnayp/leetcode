namespace source._0000._10;

/// <summary>
///     https://leetcode.cn/problems/regular-expression-matching/
/// </summary>
public class Solution
{
    public bool IsMatch(string s, string p)
    {
        bool[,] substringMatchMatrix = new bool[s.Length + 1, p.Length + 1];
        substringMatchMatrix[0, 0] = true;

        for (int i = 0; i <= s.Length; i++)
        for (int j = 1; j <= p.Length; j++)
        {
            if (p[j - 1] == '*')
            {
                substringMatchMatrix[i, j] = substringMatchMatrix[i, j]
                                             || substringMatchMatrix[i, j - 2] // zero match
                                             || (IsCharMatch(i, j - 1) && substringMatchMatrix[i - 1, j]);
            }
            else
            {
                substringMatchMatrix[i, j] = substringMatchMatrix[i, j]
                                             || (IsCharMatch(i, j) && substringMatchMatrix[i - 1, j - 1]);
            }
        }

        return substringMatchMatrix[s.Length, p.Length];

        bool IsCharMatch(int sourceCharIndex, int patternCharIndex)
        {
            if (sourceCharIndex == 0)
            {
                return false;
            }

            if (p[patternCharIndex - 1] == '.')
            {
                return true;
            }

            return s[sourceCharIndex - 1] == p[patternCharIndex - 1];
        }
    }
}