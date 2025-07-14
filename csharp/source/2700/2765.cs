namespace source._2700._2765;

public class Solution
{
    public int AlternatingSubarray(int[] nums)
    {
        int n = nums.Length;
        if (n < 2)
        {
            return n;
        }

        int p1 = 0;
        int p2 = 1;
        int res = -1;

        while (p2 < n)
        {
            bool isValid = (p2 - p1) % 2 == 0 ? nums[p2] == nums[p1] : nums[p2] == nums[p1] + 1;
            if (isValid)
            {
                ++p2;
            }
            else
            {
                if (p2 > p1 + 1)
                {
                    res = Math.Max(res, p2 - p1);
                }

                if (p2 - 1 == p1)
                {
                    ++p2;
                }

                p1 = p2 - 1;
            }
        }

        if (p2 > p1 + 1)
        {
            res = Math.Max(res, p2 - p1);
        }

        return res;
    }
}