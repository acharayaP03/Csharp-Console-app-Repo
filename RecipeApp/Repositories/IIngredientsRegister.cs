using RecipeApp.Recipes.Ingredients;

namespace RecipeApp.Repositories;

public interface IIngredientsRegister
{
    IEnumerable<Ingredient> All { get; }

    Ingredient GetById(int id);
}
