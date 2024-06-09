namespace source._3000._3038;

public class Solution
{
    public int MaxOperations(int[] nums)
    {
        int template = nums[0] + nums[1];
        int sum = 1;
        for (int i = 2; i < nums.Length; i += 2)
        {
            if (i + 1 == nums.Length) break;
            int value = nums[i] + nums[i + 1];
            if (value == template) ++sum;
            else break;
        }

        return sum;
    }
}