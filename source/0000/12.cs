using System.Text;

namespace source._0000._12;

/// <summary>
///     <a href="https://leetcode.cn/problems/integer-to-roman">Integer to Roman</a>
/// </summary>
public class Solution
{
    private static readonly string[] Roman = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];
    private static readonly int[] Values = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];

    public string IntToRoman(int num)
    {
        StringBuilder romanStringBuilder = new();
        for (int i = 0; i < Values.Length; i++)
        {
            while (num >= Values[i])
            {
                num -= Values[i];
                romanStringBuilder.Append(Roman[i]);
            }
        }

        return romanStringBuilder.ToString();
    }
}