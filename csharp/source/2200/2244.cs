namespace source._2200._2244;

public class Solution
{
    public int MinimumRounds(int[] tasks)
    {
        var taskCount = new Dictionary<int, int>();
        foreach (int task in tasks)
            if (!taskCount.TryAdd(task, 1))
                ++taskCount[task];

        int res = 0;
        foreach ((_, int count) in taskCount)
        {
            if (count == 1) return -1;
            res += (count % 3) switch
            {
                0 => count / 3,
                1 => count / 3 + 1,
                2 => count / 3 + 1,
                _ => 0
            };
        }

        return res;
    }
}