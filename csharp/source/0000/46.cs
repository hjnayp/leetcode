namespace source._0000._46;

public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> permutations = new List<IList<int>>();
        Queue<int> unusedNums = new(nums);

        FillPosition(unusedNums, new List<int>());
        return permutations;

        void FillPosition(Queue<int> remainNums, IList<int> permutation)
        {
            if (remainNums.Count == 0)
            {
                permutations.Add(permutation.ToArray());
                return;
            }

            for (int i = 0; i < remainNums.Count; ++i)
            {
                int num = remainNums.Dequeue();
                permutation.Add(num);
                FillPosition(remainNums, permutation);
                permutation.RemoveAt(permutation.Count - 1);
                remainNums.Enqueue(num);
            }
        }
    }
}