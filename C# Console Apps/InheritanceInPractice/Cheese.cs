
using C__Console_Apps.InheritanceInPractice;

public abstract class Cheese : Ingredients
{
    public Cheese(int extraToppingPrice) : base(extraToppingPrice)
    {
    }

    public override string Name { get; } = "Cheese";
}
