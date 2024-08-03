namespace source.Lcp._24;

public class Solution
{
    public int[] NumsGame(int[] nums)
    {
        int n = nums.Length;
        var res = new int[n];
        var lower = new PriorityQueue<int, int>();
        var upper = new PriorityQueue<int, int>();
        const int Mod = 1_000_000_007;
        long lowerSum = 0;
        long upperSum = 0;

        for (var i = 0; i < n; ++i)
        {
            int x = nums[i] - i;
            if (lower.Count == 0 || lower.Peek() >= x)
            {
                lowerSum += x;
                lower.Enqueue(x, -x);

                if (lower.Count > upper.Count + 1)
                {
                    upperSum += lower.Peek();
                    upper.Enqueue(lower.Peek(), lower.Peek());
                    lowerSum -= lower.Peek();
                    lower.Dequeue();
                }
            }
            else
            {
                upperSum += x;
                upper.Enqueue(x, x);

                if (upper.Count > lower.Count)
                {
                    lowerSum += upper.Peek();
                    lower.Enqueue(upper.Peek(), -upper.Peek());
                    upperSum -= upper.Peek();
                    upper.Dequeue();
                }
            }

            if ((i + 1) % 2 == 0)
                res[i] = (int)((upperSum - lowerSum) % Mod);
            else
                res[i] = (int)((upperSum - lowerSum + lower.Peek()) % Mod);
        }

        return res;
    }
}