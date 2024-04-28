using System.Text;

namespace source._1000._1017;

public class Solution
{
    public string BaseNeg2(int n)
    {
        var res = new StringBuilder();
        while (n != 0)
        {
            int remainder = n % -2;
            res.Append(Math.Abs(remainder));
            n = remainder < 0
                ? n / -2 + 1
                : n / -2;
        }

        if (res.Length == 0) return "0";

        IEnumerable<char> reverseStr = res.ToString().Reverse();
        return string.Concat(reverseStr);
    }
}