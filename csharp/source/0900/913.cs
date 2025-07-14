namespace source._0900._913;

/// <summary>
///     <a href="https://leetcode.cn/problems/cat-and-mouse/description">
///         913. Cat and Mouse
///     </a>
/// </summary>
public class Solution
{
    private const int MOUSE_TURN = 0;
    private const int CAT_TURN = 1;
    private const int DRAW = 0;
    private const int MOUSE_WIN = 1;
    private const int CAT_WIN = 2;

    private int[][] _graph;
    private int[,,] _degrees;
    private int[,,] _results;

    public int CatMouseGame(int[][] graph)
    {
        int n = graph.Length;
        _graph = graph;
        _degrees = new int[n, n, 2];
        _results = new int[n, n, 2];
        var queue = new Queue<(int, int, int)>();

        for (int i = 0; i < n; i++)
        for (int j = 1; j < n; j++)
        {
            _degrees[i, j, MOUSE_TURN] = graph[i].Length;
            _degrees[i, j, CAT_TURN] = graph[j].Length;
        }

        foreach (int node in graph[0])
        {
            for (int i = 0; i < n; i++)
            {
                _degrees[i, node, CAT_TURN]--;
            }
        }

        for (int i = 1; i < n; i++)
        {
            _results[0, i, MOUSE_TURN] = MOUSE_WIN;
            _results[0, i, CAT_TURN] = MOUSE_WIN;
            queue.Enqueue((0, i, MOUSE_TURN));
            queue.Enqueue((0, i, CAT_TURN));

            _results[i, i, MOUSE_TURN] = CAT_WIN;
            _results[i, i, CAT_TURN] = CAT_WIN;
            queue.Enqueue((i, i, MOUSE_TURN));
            queue.Enqueue((i, i, CAT_TURN));
        }

        while (queue.Count > 0)
        {
            (int mouse, int cat, int turn) = queue.Dequeue();
            int result = _results[mouse, cat, turn];
            IList<(int, int, int)> prevStates = GetPrevStates(mouse, cat, turn);
            foreach ((int prevMouse, int prevCat, int prevTurn) in prevStates)
            {
                if (_results[prevMouse, prevCat, prevTurn] != DRAW) continue;

                bool canWin = (result == MOUSE_WIN && prevTurn == MOUSE_TURN)
                    || (result == CAT_WIN && prevTurn == CAT_TURN);

                if (canWin)
                {
                    _results[prevMouse, prevCat, prevTurn] = result;
                }
                else
                {
                    // 上一轮的行动方没能找到一个
                    _degrees[prevMouse, prevCat, prevTurn]--;
                    if (_degrees[prevMouse, prevCat, prevTurn] != 0) continue;

                    int loseResult = prevTurn == MOUSE_TURN ? CAT_WIN : MOUSE_WIN;
                    _results[prevMouse, prevCat, prevTurn] = loseResult;
                }

                queue.Enqueue((prevMouse, prevCat, prevTurn));
            }
        }

        return _results[1, 2, MOUSE_TURN];
    }

    private IList<(int, int, int)> GetPrevStates(int mouse, int cat, int turn)
    {
        int prevTurn = turn == MOUSE_TURN ? CAT_TURN : MOUSE_TURN;
        if (prevTurn == MOUSE_TURN)
        {
            return _graph[mouse].Select(prevMouse => (fromNode: prevMouse, cat, prevTurn)).ToList();
        }
        else
        {
            IEnumerable<(int mouse, int prevCat, int prevTurn)> res = from prevCat in _graph[cat]
                                                                      where prevCat != 0
                                                                      select (mouse, prevCat, prevTurn);
            return res.ToList();
        }
    }
}