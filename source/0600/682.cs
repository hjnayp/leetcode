namespace source._0600._682;

public class Solution
{
    public int CalPoints(string[] operations)
    {
        var records = new Stack<int>();

        foreach (string operation in operations)
        {
            switch (operation)
            {
                case "D":
                    records.Push(records.Peek() * 2);
                    break;

                case "C":
                    records.Pop();
                    break;

                case "+":
                    int last = records.Pop();
                    int last2 = records.Peek();
                    records.Push(last);
                    records.Push(last + last2);
                    break;

                default:
                    records.Push(int.Parse(operation));
                    break;
            }
        }

        return records.Sum();
    }
}