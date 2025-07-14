using System.Text;

namespace source._2800._2864;

public class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        int cnt = s.Sum(c => c - '0');
        var sb = new StringBuilder();
        for (int i = 0; i < cnt - 1; ++i)
        {
            sb.Append('1');
        }

        for (int i = cnt - 1; i < s.Length - 1; ++i)
        {
            sb.Append('0');
        }

        sb.Append('1');
        return sb.ToString();
    }
}