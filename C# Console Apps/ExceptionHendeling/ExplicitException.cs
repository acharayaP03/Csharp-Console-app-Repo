

namespace C__Console_Apps.ExceptionHendeling;

public static class ExplicitException
{
    public static int ParseStringToInt(string input)
    {
        try
        {
            return int.Parse(input);
        }
        catch
        {
            Console.WriteLine($"parsing filed at {nameof(ParseStringToInt)} method.");
            return 0;
        }
    }

    // throwing explicit expception

    public static int GetFirstElement(IEnumerable<int> numbers)
    {
        foreach (int number in numbers)
        {
            return number;
        }
        // if user is using this method and passes empty collection to this method then will get this exception.
        // throw new Exception("The collection cannot be empty"); // general exception
        throw new InvalidOperationException("The collection cannot be empty."); // builtin type exception
    }

    public static bool IsFirstElementPositive(IEnumerable<int> numbers)
    {
        try
        {
            var firstElement = GetFirstElement(numbers);
            return firstElement == 0;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("The collection is empty");
            return true;
        }
        catch (NullReferenceException ex)
        {
            throw new ArgumentNullException("The collection is null.", ex);
        }
    }

    public static int GetMaxValue(List<int> numbers)
    {
        try
        {
            return numbers.Max();
        }
        catch (ArgumentNullException ex)
        {
            throw new ArgumentNullException("The numbers list cannot be null.", ex);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("The numbers list cannot be empty.");
            throw; // rethorows exception and preserves the stack trace.
        }
    }
}


