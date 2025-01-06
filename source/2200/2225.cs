namespace source._2200._2225;

public class Solution
{
    public int[][] FindWinners(int[][] matches)
    {
        var winCnt = new Dictionary<int, int>();
        var loseCnt = new Dictionary<int, int>();

        foreach (int[] match in matches)
        {
            int winner = match[0];
            int loser = match[1];

            if (!winCnt.TryAdd(winner, 1)) ++winCnt[winner];
            if (!loseCnt.TryAdd(loser, 1)) ++loseCnt[loser];
        }

        var res = new List<List<int>> { new(), new() };

        foreach ((int key, int value) in loseCnt)
        {
            if (value == 1) res[1].Add(key);
        }

        foreach ((int key, _) in winCnt)
        {
            if (!loseCnt.ContainsKey(key)) res[0].Add(key);
        }

        foreach (List<int> arr in res)
        {
            arr.Sort();
        }

        return [res[0].ToArray(), res[1].ToArray()];
    }
}