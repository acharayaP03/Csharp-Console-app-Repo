

using RecipeApp;
using RecipeApp.Recipes;
using RecipeApp.Recipes.Ingredients;
using RecipeApp.UserRecipeConsoleInteraction;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("************* Welcome to RecipeApp *************");
Console.WriteLine("************* Create your recipe and save it *************");

CookBookRecipes cookBookRecipes = new(
        new RecipesRepository(),
        new RecipesConsoleUserInteractions()
    );
cookBookRecipes.Run("recipe.txt");


Console.WriteLine("Enter the recipe name: ");

Console.ReadKey();

public interface IRecipesRepository
{
       List<Recipe> Read(string filePath);

}

public class RecipesRepository: IRecipesRepository
{

    public List<Recipe> Read(string filePath)
    {
        return new List<Recipe>
        {
            new Recipe( new List<Ingredient>
            {
                new WheatFlour(),new Butter(),new Sugar()
            }),
            new Recipe(new List<Ingredient>
            {
                new CocoaPowder(), new SpeltFlour(),new Cinnamon()
            })
        };
    }
}
