namespace source._0200._232;

public class MyQueue
{
    private readonly Stack<int> _inStack = new();
    private readonly Stack<int> _outStack = new();

    public void Push(int x)
    {
        _inStack.Push(x);
    }

    public int Pop()
    {
        if (_outStack.Count == 0)
        {
            InToOut();
        }

        return _outStack.Pop();
    }

    public int Peek()
    {
        if (_outStack.Count == 0)
        {
            InToOut();
        }

        return _outStack.Peek();
    }

    public bool Empty()
    {
        return _inStack.Count + _outStack.Count == 0;
    }

    private void InToOut()
    {
        while (_inStack.Count > 0)
        {
            _outStack.Push(_inStack.Pop());
        }
    }
}