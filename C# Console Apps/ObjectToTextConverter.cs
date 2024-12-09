public class ObjectToTextConverter
{
    public string Convert(object obj)
    {
        Type type = obj.GetType(); // Reflection
        var properties = type
            .GetProperties()
            .Where(p => p.Name != "EqualityContract");

        return String.Join(", ", properties.Select(
            property => $"{property.Name} is {property.GetValue(obj)}"));
    }
}
