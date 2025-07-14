using System.Text;

namespace source._3200._3280;

/// <summary>
///     <a href="https://leetcode.cn/problems/convert-date-to-binary">
///         3280. Convert Date to Binary
///     </a>
/// </summary>
public class Solution
{
    public string ConvertDateToBinary(string date)
    {
        var dates = date.Split('-');
        int year = int.Parse(dates[0]);
        int month = int.Parse(dates[1]);
        int day = int.Parse(dates[2]);

        return $"{ToBinaryString(year)}-{ToBinaryString(month)}-{ToBinaryString(day)}";
    }

    private static string ToBinaryString(int x)
    {
        var sb = new StringBuilder();
        while (x > 0)
        {
            int bit = x & 1;
            sb.Append(bit);
            x >>= 1;
        }

        IEnumerable<char> chs = sb.ToString().Reverse();
        return new string(chs.ToArray());
    }
}