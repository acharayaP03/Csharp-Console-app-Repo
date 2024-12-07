
namespace C__Console_Apps.Constraint;

public class CreateCollection
{
    public IEnumerable<T> CreateCollectionOfRandomLength<T>(
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
    public void PrintInOrder<T>(T first, T second) where T : IComparable<T>
    {

    }
}