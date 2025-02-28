namespace source._2200._2296;

/// <summary>
///     <a href="https://leetcode.cn/problems/design-a-text-editor">
///         2296. Design a Text Editor
///     </a>
/// </summary>
public class TextEditor
{
    private LinkedList<char> _left = new();
    private LinkedList<char> _right = new();

    public void AddText(string text)
    {
        foreach (char ch in text)
        {
            _left.AddLast(ch);
        }
    }

    public int DeleteText(int k)
    {
        int deleteCount = 0;
        while (_left.Count > 0 && k > 0)
        {
            --k;
            _left.RemoveLast();
            ++deleteCount;
        }

        return deleteCount;
    }

    public string CursorLeft(int k)
    {
        while (k > 0 && _left.Count > 0)
        {
            --k;
            _right.AddFirst(_left.Last.Value);
            _left.RemoveLast();
        }

        return GetLeftText();
    }

    public string CursorRight(int k)
    {
        while (k > 0 && _right.Count > 0)
        {
            --k;
            _left.AddLast(_right.First.Value);
            _right.RemoveFirst();
        }

        return GetLeftText();
    }

    private string GetLeftText()
    {
        int len = Math.Min(_left.Count, 10);
        char[] chars = new char[len];
        LinkedListNode<char>? cur = _left.Last;
        for (int i = 1; i <= len; i++)
        {
            chars[^i] = cur.Value;
            cur = cur.Previous;
        }

        return new string(chars);
    }
}