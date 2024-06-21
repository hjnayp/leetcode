namespace source._0300._365;

public class Solution
{
    public bool CanMeasureWater(int x, int y, int target)
    {
        int gcd = GCD(x, y);
        return target % gcd == 0;

        int GCD(int x, int y)
        {
            int remainder = x % y;
            while (remainder != 0)
            {
                x = y;
                y = remainder;
                remainder = x % y;
            }

            return y;
        }
    }
}

public class Solution2
{
    public bool CanMeasureWater(int x, int y, int target)
    {
        Stack<(int, int)> actionStack = new();
        ISet<(int, int)> visited = new HashSet<(int, int)>();
        actionStack.Push((0, 0));

        while (actionStack.Any())
        {
            (int a, int b) = actionStack.Pop();
            if (visited.Contains((a, b))) continue;
            if (a == target || b == target || a + b == target) return true;
            visited.Add((a, b));
            actionStack.Push((x, b));
            actionStack.Push((a, y));
            actionStack.Push((0, b));
            actionStack.Push((a, 0));
            actionStack.Push((a - Math.Min(a, y - b), b + Math.Min(a, y - b)));
            actionStack.Push((a + Math.Min(b, x - a), b - Math.Min(b, x - a)));
        }

        return false;
    }
}