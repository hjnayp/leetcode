package _3400

import _3400._3440.Solution
import io.kotest.core.spec.style.FunSpec
import io.kotest.matchers.shouldBe

class SolutionTest3440 : FunSpec({

    val solution = Solution()
    var eventTime: Int
    var startTime: IntArray
    var endTime: IntArray
    var expected: Int

    test("maxFreeTime") {
        eventTime = 5
        startTime = intArrayOf(1, 3)
        endTime = intArrayOf(2, 5)
        expected = 2

        solution.maxFreeTime(eventTime, startTime, endTime) shouldBe expected
    }
})
