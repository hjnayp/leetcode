namespace source.LCR._139;

/// <summary>
///     <a href="https://leetcode.cn/problems/diao-zheng-shu-zu-shun-xu-shi-qi-shu-wei-yu-ou-shu-qian-mian-lcof">
///         LCR 139. 训练计划 I
///     </a>
/// </summary>
public class Solution
{
    public int[] TrainingPlan(int[] actions)
    {
        int idx = 0;
        for (var i = 0; i < actions.Length; i++)
        {
            if (actions[i] % 2 == 0) continue;

            (actions[idx], actions[i]) = (actions[i], actions[idx]);
            ++idx;
        }

        return actions;
    }
}