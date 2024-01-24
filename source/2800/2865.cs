namespace source._2800._2865;

public class Solution
{
    public long MaximumSumOfHeights(IList<int> maxHeights)
    {
        var n = maxHeights.Count;
        var prefix = new long[n];
        var stack1 = new Stack<int>();
        for (var i = 0; i < n; ++i)
        {
            while (stack1.Count > 0 && maxHeights[stack1.Peek()] > maxHeights[i])
                stack1.Pop();

            if (stack1.Count == 0)
                prefix[i] = (long)maxHeights[i] * (i + 1);
            else
                prefix[i] = prefix[stack1.Peek()] + (long)maxHeights[i] * (i - stack1.Peek());

            stack1.Push(i);
        }

        var suffix = new long[n];
        var stack2 = new Stack<int>();
        long res = 0;
        for (var i = n - 1; i >= 0; --i)
        {
            while (stack2.Count > 0 && maxHeights[stack2.Peek()] > maxHeights[i])
                stack2.Pop();

            if (stack2.Count == 0)
                suffix[i] = (long)maxHeights[i] * (n - i);
            else
                suffix[i] = suffix[stack2.Peek()] + (long)maxHeights[i] * (stack2.Peek() - i);
            stack2.Push(i);
            res = Math.Max(res, prefix[i] + suffix[i] - maxHeights[i]);
        }

        return res;
    }
}