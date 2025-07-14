namespace source._0900._999;

/// <summary>
///     <a href="https://leetcode.cn/problems/available-captures-for-rook">
///         999. Available Captures for Rook
///     </a>
/// </summary>
public class Solution
{
    private const int N = 8;

    public int NumRookCaptures(char[][] board)
    {
        int x = 0;
        int y = 0;

        for (int i = 0; i < N; i++)
        for (int j = 0; j < N; ++j)
        {
            if (board[i][j] is not 'R') continue;

            x = i;
            y = j;
            break;
        }

        int count = 0;
        (int, int)[] directions = [(0, 1), (0, -1), (1, 0), (-1, 0)];
        foreach ((int dx, int dy) in directions)
        {
            int curX = x + dx;
            int curY = y + dy;
            while (curX is >= 0 and < N && curY is >= 0 and < N)
            {
                char c = board[curX][curY];
                if (c is 'B') break;

                if (c is 'p')
                {
                    ++count;
                    break;
                }

                curX += dx;
                curY += dy;
            }
        }

        return count;
    }
}