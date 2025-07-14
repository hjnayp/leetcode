namespace source._0200._216;

public class Solution
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        var res = new List<List<int>>();
        const int MAX = 1 << 9;
        for (var i = 0; i < MAX; ++i)
            if (Check(i, out List<int> comb))
                res.Add(comb);
        return res.ToArray();

        bool Check(int mask, out List<int> comb)
        {
            comb = new List<int>();
            for (var i = 0; i < 9; ++i)
                if (((1 << i) & mask) != 0)
                    comb.Add(i + 1);
            return comb.Count == k && comb.Sum() == n;
        }
    }
}