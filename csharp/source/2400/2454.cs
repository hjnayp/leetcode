namespace source._2400._2454;

public class Solution
{
    public int[] SecondGreaterElement(int[] nums)
    {
        var n = nums.Length;
        var res = new int[n];
        Array.Fill(res, -1);

        var stack = new Stack<int>();
        var heap = new PriorityQueue<Tuple<int, int>, int>();
        for (var i = 0; i < n; ++i)
        {
            while (heap.Count > 0 && heap.Peek().Item1 < nums[i])
                res[heap.Dequeue().Item2] = nums[i];

            while (stack.Any() && nums[stack.Peek()] < nums[i])
            {
                heap.Enqueue(new Tuple<int, int>(nums[stack.Peek()], stack.Peek()), nums[stack.Peek()]);
                stack.Pop();
            }

            stack.Push(i);
        }

        return res;
    }
}