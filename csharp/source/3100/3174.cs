using System.Text;

namespace source._3100._3174;

/// <summary>
///     <a href="https://leetcode.cn/problems/clear-digits">
///         Char Clear
///     </a>
/// </summary>
public class Solution
{
    public string ClearDigits(string s)
    {
        StringBuilder sb = new();
        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                if (sb.Length > 0)
                {
                    sb.Remove(sb.Length - 1, 1);
                }
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}