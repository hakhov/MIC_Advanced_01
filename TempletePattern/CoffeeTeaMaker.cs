abstract class CoffeeTeaMaker
{
    public void RecipeMaker()
    {
        BoilWater();
        AddInCup();
        GetSpoon();
        AggSugger();
        Adding();
        CoffeeTeaSticker();
    }
    private void AddInCup()
    {
        Console.WriteLine("Adding in the cup!");
    }

    private void BoilWater()
    {
        Console.WriteLine("Boilwing water!");
    }

    private void GetSpoon()
    {
        Console.WriteLine("Getting spoon!");
    }

    private void AggSugger()
    {
        Console.WriteLine("Adding sugger!");
    }

    public abstract void Adding();
    public abstract void CoffeeTeaSticker();
}
