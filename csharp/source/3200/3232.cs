namespace source._3200._3232;

/// <summary>
///     <a href="https://leetcode.cn/problems/find-if-digit-game-can-be-won">
///         3232. Find if Digit Game Can Be Won
///     </a>
/// </summary>
public class Solution
{
    public bool CanAliceWin(int[] nums)
    {
        int oneDigitSum = 0;
        int twoDigitSum = 0;
        Array.Sort(nums);
        foreach (int num in nums)
        {
            if (num < 10)
            {
                oneDigitSum += num;
            }
            else
            {
                twoDigitSum += num;
            }
        }

        return oneDigitSum != twoDigitSum;
    }
}