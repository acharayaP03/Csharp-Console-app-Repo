
//Chedder chedder = new();
//var ingredients = new List<Ingredients> { chedder, new Mozzarella(), new Parmesan() };


//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}















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
