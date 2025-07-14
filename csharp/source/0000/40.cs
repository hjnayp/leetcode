namespace source._0000._40;

/// <summary>
///     <a href="https://leetcode.cn/problems/combination-sum-ii">
///         Combination Sum II
///     </a>
/// </summary>
public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        int n = candidates.Length;
        Array.Sort(candidates);
        var combinations = new List<IList<int>>();
        var combination = new List<int>();

        Combine(0, target);
        return combinations;

        void Combine(int index, int remain)
        {
            if (remain == 0)
            {
                combinations.Add(combination.ToList());
                return;
            }

            for (int i = index; i < n && remain >= candidates[i]; ++i)
            {
                if (i > index && candidates[i] == candidates[i - 1]) continue;

                combination.Add(candidates[i]);
                Combine(i + 1, remain - candidates[i]);
                combination.RemoveAt(combination.Count - 1);
            }
        }
    }
}