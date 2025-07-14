package _3400._3440

import kotlin.math.max


class Solution {
    fun maxFreeTime(eventTime: Int, startTime: IntArray, endTime: IntArray): Int {
        val n = startTime.size
        val canMove = BooleanArray(n)
        var tL = 0
        var tR = 0
        for (i in 0..n - 1) {
            if (endTime[i] - startTime[i] <= tL) {
                canMove[i] = true
            }

            var freeTime = startTime[i] - (if (i == 0) 0 else endTime[i - 1])
            tL = max(tL, freeTime)

            val j = n - i - 1
            if (endTime[j] - startTime[j] <= tR)
                canMove[j] = true

            freeTime = (if (i == 0) eventTime else startTime[j + 1]) - endTime[j]
            tR = max(tR, freeTime)
        }

        var res = 0
        for (i in 0..n - 1) {
            val left = if (i == 0) 0 else endTime[i - 1]
            val right = if (i == n - 1) eventTime else startTime[i + 1]

            var freeTime = right - left
            if (!(canMove[i]))
                freeTime -= endTime[i] - startTime[i]

            res = max(res, freeTime)
        }

        return res
    }
}