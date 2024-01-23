namespace source._2700._2765;

public class Solution
{
    public int AlternatingSubarray(int[] nums)
    {
        var n = nums.Length;
        if (n < 2)
            return n;

        var p1 = 0;
        var p2 = 1;
        var res = -1;

        while (p2 < n)
        {
            var isValid = (p2 - p1) % 2 == 0 ? nums[p2] == nums[p1] : nums[p2] == nums[p1] + 1;
            if (isValid)
            {
                ++p2;
            }
            else
            {
                if (p2 > p1 + 1)
                    res = Math.Max(res, p2 - p1);
                if (p2 - 1 == p1)
                    ++p2;
                p1 = p2 - 1;
            }
        }

        if (p2 > p1 + 1)
            res = Math.Max(res, p2 - p1);

        return res;
    }
}