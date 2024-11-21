using RecipeApp.Recipes;
using RecipeApp.UserRecipeConsoleInteraction;

namespace RecipeApp;

public class CookBookRecipes
{
    private readonly IRecipesRepository _recipesRepository;

    private readonly IRecipesUserInteractions _recipesUserInteractions;
    public CookBookRecipes(IRecipesRepository recipesRepository, IRecipesUserInteractions recipesUserInteractions)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteractions = recipesUserInteractions;
    }



    public void Run(string filePath)
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteractions.PrintExistingRecipes(allRecipes);

        _recipesUserInteractions.PromptToCreateRecipe();

        var ingredients = _recipesUserInteractions.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            Recipe recipie = new(ingredients);
            allRecipes.Add(recipie);
            //_recipesUserInteractions.Write(filePath, allRecipes);
            _recipesUserInteractions.ShowMessage("Recipe has been saved");
            _recipesUserInteractions.ShowMessage(recipie.ToString());
        }
        else
        {
            _recipesUserInteractions.ShowMessage("No ingredients have been selected"
                + "Recipe will not be saved");
        }

        _recipesUserInteractions.Exit();
    }
}