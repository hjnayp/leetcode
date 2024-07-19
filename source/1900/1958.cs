namespace source._1900._1958;

/// <summary>
///     https://leetcode.cn/problems/check-if-move-is-legal
/// </summary>
public class Solution
{
    private static readonly (int, int)[] s_Directions =
    [
        (-1, -1), (-1, 0), (-1, 1),
        (0, -1), (0, 0), (0, 1),
        (1, -1), (1, 0), (1, 1)
    ];

    public bool CheckMove(char[][] board, int rMove, int cMove, char color)
    {
        int n = board.Length;
        return Array.Exists(s_Directions, FindLineInDirection);

        bool FindLineInDirection((int, int) direction)
        {
            (int, int) startPoint = (rMove, cMove);
            (int, int) nextPoint = MovePoint(startPoint, direction);
            bool haveEncounterOppositeColor = false;
            while (IsPointInBoard(nextPoint))
            {
                char v = GetPointValue(nextPoint);
                bool isFreeCell = v == '.';
                bool isSameCell = !isFreeCell && color == v;

                if (isFreeCell) return false;
                if (isSameCell) return haveEncounterOppositeColor;

                if (!haveEncounterOppositeColor) haveEncounterOppositeColor = true;
                nextPoint = MovePoint(nextPoint, direction);
            }

            return false;
        }

        char GetPointValue((int, int) point)
        {
            return board[point.Item1][point.Item2];
        }

        (int, int) MovePoint((int, int) point, (int, int) direction)
        {
            return (point.Item1 + direction.Item1, point.Item2 + direction.Item2);
        }

        bool IsPointInBoard((int, int) point)
        {
            if (point.Item1 < 0 || point.Item1 >= n) return false;
            if (point.Item2 < 0 || point.Item2 >= n) return false;
            return true;
        }
    }
}