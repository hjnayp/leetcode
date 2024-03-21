namespace source._2600._2671;

public class FrequencyTracker
{
    private Dictionary<int, int> _frequency = new();
    private Dictionary<int, int> _numbers = new();

    public FrequencyTracker()
    {
        _frequency.Clear();
        _numbers.Clear();
    }

    public void Add(int number)
    {
        bool exist = _numbers.TryGetValue(number, out int freq);
        if (exist)
        {
            ++_numbers[number];
            --_frequency[freq];
            if (_frequency[freq] == 0)
                _frequency.Remove(freq);
            _frequency.TryAdd(freq + 1, 0);
            ++_frequency[freq + 1];
        }
        else
        {
            _numbers.Add(number, 1);
            _frequency.TryAdd(1, 0);
            ++_frequency[1];
        }
    }

    public void DeleteOne(int number)
    {
        if (!_numbers.TryGetValue(number, out int freq)) return;
        --_numbers[number];
        if (_numbers[number] == 0)
            _numbers.Remove(number);

        --_frequency[freq];
        if (_frequency[freq] == 0)
            _frequency.Remove(freq);

        if (freq - 1 <= 0) return;
        _frequency.TryAdd(freq - 1, 0);
        ++_frequency[freq - 1];
    }

    public bool HasFrequency(int frequency)
    {
        return _frequency.ContainsKey(frequency);
    }
}