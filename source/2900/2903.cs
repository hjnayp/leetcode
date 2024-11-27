namespace source._2900._2903;

public class Solution
{
    public int[] FindIndices(int[] nums, int indexDifference, int valueDifference)
    {
        int n = nums.Length;
        int minIdx = 0;
        int maxIdx = 0;
        for (int i = indexDifference; i < n; ++i)
        {
            int j = i - indexDifference;
            if (nums[j] < nums[minIdx])
            {
                minIdx = j;
            }

            if (Math.Abs(nums[i] - nums[minIdx]) >= valueDifference)
            {
                return new[] { minIdx, i };
            }

            if (nums[j] > nums[maxIdx])
            {
                maxIdx = j;
            }

            if (Math.Abs(nums[maxIdx] - nums[i]) >= valueDifference)
            {
                return new[] { maxIdx, i };
            }
        }

        return new[] { -1, -1 };
    }
}