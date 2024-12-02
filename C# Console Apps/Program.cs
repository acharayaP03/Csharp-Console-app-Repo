using C__Console_Apps.AdvamcedMethods;
using C__Console_Apps.ExceptionHendeling;

Console.WriteLine("This Project consist of bundle of C# console applications.");

var test = new SimpleCustomList<int>();
test.Add(1);
test.Add(2);
test.Add(3);
test.Add(4);
test.Add(5);


// generic method
var ints = new List<int> { 1, 2, 3, 4 };
var decimals = new List<decimal> { 1.2m, 1.5m,2.4m,6.2m};
var unOrderedList = new List<int> { 2, 4, 3, 8, 9, 16 };
var str = new List<string> { "KKK", "hhhh", "aaaa" };

ints.AddToFront(1);
var convertedInts = decimals.ConvertTo<int,decimal>();
Console.WriteLine(convertedInts[1]);
Console.WriteLine(convertedInts[1]);


PrintInOrder(10, 5);
PrintInOrder("4444", "aaaa");

Console.WriteLine("Islarger than 10: " + AdvMethodsPredicateAndLabmdaExpression.IsAny(unOrderedList, number => number > 0));

// lambda expression (params => expression)
Console.WriteLine("IEven with labmda expresion : " + AdvMethodsPredicateAndLabmdaExpression.IsAny(unOrderedList, number => number % 2 == 0)); // lambda expression
Console.WriteLine("IEven : " + AdvMethodsPredicateAndLabmdaExpression.IsAny(unOrderedList, AdvMethodsPredicateAndLabmdaExpression.IsEven)); // lambda expression


//Type constraints

IEnumerable<T> CreateCollectionOfRandomLength<T>(
    int maxLength) where T : new()
{
    var length = new Random().Next(maxLength + 1);

    var result = new List<T>(length);

    for (int i = 0; i < length; ++i)
    {
        result.Add(new T());
    }

    return result;
}
void PrintInOrder<T>(T first, T second) where T : IComparable<T>
{

}


var employees = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barbara Oak", "Xenobiology", 21500 ),
    new Employee("Damien Parker", "Xenobiology", 22000),
    new Employee("Nisha Patel", "Machanics", 21000),
    new Employee("Gustavo Sanchez", "Machanics", 20000),
};

var result = CalculateAverageSalaryPerDepartment(employees);

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(
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

Console.ReadKey();


public static class TupleSwap
{
    public static Tuple<TSecond, TFirst> SwapTupleItem<TFirst, TSecond>(Tuple<TFirst, TSecond> tuple)
            => new Tuple<TSecond, TFirst>(tuple.Item2, tuple.Item1);
}




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

public static class Exercise
{
    public static Dictionary<PetType, double> FindMaxWeights(List<Pet> pets)
    {
        var result = new Dictionary<PetType, double>();

        foreach (var pet in pets)
        {
            if (result.ContainsKey(pet.PetType) || pet.Weight > result[pet.PetType])
            {
                result[pet.PetType] = pet.Weight;
            }
        }

        return result;
    }
}

public class Pet
{
    public PetType PetType { get; }
    public double Weight { get; }

    public Pet(PetType petType, double weight)
    {
        PetType = petType;
        Weight = weight;
    }

    public override string ToString() => $"{PetType}, {Weight} kilos";
}

public enum PetType { Dog, Cat, Fish }