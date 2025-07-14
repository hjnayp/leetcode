namespace source._2000._2007;

public class Solution
{
    public int[] FindOriginalArray(int[] changed)
    {
        if (changed.Length % 2 == 1)
            return Array.Empty<int>();

        var count = new Dictionary<int, int>();
        foreach (int num in changed)
        {
            count.TryAdd(num, 0);
            count[num]++;
        }

        Array.Sort(changed);
        var res = new List<int>();
        foreach (int num in changed)
        {
            if (count[num] == 0) continue;
            if (num == 0 && count[num] % 2 == 1)
                return Array.Empty<int>();
            if (!count.ContainsKey(num * 2) || count[num] > count[num * 2])
                return Array.Empty<int>();

            count[num * 2] -= num == 0 ? count[num] / 2 : count[num];
            AddNum(num);
        }

        return res.ToArray();

        void AddNum(int num)
        {
            while (count[num] > 0)
            {
                res.Add(num);
                count[num]--;
            }
        }
    }
}