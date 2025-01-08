namespace source._0600._661;

/// <summary>
///     <a href="https://leetcode.cn/problems/image-smoother">
///         661. Image Smoother
///     </a>
/// </summary>
public class Solution
{
    private static readonly int[][] Neighbours =
    [
        [0, 0], [0, 1], [0, -1],
        [-1, 0], [-1, -1], [-1, 1],
        [1, 0], [1, -1], [1, 1],
    ];

    public int[][] ImageSmoother(int[][] img)
    {
        int[][] smoother = new int[img.Length][];

        for (int i = 0; i < img.Length; i++)
        {
            smoother[i] = new int[img[i].Length];
            for (int j = 0; j < img[i].Length; j++)
            {
                smoother[i][j] = Smoother(i, j);
            }
        }

        return smoother;

        int Smoother(int x, int y)
        {
            int res = 0;
            int count = 0;

            foreach (int[] neighbour in Neighbours)
            {
                int i = x + neighbour[0];
                int j = y + neighbour[1];

                if (i < 0 || i >= img.Length || j < 0 || j >= img[i].Length)
                {
                    continue;
                }

                res += img[i][j];
                ++count;
            }

            if (count == 0)
            {
                return 0;
            }

            return res / count;
        }
    }
}