namespace source._0400._419;

public class Solution
{
    public int CountBattleships(char[][] board)
    {
        int rowLen = board.Length;
        int colLen = board[0].Length;
        bool[,] visit = new bool[rowLen, colLen];
        int count = 0;
        for (int i = 0; i < rowLen; ++i)
        for (int j = 0; j < colLen; j++)
        {
            if (visit[i, j]) continue;
            if (board[i][j] == '.') continue;
            DFS(i, j);
            ++count;
        }

        return count;

        void DFS(int i, int j)
        {
            if (i < 0 || i >= rowLen ||
                j < 0 || j >= colLen ||
                visit[i, j] ||
                board[i][j] == '.') return;

            visit[i, j] = true;
            DFS(i + 1, j);
            DFS(i - 1, j);
            DFS(i, j + 1);
            DFS(i, j - 1);
        }
    }
}