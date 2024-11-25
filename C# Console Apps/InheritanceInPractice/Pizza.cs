namespace C__Console_Apps.InheritanceInPractice;

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