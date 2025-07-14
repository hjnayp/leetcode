package _1200

import struct.ListNode


class Solution {
    fun getDecimalValue(head: ListNode?): Int {
        var res = 0
        var p = head
        while (p != null) {
            res = res * 2 + p.`val`
            p = p.next
        }

        return res
    }
}