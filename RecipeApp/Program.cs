

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("************* Welcome to RecipeApp *************");
Console.WriteLine("************* Create your recipe and save it *************");

var recipeApp = new RecipeApp(
        new RecipesRepository(),
        new RecipesConsoleUserInteractions()
    );
recipeApp.Run();


Console.WriteLine("Enter the recipe name: ");

Console.ReadKey();

public class RecipeApp
{
    private readonly IRecipesRepository _recipesRepository;

    private readonly IRecipesUserInteractions _recipesUserInteractions;
    public RecipeApp(IRecipesRepository recipesRepository, IRecipesUserInteractions recipesUserInteractions)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteractions = recipesUserInteractions;
    }



    public void Run()
    {
        string filePath = "recipes.txt";
        var allRecipes = _recipesRepository.GetAllRecipes(filePath);

        _recipesUserInteractions.PromptToCreateRecipe();

        var ingredients = _recipesUserInteractions.ReadIngredientsFromUser();

        if(ingredients.Count > 0)
        {
            Recipe recipies = new (ingredients);
            allRecipes.Add(recipies);
            _recipesUserInteractions.Write(filePath, allRecipes);
            _recipesUserInteractions.ShowMessage("Recipe has been saved");

            
        }
        else
        {
            _recipesUserInteractions.ShowMessage("No ingredients have been selected" 
                + "Recipe will not be saved");
        }

        _recipesUserInteractions.Exit();
    }
}

internal class Recipe
{
    private object ingredients;

    public Recipe(object ingredients)
    {
        this.ingredients = ingredients;
    }
}

public interface IRecipesRepository
{
       string GetAllRecipes(string filePath);

}

public class RecipesRepository: IRecipesRepository
{

    public string GetAllRecipes(string filePath)
    {
        return "first recipe";;
    }
}

public interface IRecipesUserInteractions
{
    void ShowMessage(string message);
    void Exit();
}

public class RecipesConsoleUserInteractions : IRecipesUserInteractions
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void Exit()
    {
        Console.WriteLine("Press any key to exit application.");
        Console.ReadKey();
    }
}