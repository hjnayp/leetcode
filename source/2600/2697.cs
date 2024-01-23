using System.Text;

namespace source._2600._2697;

public class Solution
{
    public string MakeSmallestPalindrome(string s)
    {
        var left = -1;
        var right = s.Length;
        var res = new StringBuilder(s);
        while (++left < --right)
        {
            if (s[left] == s[right]) continue;
            res[left] = res[right] = (char)Math.Min(s[left], s[right]);
        }

        return res.ToString();
    }
}