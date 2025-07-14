using System.Text;

namespace source._2100._2182;

public class Solution
{
    public string RepeatLimitedString(string s, int repeat_limit)
    {
        const int kN = 26;
        var count = new int[kN];
        foreach (var c in s)
            ++count[c - 'a'];

        var res = new StringBuilder();
        var freq = 0;
        for (int i = kN - 1, j = kN - 2; i >= 0 && j >= 0;)
        {
            if (count[i] == 0)
            {
                freq = 0;
                --i;
            }
            else if (freq < repeat_limit)
            {
                ++freq;
                res.Append((char)('a' + i));
                --count[i];
            }
            else if (j >= i || count[j] <= 0)
            {
                --j;
            }
            else
            {
                --count[j];
                res.Append((char)('a' + j));
                freq = 0;
            }
        }

        return res.ToString();
    }
}