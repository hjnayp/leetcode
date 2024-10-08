namespace source._1200._1227;

/// <summary>
///     <a
///         href="https://leetcode.cn/problems/airplane-seat-assignment-probability/description/?envType=daily-question&envId=2024-10-04">
///         Airplane Seat Assignment Probability
///     </a>
/// </summary>
public class Solution
{
    public double NthPersonGetsNthSeat(int n)
    {
        if (n == 1) return 1.0;
        return 1.0 / n + (n - 2.0) / n * NthPersonGetsNthSeat(n - 1);
    }
}