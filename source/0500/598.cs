namespace source._0500._598;

/// <summary>
///     <a href="https://leetcode.cn/problems/range-addition-ii">
///         598. Range Addition II
///     </a>
/// </summary>
public class Solution
{
    public int MaxCount(int m, int n, int[][] ops)
    {
        int minOperationX = m;
        int minOperationY = n;
        foreach (int[] op in ops)
        {
            if (op[0] < minOperationX)
            {
                minOperationX = op[0];
            }

            if (op[1] < minOperationY)
            {
                minOperationY = op[1];
            }
        }

        return minOperationX * minOperationY;
    }
}