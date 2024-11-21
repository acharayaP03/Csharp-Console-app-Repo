using RecipeApp.Recipes;
using RecipeApp.Recipes.Ingredients;

namespace RecipeApp.UserRecipeConsoleInteraction;

public interface IRecipesConsoleUserInteractions
{
    void ShowMessage(string message);
    void Exit();

    void PromptToCreateRecipe();

    IEnumerable<Ingredient> ReadIngredientsFromUser();

    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
}