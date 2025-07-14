namespace source._0700._724;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        int rightSum = nums.Sum();
        int leftSum = 0;
        int pivot = 0;
        while (pivot < nums.Length)
        {
            if (leftSum == rightSum - nums[pivot]) return pivot;
            leftSum += nums[pivot];
            rightSum -= nums[pivot];
            ++pivot;
        }

        return -1;
    }
}