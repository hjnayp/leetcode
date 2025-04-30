namespace source._1200._1295;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-numbers-with-even-number-of-digits">
///         1295. Find Numbers with Even Number of Digits
///     </a>
/// </summary>
public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums.Count(i => DigitCount(i) % 2 == 0);
    }

    private static int DigitCount(int num)
    {
        int count = 0;
        while (num > 0)
        {
            num /= 10;
            ++count;
        }

        return count;
    }
}