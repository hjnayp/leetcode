namespace source._0300._304;

public class NumMatrix
{
    private readonly int[][] _sum;

    public NumMatrix(int[][] matrix)
    {
        _sum = new int[matrix.Length][];
        for (var i = 0; i < matrix.Length; ++i)
            _sum[i] = new int[matrix[i].Length];

        InitSum(matrix, _sum);
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        var res = _sum[row2][col2];

        if (row1 > 0 && col1 > 0)
            res += _sum[row1 - 1][col1 - 1];

        if (row1 > 0)
            res -= _sum[row1 - 1][col2];

        if (col1 > 0)
            res -= _sum[row2][col1 - 1];

        return res;
    }

    private static void InitSum(int[][] matrix, int[][] sum)
    {
        for (var i = 0; i < matrix.Length; ++i)
        {
            var res = 0;
            for (var j = 0; j < matrix[0].Length; ++j)
            {
                res += matrix[i][j];
                sum[i][j] = res;
                if (i > 0)
                    sum[i][j] += sum[i - 1][j];
            }
        }
    }
}