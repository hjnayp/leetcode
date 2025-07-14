namespace source._1000._1052;

public class Solution
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        int left = 0;
        int right = 0;
        int maxSatisfied = 0;
        while (right < minutes)
        {
            maxSatisfied += (0 ^ grumpy[right]) * customers[right];
            ++right;
        }

        int satisfied = maxSatisfied;
        int len = customers.Length;
        while (right < len)
        {
            satisfied += (0 ^ grumpy[right]) * customers[right];
            satisfied -= (0 ^ grumpy[left]) * customers[left];
            maxSatisfied = Math.Max(maxSatisfied, satisfied);
            ++right;
            ++left;
        }

        maxSatisfied += customers.Select((t, i) => (1 ^ grumpy[i]) * t)
            .Sum();
        return maxSatisfied;
    }
}