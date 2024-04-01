using System.Text;

namespace source._2800._2810;

/// <summary>
///     https://leetcode.cn/problems/faulty-keyboard/description
/// </summary>
public class Solution
{
    public string FinalString(string s)
    {
        var res = new StringBuilder();
        foreach (char c in s)
            if (c == 'i')
            {
                string reverse = string.Join("", res.ToString().Reverse().ToList());
                res.Clear();
                res.Append(reverse);
            }
            else
            {
                res.Append(c);
            }

        return res.ToString();
    }
}