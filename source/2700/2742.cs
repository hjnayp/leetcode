namespace source._2700._2742;

public class Solution
{
    public int PaintWalls(int[] cost, int[] time)
    {
        int workCnt = cost.Length;
        int[] preFreeTimeCost = new int[2 * workCnt + 1];
        Array.Fill(preFreeTimeCost, int.MaxValue / 2);
        preFreeTimeCost[workCnt] = 0;

        for (int iWork = 0; iWork < workCnt; iWork++)
        {
            int[] nowFreeTimeCost = new int[2 * workCnt + 1];
            Array.Fill(nowFreeTimeCost, int.MaxValue / 2);

            for (int jFreeTime = 0; jFreeTime <= workCnt * 2; ++jFreeTime)
            {
                int freeTime = Math.Min(jFreeTime + time[iWork], 2 * workCnt);
                nowFreeTimeCost[freeTime] =
                    Math.Min(nowFreeTimeCost[freeTime], preFreeTimeCost[jFreeTime] + cost[iWork]);

                if (jFreeTime > 0)
                {
                    nowFreeTimeCost[jFreeTime - 1] =
                        Math.Min(nowFreeTimeCost[jFreeTime - 1], preFreeTimeCost[jFreeTime]);
                }
            }

            preFreeTimeCost = nowFreeTimeCost;
        }

        return preFreeTimeCost.Skip(workCnt).Min();
    }
}