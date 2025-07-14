using System.Numerics;

namespace source._0700._782;

/// <summary>
///     <a href="https://leetcode.cn/problems/transform-to-chessboard">
///         782. Transform to Chessboard
///     </a>
/// </summary>
public class Solution
{
    private const uint MASK_0X10 = 0xAAAAAAAA;
    private const uint MASK_0X01 = 0x55555555;

    public int MovesToChessboard(int[][] board)
    {
        int n = board.Length;
        int rowMask = board[0].Select((v, i) => v << i).Aggregate(0, (a, b) => a | b);
        int reverseRowMask = ((1 << n) - 1) ^ rowMask;
        int colMask = Enumerable.Range(0, n).Select((v, i) => board[i][0] << i)
            .Aggregate(0, (a, b) => a | b);
        int reverseColMask = ((1 << n) - 1) ^ colMask;

        int rowCount = 0;
        int colCount = 0;
        for (var i = 0; i < board.Length; i++)
        {
            int curRowMask = board[i].Select((v, i) => v << i).Aggregate(0, (a, b) => a | b);
            int curColMask = Enumerable.Range(0, board.Length).Select((j, idx) => board[j][i] << idx)
                .Aggregate(0, (a, b) => a | b);

            if (curRowMask == rowMask)
            {
                ++rowCount;
            }
            else if (curRowMask != reverseRowMask) return -1;

            if (curColMask == colMask)
            {
                ++colCount;
            }
            else if (curColMask != reverseColMask) return -1;
        }

        int rowMoveCnt = GetMoves((ulong)rowMask, rowCount, n);
        int colMoveCnt = GetMoves((ulong)colMask, colCount, n);

        if (rowMoveCnt is -1 || colMoveCnt is -1) return -1;
        return rowMoveCnt + colMoveCnt;
    }

    private int GetMoves(ulong mask, int sameCount, int n)
    {
        int ones = BitOperations.PopCount(mask);

        switch (n & 1)
        {
            case 1 when Math.Abs(n - 2 * ones) != 1 || Math.Abs(n - 2 * sameCount) != 1:
                return -1;
            case 1 when ones == n >> 1:
                return ones - BitOperations.PopCount(mask & MASK_0X10);
            case 1:
                return ones - BitOperations.PopCount(mask & MASK_0X01);
            default:
            {
                if (ones != n >> 1 || sameCount != n >> 1) return -1;

                int count0 = n / 2 - BitOperations.PopCount(mask & MASK_0X10);
                int count1 = n / 2 - BitOperations.PopCount(mask & MASK_0X01);

                return Math.Min(count0, count1);
            }
        }
    }
}