namespace source._0000._15;

/// <summary>
///     <a href="https://leetcode.cn/problems/3sum">3Sum</a>
/// </summary>
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>> results = new List<IList<int>>();
        int n = nums.Length;
        for (int i = 0; i < n - 2; ++i)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int j = i + 1;
            int k = n - 1;

            while (j < n - 1 && j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum == 0)
                {
                    results.Add(new List<int> { nums[i], nums[j], nums[k] });

                    while (j < k && nums[j] == nums[j + 1])
                    {
                        ++j;
                    }

                    while (j < k && nums[k] == nums[k - 1])
                    {
                        --k;
                    }

                    ++j;
                    --k;
                }
                else if (sum < 0)
                {
                    ++j;
                }
                else
                {
                    --k;
                }
            }
        }

        return results;
    }
}