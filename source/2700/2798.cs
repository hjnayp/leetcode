namespace source._2700._2798;

public class Solution
{
    public int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
    {
        return hours.Count(a => a >= target);
    }
}