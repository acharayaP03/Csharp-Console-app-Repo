namespace C__Console_Apps.InheritanceInPractice;
public class Chedder : Ingredients
{

    public int AddExtratChedder { get; }
    public Chedder(int extraToppingPrice, int addExtraChedder) : base(extraToppingPrice)
    {
        AddExtratChedder = addExtraChedder;
    }

    public override string Name { get; } = "Chedder Cheese";

    public override void Prepare()
        => Console.WriteLine($"Preparing {Name} with {AddExtratChedder} extra chedder");
}
