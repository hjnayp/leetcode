namespace source._3100._3151;

public class Solution
{
    public bool IsArraySpecial(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            int currentNumber = nums[i];
            int previousNumber = nums[i - 1];
            if ((currentNumber & 1) == (previousNumber & 1))
            {
                return false;
            }
        }

        return true;
    }
}