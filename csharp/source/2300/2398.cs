namespace source._2300._2398;

/// <summary>
///     <a href="https://leetcode.cn/problems/maximum-number-of-robots-within-budget">
///         Maximum Number of Robots Within Budget
///     </a>
/// </summary>
public class Solution
{
    public int MaximumRobots(int[] chargeTimes, int[] runningCosts, long budget)
    {
        int robotCount = 0;
        int n = chargeTimes.Length;
        int left = 0;
        int right = 0;
        var robotIndices = new LinkedList<int>();
        long runningCostSum = 0;

        while (right < n)
        {
            AddCost();
            CheckIsCostOverBudget();
            robotCount = Math.Max(robotCount, right - left + 1);
            ++right;
        }

        return robotCount;

        void CheckIsCostOverBudget()
        {
            while (left <= right && IsOverBudget())
            {
                if (robotIndices.First?.Value == left)
                {
                    robotIndices.RemoveFirst();
                }

                runningCostSum -= runningCosts[left];
                ++left;
            }
        }

        bool IsOverBudget()
        {
            long cost = (right - left + 1) * runningCostSum + chargeTimes[robotIndices.First!.Value];
            return cost > budget;
        }

        void AddCost()
        {
            runningCostSum += runningCosts[right];
            while (robotIndices.Count > 0 &&
                   chargeTimes[robotIndices.Last!.Value] <= chargeTimes[right])
            {
                robotIndices.RemoveLast();
            }

            robotIndices.AddLast(right);
        }
    }
}