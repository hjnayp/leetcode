using System.Text;

namespace source._0000._43;

/// <summary>
///     <a href="https://leetcode.cn/problems/multiply-strings/">
///         Multiply Strings
///     </a>
/// </summary>
public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0") return "0";

        return MakeDigitListToString(CalculatePerDigitSum(num1, num2));
    }

    private static IList<int> CalculatePerDigitSum(string num1, string num2)
    {
        IList<int> digits = new int[num1.Length + num2.Length - 1];
        for (int i = 1; i <= num1.Length; i++)
        {
            int n1 = num1[^i] - '0';
            for (int j = 1; j <= num2.Length; j++)
            {
                int n2 = num2[^j] - '0';
                digits[i + j - 2] += n1 * n2;
            }
        }

        return digits;
    }

    private static string MakeDigitListToString(IList<int> digits)
    {
        var sb = new StringBuilder();
        int increasement = 0;
        foreach (int digit in digits)
        {
            int val = digit + increasement;
            sb.Append($"{val % 10}");
            increasement = val / 10;
        }

        while (increasement > 0)
        {
            sb.Append($"{increasement}");
            increasement /= 10;
        }

        string numStr = new(sb.ToString().Reverse().ToArray());
        return numStr;
    }
}