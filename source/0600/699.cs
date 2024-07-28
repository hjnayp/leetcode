namespace source._0600._699;

/// <summary>
///     https://leetcode.cn/problems/falling-squares
/// </summary>
public class Solution
{
    public IList<int> FallingSquares(int[][] positions)
    {
        IList<int> heights = new List<int>();
        for (int i = 0; i < positions.Length; i++)
        {
            int left = positions[i][0];
            int sideLength = positions[i][1];
            int right = left + sideLength - 1;
            heights.Add(sideLength);

            for (int j = 0; j < i; ++j)
            {
                int left2 = positions[j][0];
                int right2 = positions[j][0] + positions[j][1] - 1;
                if (left2 > right || right2 < left) continue;
                heights[i] = Math.Max(heights[i], heights[j] + sideLength);
            }
        }

        for (int i = 1; i < heights.Count; i++)
        {
            heights[i] = Math.Max(heights[i], heights[i - 1]);
        }

        return heights;
    }
}