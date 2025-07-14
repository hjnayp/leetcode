namespace source._1900._1962;

public class Solution
{
    public int MinStoneSum(int[] piles, int k)
    {
        var pq = new PriorityQueue<int, int>();
        foreach (var pile in piles)
            pq.Enqueue(pile, -pile);

        while (k-- > 0)
        {
            var v = pq.Dequeue();
            v = v - v / 2;
            pq.Enqueue(v, -v);
        }

        var res = 0;
        while (pq.Count > 0)
            res += pq.Dequeue();
        return res;
    }
}