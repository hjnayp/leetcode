namespace source._2500._2589.Solution1
{
    public class Solution
    {
        public int FindMinimumTime(int[][] tasks)
        {
            int n = tasks.Length;
            Array.Sort(tasks, (a, b) => a[1] - b[1]);
            int lastEnd = tasks[^1][1] + 1;

            var run = new List<int>(lastEnd);
            for (int i = 0; i < lastEnd; ++i) run.Add(0);

            int res = 0;
            for (int i = 0; i < n; ++i)
            {
                int start = tasks[i][0];
                int end = tasks[i][1];
                int duration = tasks[i][2];
                int runedTime = run.Skip(start).Take(end - start + 1).Sum();
                duration -= runedTime;
                res += Math.Max(0, duration);

                for (int i1 = end; i1 >= 0 && duration > 0; --i1)
                {
                    if (run[i1] != 0) continue;
                    --duration;
                    run[i1] = 1;
                }
            }

            return res;
        }
    }
}

namespace source._2500._2589.Solution2
{
    public class Solution
    {
        public int FindMinimumTime(int[][] tasks)
        {
            int res = 0;
            for (int i = 1;; ++i)
            {
                bool isFinished = true;
                bool isRun = false;

                foreach (int[] task in tasks)
                {
                    int end = task[1];
                    int duration = task[2];

                    if (duration > 0 && end - i + 1 <= duration)
                    {
                        isRun = true;
                    }

                    if (i <= end)
                    {
                        isFinished = false;
                    }
                }

                if (isFinished) break;
                if (!isRun) continue;

                ++res;
                foreach (int[] task in tasks)
                {
                    int start = task[0];
                    int end = task[1];
                    if (i < start || i > end) continue;
                    --task[2];
                }
            }

            return res;
        }
    }
}

namespace source._2500._2589.Solution3
{
    public class Solution
    {
        public int FindMinimumTime(int[][] tasks)
        {
            Array.Sort(tasks, (a, b) => a[1] - b[1]);

            // interval: [task_start, task_end, total_run_time_at_end]
            var runTaskStack = new List<int[]> { new[] { -1, -1, 0 } };

            foreach (int[] task in tasks)
            {
                int start = task[0];
                int end = task[1];
                int duration = task[2];
                int k = BinarySearch(start);

                duration -= runTaskStack[^1][2] - runTaskStack[k - 1][2];
                if (start <= runTaskStack[k - 1][1])
                {
                    duration -= runTaskStack[k - 1][1] - start + 1;
                }

                if (duration <= 0) continue;

                // Merge intervals
                while (end - runTaskStack[^1][1] <= duration)
                {
                    duration += runTaskStack[^1][1] - runTaskStack[^1][0] + 1;
                    runTaskStack.RemoveAt(runTaskStack.Count - 1);
                }

                runTaskStack.Add(new[] { end - duration + 1, end, runTaskStack[^1][2] + duration });
            }

            return runTaskStack[^1][2];

            // Find the first interval that has start >= targetStart
            int BinarySearch(int targetStart)
            {
                int low = 0;
                int high = runTaskStack.Count;
                while (low < high)
                {
                    int mid = (high - low) / 2 + low;
                    if (runTaskStack[mid][0] <= targetStart)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid;
                    }
                }

                return low;
            }
        }
    }
}