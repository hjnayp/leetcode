/// <summary>
///     <a href="https://leetcode.cn/problems/sort-integers-by-the-power-value">
///         1387. Sort Integers by The Power Value
///     </a>
/// </summary>
public class Solution
{
    private static Dictionary<int, int> NumberToPower = new();

    public int GetKth(int lo, int hi, int k)
    {
        int[] numbers = Enumerable.Range(lo, hi - lo + 1).ToArray();
        Array.Sort(numbers, (a, b) =>
        {
            int powerOrder = Dp(a).CompareTo(Dp(b));
            return powerOrder is 0 ? a.CompareTo(b) : powerOrder;
        });

        return numbers[k - 1];
    }

    private static int Dp(int x)
    {
        if (NumberToPower.TryGetValue(x, out int value))
        {
            return value;
        }

        if (x == 1) return NumberToPower[x] = 0;

        if ((x & 1) == 1)
        {
            return NumberToPower[x] = Dp(3 * x + 1) + 1;
        }

        return NumberToPower[x] = Dp(x / 2) + 1;
    }
}