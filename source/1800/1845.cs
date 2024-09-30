namespace source._1800._1845;

/// <summary>
///     <a href="https://leetcode.cn/problems/seat-reservation-manager">
///         Seat Reservation Manager
///     </a>
/// </summary>
public class SeatManager
{
    private PriorityQueue<int, int> _seats = new();

    public SeatManager(int n)
    {
        for (int i = 1; i <= n; ++i)
        {
            _seats.Enqueue(i, i);
        }
    }

    public int Reserve()
    {
        int seat = _seats.Dequeue();
        return seat;
    }

    public void Unreserve(int seatNumber)
    {
        _seats.Enqueue(seatNumber, seatNumber);
    }
}