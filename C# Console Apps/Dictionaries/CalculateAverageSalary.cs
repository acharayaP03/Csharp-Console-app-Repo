public class CalculateAverageSalary
{
    public Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(
    IEnumerable<Employee> employees)
    {
        var employeesPerDepartments = new Dictionary<string, List<Employee>>();

        foreach (var employee in employees)
        {
            if (!employeesPerDepartments.ContainsKey(employee.Department))
            {
                employeesPerDepartments[employee.Department] = new List<Employee>();
            }

            employeesPerDepartments[employee.Department].Add(employee);
        }

        var result = new Dictionary<string, decimal>();

        foreach (var employeesPerDepartment in employeesPerDepartments)
        {
            decimal sumOfSalaries = 0;

            foreach (var employee in employeesPerDepartment.Value)
            {
                sumOfSalaries += employee.Salary;
            }

            var average = sumOfSalaries / employeesPerDepartment.Value.Count;

            result[employeesPerDepartment.Key] = average;
        }

        return result;
    }
}
