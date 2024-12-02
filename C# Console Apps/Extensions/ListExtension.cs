static class ListExtension
{
    public static void AddToFront<T>(this List<T> list, T value)
    {
        list.Insert(0, value);
    }

    //public static List<int> ConvertTo(this List<decimal> list)
    //{
    //    var result = new List<int>();
    //    foreach(var item in list)
    //    {
    //        result.Add((int)item);
    //    }

    //    return result;
    //}

    // convert to generic type
    public static List<Ttarget> ConvertTo<Ttarget, Tsource>(this List<Tsource> source)
    {
        var result = new List<Ttarget>();
        foreach(var item in source)
        {
            if (item is null)
                throw new InvalidOperationException($"Cannot convert {nameof(Tsource)} to a {nameof(Ttarget)} type.");
            // using convert type to resolve run time issue
            Ttarget convertedTargetType = (Ttarget)Convert.ChangeType(item, typeof(Ttarget));
            result.Add(convertedTargetType);
        }

        return result;
    }
}
