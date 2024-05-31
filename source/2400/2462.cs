namespace source._2400._2462;

public class Solution
{
    public long TotalCost(int[] costs, int k, int candidates)
    {
        var left = new PriorityQueue<int, int>();
        var right = new PriorityQueue<int, int>();

        int i = 0;
        while (i < candidates)
        {
            left.Enqueue(costs[i], costs[i]);
            ++i;
        }

        int n = costs.Length;
        int j = n - 1;
        while (j > n - candidates - 1 && j >= i)
        {
            right.Enqueue(costs[j], costs[j]);
            --j;
        }

        long total = 0;
        while (k > 0)
        {
            --k;
            if (left.Count == 0) MoveRight();
            else if (right.Count == 0) MoveLeft();
            else if (left.Peek() > right.Peek()) MoveRight();
            else MoveLeft();
        }

        return total;

        void MoveLeft()
        {
            total += left.Dequeue();
            if (i > j) return;
            left.Enqueue(costs[i], costs[i]);
            ++i;
        }

        void MoveRight()
        {
            total += right.Dequeue();
            if (j < i) return;

            right.Enqueue(costs[j], costs[j]);
            --j;
        }
    }
}