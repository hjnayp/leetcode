namespace source._0000._13;

/// <summary>
///     https://leetcode.cn/problems/roman-to-integer
/// </summary>
public class Solution
{
    public int RomanToInt(string romanString)
    {
        int value = 0;
        char previousChar = ' ';

        foreach (char ch in romanString)
        {
            value += ch switch
            {
                'I' => 1,
                'V' when previousChar == 'I' => 3,
                'V' => 5,
                'X' when previousChar == 'I' => 8,
                'X' => 10,
                'L' when previousChar == 'X' => 30,
                'L' => 50,
                'C' when previousChar == 'X' => 80,
                'C' => 100,
                'D' when previousChar == 'C' => 300,
                'D' => 500,
                'M' when previousChar == 'C' => 800,
                'M' => 1000,
                _ => 0
            };

            previousChar = ch;
        }

        return value;
    }
}