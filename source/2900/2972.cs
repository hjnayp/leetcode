namespace source._2900._2972;

public class Solution
{
    public long IncremovableSubarrayCount(int[] nums)
    {
        int left = 1;
        int len = nums.Length;
        while (left < len && nums[left - 1] < nums[left])
        {
            ++left;
        }

        long incremovableCount = left + (left < len ? 1 : 0);

        for (int right = len - 2; right >= 0; --right)
        {
            while (left > 0 && nums[left - 1] >= nums[right + 1])
            {
                --left;
            }

            incremovableCount += left + (left <= right ? 1 : 0);
            if (nums[right] >= nums[right + 1]) break;
        }

        return incremovableCount;
    }
}