namespace source._0000._90;

/// <summary>
///     <a href="https://leetcode.cn/problems/subsets-ii">
///         90. Subsets II
///     </a>
/// </summary>
public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        if (nums.Length == 0) return [];

        var res = new List<IList<int>>();
        Array.Sort(nums);

        var arr = new List<IList<IList<int>>>();
        CreateArrays();
        CreateSubsets(0, []);

        return res;

        void CreateArrays()
        {
            int i = 0;
            var subsets = new List<IList<int>>();
            while (i < nums.Length)
            {
                int count = 0;
                while (i < nums.Length && (count == 0 || nums[i] == nums[i - 1]))
                {
                    ++count;
                    ++i;
                }

                int num = nums[i - 1];
                for (int c = 0; c <= count; ++c)
                {
                    AddSubset(subsets, num, c);
                }

                arr.Add(subsets);
                subsets = [];
            }
        }

        void AddSubset(IList<IList<int>> subset, int num, int count)
        {
            subset.Add(Enumerable.Repeat(num, count).ToArray());
        }

        void CreateSubsets(int index, List<int> subset)
        {
            if (index == arr.Count)
            {
                res.Add(subset.ToArray());
                return;
            }

            IList<IList<int>>? numSubsets = arr[index];
            foreach (IList<int> numSubset in numSubsets)
            {
                subset.AddRange(numSubset);
                CreateSubsets(index + 1, subset);
                subset.RemoveRange(subset.Count - numSubset.Count, numSubset.Count);
            }
        }
    }
}