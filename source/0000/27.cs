namespace source._0000._27;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var p = nums.Length;
        for (var i = 0; i < p; ++i)
            if (nums[i] == val)
            {
                while (p > i && nums[p - 1] == val)
                    --p;

                if (p == i)
                    break;

                nums[i] = nums[p-- - 1];
            }

        return p;
    }
}