package _3400._3439

import kotlin.math.max

class Solution {
    fun maxFreeTime(eventTime: Int, k: Int, startTime: IntArray, endTime: IntArray): Int {
        var sum = 0
        var res = 0
        val n = startTime.size

        for (i in 0..n - 1) {
            sum += endTime[i] - startTime[i]
            val left = if (i < k) 0 else endTime[i - k]
            val right = if (i < n - 1) startTime[i + 1] else eventTime
            res = max(res, right - left - sum)

            if (i >= k - 1)
                sum -= endTime[i - k + 1] - startTime[i - k + 1]
        }

        return res
    }
}