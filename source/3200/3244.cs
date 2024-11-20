using source.Structs;

namespace source._3200._3244;

/// <summary>
///     <a href="https://leetcode.cn/problems/shortest-distance-after-road-addition-queries-ii">
///         Shortest Distance After Road Addition Queries II
///     </a>
/// </summary>
public class Solution
{
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        List<int> res = [];
        int distance = n - 1;
        SegmentTree tree = new(n);

        foreach (int[] query in queries)
        {
            int u = query[0];
            int v = query[1];

            int skipDistance = tree.SumRange(u + 1, v - 1);
            int reducedDistance = v - u - 1;

            if (reducedDistance > skipDistance)
            {
                tree.UpdateRange(u + 1, v - 1, 1);
                distance -= reducedDistance - skipDistance;
            }

            res.Add(distance);
        }

        return res.ToArray();
    }
}