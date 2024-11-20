

namespace RecipeApp.Recipes
{
    public class Recipe
    {
        public IEnumerable<Ingredients> Ingredients { get; }

        public Recipe(IEnumerable<Ingredients> ingredients)
        {
            Ingredients = ingredients;
        }
    }
}
