namespace source._2800._2866;

public class Solution
{
    public long MaximumSumOfHeights(IList<int> max_heights)
    {
        var n = max_heights.Count;
        var prefix = new long[n];
        var stack = new Stack<int>();
        for (var i = 0; i < n; ++i)
        {
            while (stack.Any() && max_heights[stack.Peek()] > max_heights[i])
                stack.Pop();

            if (stack.Any())
                prefix[i] = prefix[stack.Peek()] + (long)(i - stack.Peek()) * max_heights[i];
            else
                prefix[i] = (long)(i + 1) * max_heights[i];

            stack.Push(i);
        }

        stack.Clear();
        var suffix = new long[n];
        for (var i = n - 1; i >= 0; --i)
        {
            while (stack.Any() && max_heights[stack.Peek()] > max_heights[i])
                stack.Pop();

            if (stack.Any())
                suffix[i] = suffix[stack.Peek()] + (long)(stack.Peek() - i) * max_heights[i];
            else
                suffix[i] = (long)(n - i) * max_heights[i];
            stack.Push(i);
        }


        var max = 0L;
        for (var i = 0; i < n; ++i)
            max = Math.Max(max, prefix[i] + suffix[i] - max_heights[i]);
        return max;
    }
}