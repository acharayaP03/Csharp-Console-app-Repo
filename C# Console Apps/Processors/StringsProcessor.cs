
//Chedder chedder = new();
//var ingredients = new List<Ingredients> { chedder, new Mozzarella(), new Parmesan() };


//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}















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
