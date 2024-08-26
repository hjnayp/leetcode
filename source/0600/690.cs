namespace source._0600._690;

internal class Employee
{
    public int id;
    public int importance;
    public IList<int> subordinates;
}

internal class Solution
{
    public int GetImportance(IList<Employee> employees, int id)
    {
        IDictionary<int, Employee> idToEmployee = new Dictionary<int, Employee>();
        foreach (Employee employee in employees)
        {
            idToEmployee[employee.id] = employee;
        }

        int importance = 0;
        var queue = new Queue<int>();
        queue.Enqueue(id);
        while (queue.Count > 0)
        {
            int employeeId = queue.Dequeue();
            Employee employee = idToEmployee[employeeId];
            importance += employee.importance;
            foreach (int subordinateId in employee.subordinates)
            {
                queue.Enqueue(subordinateId);
            }
        }

        return importance;
    }
}