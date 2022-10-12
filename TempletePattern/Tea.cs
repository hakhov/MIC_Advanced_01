//string txt1 = "ABC";
//string txt2 = "ABc";

//Console.WriteLine(txt1.CompareTo(txt2));
//Console.WriteLine(txt2.CompareTo(txt1));


class Tea : CoffeeTeaMaker
{
    public override void Adding()
    {
        Console.WriteLine("Adding tea");
    }
    public override void CoffeeTeaSticker()
    {
        Console.WriteLine("I am tea sticker");
    }
}
