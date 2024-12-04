namespace source._2000._2056;

/// <summary>
///     <a href="https://leetcode.cn/problems/number-of-valid-move-combinations-on-chessboard">
///         2056. Number of Valid Move Combinations On Chessboard
///     </a>
/// </summary>
public class Solution
{
    private static readonly int[][] RookDirections = [[1, 0], [-1, 0], [0, 1], [0, -1]];
    private static readonly int[][] BishopDirections = [[1, 1], [1, -1], [-1, 1], [-1, -1]];

    private static readonly int[][] QueenDirections =
        [[1, 0], [-1, 0], [0, 1], [0, -1], [1, 1], [1, -1], [-1, 1], [-1, -1]];

    public int CountCombinations(string[] pieces, int[][] positions)
    {
        List<Movement> movements = [];
        int n = pieces.Length;
        int res = 0;
        Dfs(0);
        return res;

        void Dfs(int u)
        {
            if (u == n)
            {
                res++;
                return;
            }

            int startX = positions[u][0];
            int startY = positions[u][1];

            movements.Add(new Movement(startX, startY, startX, startY, 0, 0));
            if (IsCrossOtherPieces(u) is false)
            {
                Dfs(u + 1);
            }

            movements.RemoveAt(movements.Count - 1);

            int[][] directions = pieces[u] switch
            {
                "rook" => RookDirections,
                "queen" => QueenDirections,
                _ => BishopDirections,
            };
            foreach (int[] direction in directions)
            {
                int dx = direction[0];
                int dy = direction[1];

                for (int step = 1; step < 8; step++)
                {
                    int x = startX + dx * step;
                    int y = startY + dy * step;

                    if (x is < 1 or > 8 || y is < 1 or > 8) break;

                    movements.Add(new Movement(startX, startY, x, y, dx, dy));
                    if (IsCrossOtherPieces(u) is false)
                    {
                        Dfs(u + 1);
                    }

                    movements.RemoveAt(movements.Count - 1);
                }
            }
        }

        bool IsCrossOtherPieces(int u)
        {
            Movement movement = movements[u];
            return movements.Take(u)
                .Any(v => movement.IsCross(v));
        }
    }

    private class Movement(int startX, int startY, int endX, int endY, int dx, int dy)
    {
        private readonly int startX = startX;
        private readonly int startY = startY;
        private int curX = startX;
        private int curY = startY;

        public bool IsCross(Movement oth)
        {
            Reset();
            oth.Reset();
            while (IsStopped() is false || oth.IsStopped() is false)
            {
                Advance();
                oth.Advance();
                if (curX == oth.curX && curY == oth.curY)
                {
                    return true;
                }
            }

            return false;
        }

        private void Reset()
        {
            curX = startX;
            curY = startY;
        }

        private bool IsStopped()
        {
            return curX == endX && curY == endY;
        }

        private void Advance()
        {
            if (IsStopped()) return;

            curX += dx;
            curY += dy;
        }
    }
}