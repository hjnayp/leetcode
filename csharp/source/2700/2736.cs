namespace source._2700._2736;

public class Solution
{
    public int[] MaximumSumQueries(int[] nums1, int[] nums2, int[][] queries)
    {
        int n = nums1.Length;
        int[][]? nums_list = new int[n][];
        for (int i = 0; i < n; ++i)
        {
            nums_list[i] = new[] { nums1[i], nums2[i] };
        }

        Array.Sort(nums_list, (a, b) => b[0] - a[0]);

        int m = queries.Length;
        int[][]? queries_list = new int[m][];
        for (int i = 0; i < m; ++i)
        {
            queries_list[i] = new[] { i, queries[i][0], queries[i][1] };
        }

        Array.Sort(queries_list, (a, b) => b[1] - a[1]);

        int[]? res = new int[m];
        Array.Fill(res, -1);
        int j = 0;
        var stack = new List<Tuple<int, int>>();
        foreach (int[] query in queries_list)
        {
            int i = query[0];
            int x = query[1];
            int y = query[2];

            while (j < n && nums_list[j][0] >= x)
            {
                int[] pair = nums_list[j];
                int num1 = pair[0];
                int num2 = pair[1];
                while (stack.Count > 0 && stack.Last().Item2 <= num1 + num2)
                {
                    stack.RemoveAt(stack.Count - 1);
                }

                if (stack.Count == 0 || stack.Last().Item1 < num2)
                {
                    stack.Add(new Tuple<int, int>(num2, num1 + num2));
                }

                ++j;
            }

            int k = BinarySearch(stack, y);
            if (k < stack.Count)
            {
                res[i] = stack[k].Item2;
            }
        }

        return res;
    }

    private static int BinarySearch(IList<Tuple<int, int>> list, int target)
    {
        int left = 0;
        int right = list.Count;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (list[mid].Item1 >= target)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}