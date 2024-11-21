using RecipeApp.Recipes;
using RecipeApp.Repositories;
using RecipeApp.Utils;

public class RecipesRepository: IRecipesRepository
{
    private readonly IStringsTextualRepository _stringsTextualRepository;

    private readonly IIngredientsRegister _ingredientsRegister;

    private const string Separator = ",";
    public RecipesRepository(IStringsTextualRepository stringsTextualRepository, IIngredientsRegister ingredientsRegister)
    {
        _stringsTextualRepository = stringsTextualRepository;
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

        List<string> recipesFromFile = _stringsTextualRepository.Read(filePath);

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
        var ingredients = new List<Recipe>();

        foreach(var id in idsFromFile)
        {
            var id = int.Parse(idsFromFile);
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
        _stringsTextualRepository.Write(filePath, recipesAsStrings);
    }
}
