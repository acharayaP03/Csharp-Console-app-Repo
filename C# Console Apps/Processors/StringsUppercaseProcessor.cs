
//Chedder chedder = new();
//var ingredients = new List<Ingredients> { chedder, new Mozzarella(), new Parmesan() };


//foreach (var ingredient in ingredients)
//{
//    Console.WriteLine(ingredient.Name);
//}















public class StringsUppercaseProcessor : StringsProcessor
{
    protected override string ProcessWord(string word)
    {
        return word.ToUpper();
    }
}