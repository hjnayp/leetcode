namespace source._2500._2555;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximize-win-from-two-segments">
///         Maximize Win From Two Segments
///     </a>
/// </summary>
public class Solution
{
    public int MaximizeWin(int[] prizePositions, int k)
    {
        int n = prizePositions.Length;
        int[] wins = new int[n + 1];
        int maxWin = 0;
        int left = 0;
        int right = 0;
        while (right < n)
        {
            while (prizePositions[right] - prizePositions[left] > k) ++left;
            int selectedPrizeCount = right - left + 1;
            maxWin = Math.Max(maxWin, wins[left] + selectedPrizeCount);
            wins[right + 1] = Math.Max(wins[right], selectedPrizeCount);
            ++right;
        }

        return maxWin;
    }
}