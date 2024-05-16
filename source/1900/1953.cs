namespace source._1900._1953;

public class Solution
{
    public long NumberOfWeeks(int[] milestones)
    {
        if (milestones.Length < 2) return 1;

        long max = milestones.Max();
        long rest = milestones.Sum((a) => (long)a) - max;
        if (max > rest + 1)
        {
            return 2 * rest + 1;
        }

        return rest + max;
    }
}