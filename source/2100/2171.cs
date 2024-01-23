namespace source._2100._2171;

public class Solution
{
    public long MinimumRemoval(int[] beans)
    {
        var n = beans.Length;
        Array.Sort(beans);
        var sum = beans.Sum(bean => (long)bean);
        var res = sum;
        for (var i = 0; i < n; ++i)
            res = Math.Min(res, sum - (long)beans[i] * (n - i));
        return res;
    }
}