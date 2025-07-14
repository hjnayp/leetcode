namespace source._2900._2951;

public class Solution
{
    public IList<int> FindPeaks(int[] mountain)
    {
        int n = mountain.Length;
        var res = new List<int>();
        for (int i = 0, j = 1, k = 2;
             j < n - 1;
             ++i, ++j, ++k)
        {
            bool isMax = mountain[i] < mountain[j];
            if (isMax && mountain[j] <= mountain[k]) isMax = false;
            if (isMax) res.Add(j);
        }

        return res;
    }
}