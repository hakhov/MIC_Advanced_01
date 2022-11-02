Display("Hello GoodMorning", delegate(string txt)
{
    Console.WriteLine(txt);
});



static void Display(string txt, MessageShow messageShow)
{
    messageShow.Invoke(txt);
}

public delegate void MessageShow(string txt);
