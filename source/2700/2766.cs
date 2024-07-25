namespace source._2700._2766;

public class Solution
{
    public IList<int> RelocateMarbles(int[] nums, int[] moveFrom, int[] moveTo)
    {
        IDictionary<int, int> positionToMarbleCount = new Dictionary<int, int>();
        foreach (int pos in nums) positionToMarbleCount.TryAdd(pos, 1);

        int n = moveFrom.Length;
        for (int i = 0; i < n; ++i)
        {
            int from = moveFrom[i];
            int to = moveTo[i];

            if (from == to) continue;
            if (!positionToMarbleCount.TryGetValue(from, out int marbleCount)) continue;

            positionToMarbleCount[from] = 0;
            positionToMarbleCount.TryAdd(to, 0);
            positionToMarbleCount[to] += marbleCount;
        }

        return positionToMarbleCount.Where(x => x.Value > 0)
            .Select(x => x.Key)
            .OrderBy((i) => i)
            .ToArray();
    }
}