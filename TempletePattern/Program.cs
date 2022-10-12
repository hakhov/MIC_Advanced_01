//string txt1 = "ABC";
//string txt2 = "ABc";

//Console.WriteLine(txt1.CompareTo(txt2));
//Console.WriteLine(txt2.CompareTo(txt1));

Coffee coffee = new Coffee();
coffee.RecipeMaker();

Tea tea = new();
tea.RecipeMaker();

class Chocolate : CoffeeTeaMaker
{
    public override void Adding()
    {
        Console.WriteLine("Adding chocolate!"); 
    }

    public override void CoffeeTeaSticker()
    {
        Console.WriteLine("Chocolate sticker!");
    }
}
