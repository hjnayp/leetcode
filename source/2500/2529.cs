namespace source._2500._2529;

public class Solution
{
    public int MaximumCount(int[] nums)
    {
        int n = nums.Length;
        var m = 0;
        var k = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            if (num > 0)
            {
                k = n - i;
                break;
            }

            if (num == 0) continue;
            ++m;
        }

        return Math.Max(m, k);
    }
}