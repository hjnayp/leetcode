namespace source._0000._39;

/// <summary>
///     <a href="https://leetcode.cn/problems/combination-sum">
///         Combination Sum
///     </a>
/// </summary>
public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var combinations = new List<IList<int>>();
        CreateCombination(0, new List<int>(), target);
        return combinations;

        void CreateCombination(int index, IList<int> combination, int remain)
        {
            if (index >= candidates.Length) return;

            if (remain == 0)
            {
                combinations.Add(combination.ToList());
                return;
            }

            CreateCombination(index + 1, combination, remain);

            int candidate = candidates[index];
            if (remain - candidate < 0) return;

            combination.Add(candidate);
            CreateCombination(index, combination, remain - candidate);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}