using MyReadOnly;

Console.WriteLine(GC.GetTotalMemory(true));
Console.WriteLine(GC.GetTotalMemory(true));
Console.WriteLine(GC.GetTotalMemory(true));

MyClass ob = new();
Console.WriteLine(  ob.number1);

Console.WriteLine(GC.GetTotalMemory(true));
Console.WriteLine(GC.GetTotalMemory(true));