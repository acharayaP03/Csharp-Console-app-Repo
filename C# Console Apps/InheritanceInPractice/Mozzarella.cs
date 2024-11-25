namespace C__Console_Apps.InheritanceInPractice;

public class Mozzarella : Ingredients
{
    public Mozzarella(int extraToppingPrice) : base(extraToppingPrice)
    {
    }

    public override string Name { get; } = "Mozzarella Cheese";

    public override void Prepare()
        => Console.WriteLine($"Preparing {Name}");
}