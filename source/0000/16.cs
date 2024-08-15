namespace source._0000._16;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        int n = nums.Length;
        int closetSum = 0;
        int minDifference = int.MaxValue;

        for (int i = 0; i < n - 2; ++i)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int j = i + 1;
            int k = n - 1;
            while (j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];
                int difference = sum - target;
                if (difference == 0)
                {
                    return sum;
                }

                if (Math.Abs(difference) < minDifference)
                {
                    minDifference = Math.Abs(difference);
                    closetSum = sum;
                }

                if (difference > 0)
                {
                    --k;
                }
                else
                {
                    ++j;
                }
            }
        }

        return closetSum;
    }
}