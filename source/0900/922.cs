namespace source._0900._922;

/// <summary>
///     <a href="https://leetcode.cn/problems/sort-array-by-parity-ii/description">
///         922. Sort Array By Parity II
///     </a>
/// </summary>
public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        int evenIndex = 0;
        int oddIndex = 1;

        while (evenIndex < nums.Length)
        {
            if ((nums[evenIndex] & 1) == 0)
            {
                evenIndex += 2;
                continue;
            }

            while (oddIndex < nums.Length)
            {
                if ((nums[oddIndex] & 1) == 0)
                {
                    (nums[oddIndex], nums[evenIndex]) = (nums[evenIndex], nums[oddIndex]);
                    evenIndex += 2;
                    break;
                }

                oddIndex += 2;
            }
        }

        return nums;
    }
}