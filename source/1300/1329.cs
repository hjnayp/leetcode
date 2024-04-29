namespace source._1300._1329;

public class Solution
{
    private class Diagonal
    {
        public Diagonal(int x, int y)
        {
            X = x;
            Y = y;
            Values = new List<int>();
        }

        public int X { get; private set; }
        public int Y { get; private set; }
        public List<int> Values { get; set; }
    }

    public int[][] DiagonalSort(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;
        var diagonals = new List<Diagonal>();
        for (int i = 0; i < n; ++i)
            diagonals.Add(new Diagonal(0, i));

        for (int i = 1; i < m; ++i)
            diagonals.Add(new Diagonal(i, 0));

        foreach (Diagonal diagonal in diagonals)
        {
            int x = diagonal.X;
            int y = diagonal.Y;
            while (x < m && y < n)
                diagonal.Values.Add(mat[x++][y++]);
            diagonal.Values.Sort();
            int count = diagonal.Values.Count;
            for (int i = 0; i < count; ++i)
                mat[diagonal.X + i][diagonal.Y + i] = diagonal.Values[i];
        }

        return mat;
    }
}