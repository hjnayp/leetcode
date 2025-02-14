namespace source._1500._1552;

/// <summary>
///     <a href="https://leetcode.cn/problems/magnetic-force-between-two-balls">
///         1552. Magnetic Force Between Two Balls
///     </a>
/// </summary>
public class Solution
{
    public int MaxDistance(int[] position, int m)
    {
        Array.Sort(position);
        int high = (position[^1] - position[0]) / (m - 1);
        int low = 1;
        int minDistance = 0;

        while (low <= high)
        {
            int mid = (high - low) / 2 + low / 2;
            if (HasEnoughPosition(mid))
            {
                low = mid + 1;
                minDistance = mid;
            }
            else
            {
                high = mid - 1;
            }
        }

        return minDistance;

        bool HasEnoughPosition(int offset)
        {
            int count = 1;
            int prev = position[0];
            foreach (int pos in position.Skip(1))
            {
                int distance = pos - prev;
                if (distance < offset) continue;

                ++count;
                prev = pos;
            }

            return count >= m;
        }
    }
}