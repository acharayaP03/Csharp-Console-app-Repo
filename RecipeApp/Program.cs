

using RecipeApp;
using RecipeApp.Recipes;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("************* Welcome to RecipeApp *************");
Console.WriteLine("************* Create your recipe and save it *************");

var recipeApp = new CookBookRecipes(
        new RecipesRepository(),
        new RecipesConsoleUserInteractions()
    );
recipeApp.Run();


Console.WriteLine("Enter the recipe name: ");

Console.ReadKey();



public interface IRecipesRepository
{
       List<Recipe> GetAllRecipes(string filePath);

}

public class RecipesRepository: IRecipesRepository
{

    public List<Recipe> GetAllRecipes(string filePath)
    {
        throw new NotImplementedException();
    }
}
