using C__Console_Apps.AdvamcedMethods;
using C__Console_Apps.Attributes;
using C__Console_Apps.Constraint;
using C__Console_Apps.Linqs;

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


new CreateCollection().PrintInOrder(10, 5);
new CreateCollection().PrintInOrder("4444", "aaaa");

Console.WriteLine("Islarger than 10: " + AdvMethodsPredicateAndLabmdaExpression.IsAny(unOrderedList, number => number > 0));

// lambda expression (params => expression)
Console.WriteLine("IEven with labmda expresion : " + AdvMethodsPredicateAndLabmdaExpression.IsAny(unOrderedList, number => number % 2 == 0)); // lambda expression
Console.WriteLine("IEven : " + AdvMethodsPredicateAndLabmdaExpression.IsAny(unOrderedList, AdvMethodsPredicateAndLabmdaExpression.IsEven)); // lambda expression


var employees = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barbara Oak", "Xenobiology", 21500 ),
    new Employee("Damien Parker", "Xenobiology", 22000),
    new Employee("Nisha Patel", "Machanics", 21000),
    new Employee("Gustavo Sanchez", "Machanics", 20000),
};

var result = new CalculateAverageSalary().CalculateAverageSalaryPerDepartment(employees);

// Annonymous type
var listsOfNumbers = new List<List<int>>
{
    new List<int> { 15,68,20,12,19,8,55},
    new List<int> { 12,1,3,4,-19,8,7,6},
    new List<int> { 5,-6,-2,-12,-10,7}
};

// new {} initializes an object with anonymous type Count and Average
// off course this is possible if we are not planning to user those propeties in other places. 
// new { Count = ..., Average = ... }  
// it creates gettale properties only and can only be used to carry temporary data like in here.
var anonymousTypesResult = listsOfNumbers.Select(listOfNumber => new
{
    Count = listOfNumber.Count(),
    Average = listOfNumber.Average(),
})
    .OrderByDescending(countAndAverage => countAndAverage.Average)
    .Select(countAndAverage =>

        $"Count is: {countAndAverage.Count}, " +
        $"Average is: {countAndAverage.Average}"
    );

Console.WriteLine(string.Join(Environment.NewLine, anonymousTypesResult));

//ref and out 
int someInteger = 5;

void AddOneToNumber(ref int number)
{
    ++number;
}

void MethodWithOutParameter(out int number)
{
    number = 10;
}

AddOneToNumber(ref someInteger);
MethodWithOutParameter(out int otherNumber);
Console.WriteLine($"{someInteger}, is changed since we pass it as ref");
Console.WriteLine($"{otherNumber}, is changed since we pass it as out");

//using var reader = new AllLinesFromTextFileReader("filePath.txt");


var converter = new ObjectToTextConverter();
Console.WriteLine(converter.Convert(new House("123 John street", 170.6, 2)));

var validPerson = new Person("Tristen", 1984);
var validator = new Validator();
var invalidPerson = new Person("t", 19);

Console.WriteLine(validator.Validate(validPerson) ? "Yup he is trishten" : "nope....");
Console.WriteLine(validator.Validate(invalidPerson) ? "Yes this is valid as well": "nope, not valid...");


// non destructive mutation on struct
// only possibe to mutate by "with" id the setter in "init"
var point = new Point(10, 12);
var mutatedPoint = point with { X = 11, Y = 22 };
Console.ReadKey();


public record House(string Address, double Area, int Floors);

public class Person
{
    [StringLengthValidate(2,25)]
    public string Name { get; }

    public int YearOfBirth { get; }

    public Person(string name, int yearOfBirth)
    {
        Name = name;
        YearOfBirth = yearOfBirth;
    }

    public Person(string name ) => Name = name;
}

struct Point
{
    public int X { get; init; }
    public int Y { get; init; }


    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }
}

public struct Time
{
    public int Hour { get; }

    public int Minutes { get; }

    public Time(int hour, int minutes)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException("Hour is out of range of 0-23");
        }

        if (minutes < 0 || minutes > 59)
        {
            throw new ArgumentOutOfRangeException("Minute is out of range of 0-59");
        }
        Hour = hour;
        Minutes = minutes;
    }

    public override string ToString() => $"{Hour:00}:{Minutes:00}";

    public string Describe() => $"{Hour.ToString("00")}:{Minutes.ToString("00")}";

}
