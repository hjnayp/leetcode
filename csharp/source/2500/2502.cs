namespace source._2500._2502;

/// <summary>
///     <a href="https://leetcode.cn/problems/design-memory-allocator">
///         2502. Design Memory Allocator
///     </a>
/// </summary>
public class Allocator
{
    private int[] _memories;

    public Allocator(int n)
    {
        _memories = new int[n];
    }

    public int Allocate(int size, int mId)
    {
        int count = 0;
        for (int i = 0; i < _memories.Length; i++)
        {
            int value = _memories[i];
            if (value == 0)
            {
                ++count;
                if (count < size) continue;

                for (int j = i - count + 1; j <= i; ++j)
                {
                    _memories[j] = mId;
                }

                return i - count + 1;
            }
            else
            {
                count = 0;
            }
        }

        return -1;
    }

    public int FreeMemory(int mId)
    {
        int freeCount = 0;
        for (int i = 0; i < _memories.Length; i++)
        {
            if (_memories[i] == mId)
            {
                _memories[i] = 0;
                ++freeCount;
            }
        }

        return freeCount;
    }
}