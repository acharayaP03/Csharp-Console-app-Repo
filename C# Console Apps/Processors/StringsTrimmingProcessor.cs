
//Chedder chedder = new();
//var ingredients = new List<Ingredients> { chedder, new Mozzarella(), new Parmesan() };


//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}















public class StringsTrimmingProcessor : StringsProcessor
{
    protected override string ProcessWord(string word)
    {
        return word.Substring(0, word.Length / 2);
    }
}
