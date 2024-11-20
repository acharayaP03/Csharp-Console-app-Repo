

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


    public abstract class Ingredients
    { 
        public abstract int Id {  get; }

        public abstract string Name { get; }

        public virtual string PreparationInstructions =>
            "Add to other ingredients.";
    }

    public abstract class Flour : Ingredients
    {
        public override string PreparationInstructions =>
            $"Seive. {base.PreparationInstructions}";
    }

    public class WheatFlour : Flour
    {
        public override int Id => 1;

        public override string Name => "Wheat Flour";

    }

    public class SpeltFlour : Flour
    {
        public override int Id => 2;

        public override string Name => "Spelt Flour";
    }

    public class Butter : Ingredients
    {
        public override int Id => 3;

        public override string Name => "Butter";

        public override string PreparationInstructions =>
            $"Melt on low heat. {base.PreparationInstructions}.";
    }

    public class  Chocolate : Ingredients
    {
        public override int Id => 4;

        public override string Name => "Chocolate";

        public override string PreparationInstructions =>
            $"Melt in a water bath. {base.PreparationInstructions}";
    }

    public class Sugar : Ingredients
    {
        public override int Id => 5;

        public override string Name => "Sugar";
    }

    public abstract class Spice : Ingredients
    {
        public override string PreparationInstructions =>
            $"Take half a teaspoon. {base.PreparationInstructions}";
    }

    public class Cardamom : Spice
    {
        public override int Id => 6;

        public override string Name => "Cardamom";


    }

    public class Cinnamon : Spice
    {
        public override int Id => 7;

        public override string Name => "Cinnamon";

    }

    public class CocoaPowder : Ingredients
    {
        public override int Id => 8;

        public override string Name => "Cocoa Powder";
    }
}
