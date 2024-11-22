using RecipeApp.Recipes;
using RecipeApp.Recipes.Ingredients;
using RecipeApp.Repositories;
using RecipeApp.Utils;

public class RecipesRepository: IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;

    private readonly IIngredientsRegister _ingredientsRegister;

    private const string Separator = ",";
    public RecipesRepository(IStringsRepository stringsRepository, IIngredientsRegister ingredientsRegister)
    {
        _stringsRepository = stringsRepository;
        _ingredientsRegister = ingredientsRegister;
    }

    public List<Recipe> Read(string filePath)
    {
        //return new List<Recipe>
        //{
        //    new Recipe( new List<Ingredient>
        //    {
        //        new WheatFlour(),new Butter(),new Sugar()
        //    }),
        //    new Recipe(new List<Ingredient>
        //    {
        //        new CocoaPowder(), new SpeltFlour(),new Cinnamon()
        //    })
        //};

        List<string> recipesFromFile = _stringsRepository.Read(filePath);

        var recipes = new List<Recipe>();
        foreach(var recipeFromFileRead in recipesFromFile)
        {
            var recipe = ReadFromString(recipeFromFileRead);
            recipes.Add(recipe);
        }

        return recipes;
    }

    private Recipe ReadFromString(string recipeFromFileRead)
    {
        var idsFromFile = recipeFromFileRead.Split(Separator);
        var ingredients = new List<Ingredient>();

        foreach(var idFromFile in idsFromFile)
        {
            var id = int.Parse(idFromFile);
            var ingredient = _ingredientsRegister.GetById(id);

            ingredients.Add(ingredient);
        }

        return new Recipe(ingredients);
    }

    public void Write(string filePath, List<Recipe> allRecies)
    {

        var recipesAsStrings = new List<string>();
        foreach (var recipe in allRecies)
        {
            var allIds = new List<int>();
            foreach(var ingredient in recipe.Ingredients)
            {
                allIds.Add(ingredient.Id);
            }
            recipesAsStrings.Add(string.Join(Separator, allIds));
        }
        _stringsRepository.Write(filePath, recipesAsStrings);
    }
}
