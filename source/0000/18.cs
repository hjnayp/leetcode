namespace source._0000._18;

/// <summary>
///     <a href="https://leetcode.cn/problems/4sum/">link</a>
/// </summary>
public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        if (nums.Length < 4)
        {
            return [];
        }

        Array.Sort(nums);
        IList<IList<int>> quadruplets = new List<IList<int>>();
        int n = nums.Length;
        for (int i = 0; i < n - 3; ++i)
        {
            if (IsMinSumGreaterThanTarget(i)) break;
            if (IsMaxSumSmallThanTarget(i)) continue;
            if (IsElementAtIndexSameAsPrevious(i)) continue;

            for (int j = i + 1; j < n - 2; ++j)
            {
                if (IsMinSumGreaterThanTarget(i, j)) break;
                if (IsMaxSumSmallThanTarget(i, j)) continue;
                if (j > i + 1 && IsElementAtIndexSameAsPrevious(j)) continue;

                int left = j + 1;
                int right = n - 1;

                while (left < right)
                {
                    int compareResult = CompareSumOfElementsAtIndexToTarget(i, j, left, right);
                    switch (compareResult)
                    {
                        case 0:
                            quadruplets.Add([nums[i], nums[j], nums[left], nums[right]]);
                            while (left < right && IsElementAtIndexSameAsPrevious(left + 1))
                            {
                                ++left;
                            }

                            while (left < right && IsElementAtIndexSameAsPrevious(right))
                            {
                                --right;
                            }

                            ++left;
                            --right;

                            break;
                        case 1:
                            --right;
                            break;
                        case -1:
                            ++left;
                            break;
                    }
                }
            }
        }

        return quadruplets;

        bool IsMaxSumSmallThanTarget(int indexA, int indexB = -1)
        {
            long maxCombinationValue;

            if (indexB is -1)
            {
                maxCombinationValue = (long)nums[indexA] + nums[n - 3] + nums[n - 2] + nums[n - 1];
            }
            else
            {
                maxCombinationValue = (long)nums[indexA] + nums[indexB] + nums[n - 2] + nums[n - 1];
            }

            return maxCombinationValue < target;
        }

        bool IsMinSumGreaterThanTarget(int indexA, int indexB = -1)
        {
            long minCombinationValue;
            if (indexB is -1)
            {
                minCombinationValue = (long)nums[indexA] + nums[indexA + 1] + nums[indexA + 2] + nums[indexA + 3];
            }
            else
            {
                minCombinationValue =
                    (long)nums[indexA] + nums[indexB] + nums[indexB + 1] + nums[indexB + 2];
            }

            return minCombinationValue > target;
        }

        bool IsElementAtIndexSameAsPrevious(int index)
        {
            if (index == 0) return false;
            return nums[index] == nums[index - 1];
        }

        int CompareSumOfElementsAtIndexToTarget(int i, int j, int k, int l)
        {
            long sum = (long)nums[i] + nums[j] + nums[k] + nums[l];
            if (sum > target)
            {
                return 1;
            }

            if (sum == target)
            {
                return 0;
            }

            return -1;
        }
    }
}