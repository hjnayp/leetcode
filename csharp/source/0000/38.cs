using System.Text;

namespace source._0000._38;

/// <summary>
///     <a href="https://leetcode.cn/problems/count-and-say">
///         Count and Say
///     </a>
/// </summary>
public class Solution
{
    private static IDictionary<int, string> s_levelToStr = new Dictionary<int, string>() { { 1, "1" } };

    public string CountAndSay(int n)
    {
        if (s_levelToStr.TryGetValue(n, out string? str))
        {
            return str;
        }

        string prevStr = CountAndSay(n - 1);
        StringBuilder sb = new();
        int left = 0;
        int right = 0;
        while (right <= prevStr.Length)
        {
            if (right == prevStr.Length || prevStr[right] != prevStr[left])
            {
                char ch = prevStr[left];
                int len = right - left;
                sb.Append($"{len}{ch}");
                left = right;
            }

            ++right;
        }

        return s_levelToStr[n] = sb.ToString();
    }
}