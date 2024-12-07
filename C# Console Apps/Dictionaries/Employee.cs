public class Employee
{
    public string Name { get; init; }
    public string Department {  get; init; }
    public decimal Salary { get; init; }

    public Employee(string name, string department, decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
}
