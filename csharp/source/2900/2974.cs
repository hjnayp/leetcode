namespace source._2900._2974;

public class Solution
{
    public int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i += 2)
        {
            (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
        }

        return nums;
    }
}