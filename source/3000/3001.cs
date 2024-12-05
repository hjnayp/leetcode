namespace source._3000._3001;

/// <summary>
///     <a href="https://leetcode.cn/problems/minimum-moves-to-capture-the-queen">
///         3001. Minimum Moves to Capture The Queen
///     </a>
/// </summary>
public class Solution
{
    public int MinMovesToCaptureTheQueen(int rookRow, int rookCol,
                                         int bishopRow, int bishopCol,
                                         int queenRow, int queenCol)
    {
        // 车与皇后处在同一行，且中间没有象
        if (rookRow == queenRow
            && (bishopRow != rookRow
                || bishopCol <= Math.Min(rookCol, queenCol)
                || bishopCol >= Math.Max(rookCol, queenCol)))
        {
            return 1;
        }

        // 车与皇后处在同一列，且中间没有象
        if (rookCol == queenCol
            && (bishopCol != rookCol
                || bishopRow <= Math.Min(rookRow, queenRow)
                || bishopRow >= Math.Max(rookRow, queenRow)))
        {
            return 1;
        }

        // 象、皇后处在同一条对角线，且中间没有车
        if (Math.Abs(bishopRow - queenRow) == Math.Abs(bishopCol - queenCol)
            && ((bishopRow - queenRow) * (rookCol - queenCol) != (rookRow - queenRow) * (bishopCol - queenCol)
                || rookRow < Math.Min(bishopRow, queenRow)
                || rookRow > Math.Max(bishopRow, queenRow)))
        {
            return 1;
        }

        return 2;
    }
}