namespace source._2700._2708;

public class Solution
{
    public long MaxStrength(int[] nums)
    {
        long max = nums[0];
        long min = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            long maxMultiply = Math.Max(max * nums[i], min * nums[i]);
            long minMultiply = Math.Min(max * nums[i], min * nums[i]);
            max = Math.Max(Math.Max(max, nums[i]), maxMultiply);
            min = Math.Min(Math.Min(min, nums[i]), minMultiply);
        }

        return max;
    }
}