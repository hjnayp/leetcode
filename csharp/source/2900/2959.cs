namespace source._2900._2959;

public class Solution
{
    public int NumberOfSets(int n, int maxDistance, int[][] roads)
    {
        int validSetCnt = 0;
        IList<int> openBranch = new List<int>();
        for (int openedBranchMask = 0; openedBranchMask < 1 << n; ++openedBranchMask)
        {
            openBranch.Clear();
            for (int i = 0; i < n; ++i)
            {
                if (IsOpened(openedBranchMask, i)) openBranch.Add(i);
            }

            int[,] distanceGrid = new int[n, n];
            for (int i = 0; i < n; ++i)
            for (int j = 0; j < n; ++j)
            {
                distanceGrid[i, j] = i != j ? int.MaxValue : 0;
            }

            foreach (int[] road in roads)
            {
                int u = road[0];
                int v = road[1];
                int w = road[2];
                if (!IsOpened(openedBranchMask, u) || !IsOpened(openedBranchMask, v)) continue;
                distanceGrid[v, u] = distanceGrid[u, v] = Math.Min(distanceGrid[u, v], w);
            }

            foreach (int k in openBranch)
            {
                for (int i = 0; i < openBranch.Count; ++i)
                for (int j = i + 1; j < openBranch.Count; ++j)
                {
                    int u = openBranch[i];
                    int v = openBranch[j];

                    int distancePassK = distanceGrid[u, k] + distanceGrid[k, v];
                    if (distancePassK < distanceGrid[u, k] || distancePassK < distanceGrid[k, v]) continue;
                    distanceGrid[v, u] = distanceGrid[u, v] =
                        Math.Min(distanceGrid[u, v], distanceGrid[u, k] + distanceGrid[k, v]);
                }
            }

            int valid = 1;
            foreach (int u in openBranch)
            {
                if (valid == 0) break;
                if (openBranch.Any(v => distanceGrid[u, v] > maxDistance))
                {
                    valid = 0;
                }
            }

            validSetCnt += valid;
        }

        return validSetCnt;

        bool IsOpened(int mask, int i)
        {
            return (mask & (1 << i)) > 0;
        }
    }
}