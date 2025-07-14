using JetBrains.Annotations;
using source._0600._690;

namespace test._0600;

[TestClass]
[TestSubject(typeof(Solution))]
public class Test690
{
    [TestMethod]
    public void NormalCase()
    {
        RunTestCase([(1, 5, [2, 3]), (2, 3, []), (3, 3, [])], 1, 11);
        RunTestCase([(1, 2, [5]), (5, -3, [])], 5, -3);
    }

    private void RunTestCase((int, int, int[])[] employee, int id, int expected)
    {
        var solution = new Solution();
        var employees = new List<Employee>();
        foreach ((int employeeId, int importance, int[] subordinates) in employee)
        {
            employees.Add(
                new Employee { id = employeeId, importance = importance, subordinates = subordinates.ToList() }
            );
        }

        Assert.AreEqual(expected, solution.GetImportance(employees, id));
    }
}