namespace source._3100._3192;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-operations-to-make-binary-array-elements-equal-to-one-ii">
///         3192. Minimum Operations to Make Binary Array Elements Equal to One II
///     </a>
/// </summary>
public class Solution
{
    public int MinOperations(int[] nums)
    {
        int flipCount = 0;
        foreach (int num in nums)
        {
            if ((flipCount & 1) == num)
            {
                ++flipCount;
            }
        }

        return flipCount;
    }
}