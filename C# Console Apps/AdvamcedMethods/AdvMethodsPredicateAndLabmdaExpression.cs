

namespace C__Console_Apps.AdvamcedMethods;

// predicate always has return type..
// Func<int, DateTime, string, decimal> someFunction; 
// if its a void type then its usually action
// Action<string, string, bool> someAction;

public class AdvMethodsPredicateAndLabmdaExpression
{
    //public bool IsAnyLargerThan10(IEnumerable<int> numbers)
    //{
    //    foreach (int number in numbers) 
    //    {
    //        if( number > 0)
    //        {
    //            return true;
    //        }
    //    }


    //    return false;
    //}

    //public bool IsAnyNumberEven(IEnumerable<int> numbers)
    //{
    //    foreach (int number in numbers)
    //    {
    //        if (number % 2 == 0)
    //        {
    //            return true;
    //        }
    //    }

    //    return false;
    //}


    public static bool IsAny(IEnumerable<int> numbers, Func<int, bool> predicate)
    {

        foreach(int number in numbers)
        {

            if(predicate(number))
            {
                return true;
            }
        }
        return false;
    }

    public static bool IsLargerThan10(int number)
    {
        return number > 10;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}

public class Exercise
{
    public Func<string, int> GetLength = str => str.Length;
    public Func<int> GetRandomNumberBetween1And10 = () => new Random().Next(1, 11);

    //public void TestMethod()
    //{
    //    Func<int, bool> someMethod1 = Method1;
    //    Func<DateTime> someMethod2 = Method2;
    //    Action<string, string> someMethod3 = Method3;
    //}

    //public double Method1(int a, bool b) => 0;
    //public DateTime Method2() => default(DateTime);
    //public void Method3(string a, string b) { }
}


