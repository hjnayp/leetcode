namespace source._3100._3102;

public class Solution
{
    public int MinimumDistance(int[][] points)
    {
        int[] dises =
        [
            CalculateMaxDistance(MarkIdx((point) => point[0] + point[1])),
            CalculateMaxDistance(MarkIdx((point) => -point[0] - point[1])),
            CalculateMaxDistance(MarkIdx((point) => point[0] - point[1])),
            CalculateMaxDistance(MarkIdx((point) => -point[0] + point[1]))
        ];
        return dises.Min();

        int CalculateMaxDistance(int excludeIdx)
        {
            int[] addDistances = [int.MinValue, int.MaxValue];
            int[] reduceDistances = [int.MinValue, int.MaxValue];

            for (int i = 0; i < points.Length; i++)
            {
                if (i == excludeIdx) continue;

                int addDis = points[i][0] + points[i][1];
                addDistances[0] = Math.Max(addDistances[0], addDis);
                addDistances[1] = Math.Min(addDistances[1], addDis);

                int reduceDis = points[i][0] - points[i][1];
                reduceDistances[0] = Math.Max(reduceDistances[0], reduceDis);
                reduceDistances[1] = Math.Min(reduceDistances[1], reduceDis);
            }

            return Math.Max(reduceDistances[0] - reduceDistances[1], addDistances[0] - addDistances[1]);
        }

        int MarkIdx(Func<int[], int> predicate)
        {
            int idx = 0;
            for (int i = 1; i < points.Length; i++)
            {
                if (predicate(points[i]) > predicate(points[idx]))
                {
                    idx = i;
                }
            }

            return idx;
        }
    }
}