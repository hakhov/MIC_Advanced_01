//string txt1 = "ABC";
//string txt2 = "ABc";

//Console.WriteLine(txt1.CompareTo(txt2));
//Console.WriteLine(txt2.CompareTo(txt1));


class Coffee : CoffeeTeaMaker
{
    public override void Adding()
    {
        Console.WriteLine("Adding coffee");
    }

    public override void CoffeeTeaSticker()
    {
        Console.WriteLine("I am coffee sticker");
    }
}
