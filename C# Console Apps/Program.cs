Console.WriteLine("This Project consist of bundle of C# console applications.");

//Chedder chedder = new();
//var ingredients = new List<Ingredients> { chedder, new Mozzarella(), new Parmesan() };


//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}

var numbers = new List<int> { 1, 2, 3, -4, 5, 6, 7, -8, 9, 10 , 44, -32, 56, -19};
bool shouldOnlyAddPositiveNumbers = false;   

var calculator = shouldOnlyAddPositiveNumbers ? new AddOnlyPositiveNumbers() : new NumbersSumCalculator();

var sum = calculator.CalculateSum(numbers);

int seasonNumber = 3;

Season winter = (Season)seasonNumber; // explicit casting

Console.WriteLine($"Sum of the numbers is {sum}");


Console.ReadKey();


public enum Season
{
   Spring,
   Summer,
   Autumn,
   Winter
}

public abstract class Ingredients
{

    public int PriceIfExtraToppings { get; }
    public Ingredients(int extraToppingPrice)
    {
        PriceIfExtraToppings = extraToppingPrice;
    }

    public override string ToString() => Name;

    // virtual allows the derived class to override the property
    public virtual string Name { get; } = "Initial ingredients";

    public string Describe() => $"{Name} of the Recipe..";

    public abstract void Prepare();
}


public abstract class Cheese : Ingredients
{
    public Cheese(int extraToppingPrice) : base(extraToppingPrice)
    {
    }

    public override string Name { get; } = "Cheese";
}


public class Chedder : Ingredients
{

    public int AddExtratChedder { get; }
    public Chedder(int extraToppingPrice, int addExtraChedder) : base(extraToppingPrice)
    {
        AddExtratChedder = addExtraChedder;
    }

    public override string Name { get; } = "Chedder Cheese";

    public override void Prepare()
        => Console.WriteLine($"Preparing {Name} with {AddExtratChedder} extra chedder");
}


public class Mozzarella : Ingredients
{
    public Mozzarella(int extraToppingPrice) : base(extraToppingPrice)
    {
    }

    public override string Name { get; } = "Mozzarella Cheese";

    public override void Prepare()
        => Console.WriteLine($"Preparing {Name}");
}

public class Parmesan : Ingredients
{
    public Parmesan(int extraToppingPrice) : base(extraToppingPrice)
    {
    }

    public override string Name { get; } = "Parmesan Cheese";

    public override void Prepare()
        => Console.WriteLine($"Preparing {Name}");
}

public class Pizza
{
    private List<Ingredients> _ingredients = [];

    public void AddIngredients(Ingredients ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public override string ToString()
    {
        return $"This is a pizza with {string.Join(", ", _ingredients)}";
    }
}


public class NumbersSumCalculator
{
    public int CalculateSum(List<int> listOfNumbers)
    {
       int sum = 0;

        foreach (var number in listOfNumbers)
        {

            if(ShouldAllowOnlyPositiveNumbers(number))
            {
                sum += number;
            }

            sum += number;
        }
        return sum;
    }

    protected virtual bool ShouldAllowOnlyPositiveNumbers(int number) => false;
}


public class AddOnlyPositiveNumbers : NumbersSumCalculator
{
    protected override bool ShouldAllowOnlyPositiveNumbers(int number) => number > 0;
}

public class Exercise
{
    public List<int> GetCountsOfAnimalsLegs()
    {
        var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

        var result = new List<int>();
        foreach (var animal in animals)
        {
            result.Add(animal.NumberOfLegs);
        }
        return result;
    }
}
public class Animal
{
    public virtual int NumberOfLegs { get; } = 4;
}

public class Lion : Animal
{
}

public class Tiger : Animal
{
}

public class Duck : Animal
{
    public override int NumberOfLegs { get; } = 2;
}

public class Spider : Animal
{
    public override int NumberOfLegs { get; } = 8;
}


public class Processor
{
    public List<string> ProcessAll(List<string> words)
    {
        var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

        List<string> result = words;
        foreach (var stringsProcessor in stringsProcessors)
        {
            result = stringsProcessor.Process(result);
        }
        return result;
    }
}

public class StringsProcessor
{
    public List<string> Process(List<string> words)
    {
        var result = new List<string>();
        foreach (var word in words)
        {
            result.Add(ProcessWord(word));
        }
        return result;
    }

    protected virtual string ProcessWord(string word)
    {
        return word;
    }
}

public class StringsTrimmingProcessor : StringsProcessor
{
    protected override string ProcessWord(string word)
    {
        return word.Substring(0, word.Length / 2);
    }
}

public class StringsUppercaseProcessor : StringsProcessor
{
    protected override string ProcessWord(string word)
    {
        return word.ToUpper();
    }
}