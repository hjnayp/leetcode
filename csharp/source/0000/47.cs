namespace source._0000._47;

/// <summary>
///     <a href="https://leetcode.cn/problems/permutations-ii/description">
///         47. Permutations II
///     </a>
/// </summary>
public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        Array.Sort(nums);

        var res = new List<IList<int>>();
        int len = nums.Length;

        Dfs([], res, new bool[len]);
        return res;

        void Dfs(IList<int> permutation, IList<IList<int>> allPermutations, bool[] isUseds)
        {
            if (permutation.Count == len)
            {
                allPermutations.Add(permutation.ToList());
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (isUseds[i] || (i > 0 && nums[i] == nums[i - 1] && isUseds[i - 1] == false))
                {
                    continue;
                }

                permutation.Add(nums[i]);
                isUseds[i] = true;

                Dfs(permutation, allPermutations, isUseds);

                permutation.RemoveAt(permutation.Count - 1);
                isUseds[i] = false;
            }
        }
    }
}