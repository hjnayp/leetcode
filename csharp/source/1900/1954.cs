namespace source._1900._1954;

public class Solution
{
    public long MinimumPerimeter(long neededApples)
    {
        var left = 0;
        var right = 100000;
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (GetArea(mid) >= neededApples)
                right = mid;
            else
                left = mid + 1;
        }

        return left * 8;

        long GetArea(long n)
        {
            return 2 * n * (n + 1) * (2 * n + 1);
        }
    }
}