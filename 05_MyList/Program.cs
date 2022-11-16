MyList<int> ob = new MyList<int>();
Console.WriteLine(ob.Size);

ob.Add(1);
ob.Add(2);
ob.Add(3);
Console.WriteLine(ob.GetAtElement(2));

ob.InsertAtElement(2, -10);
Console.WriteLine(ob.GetAtElement(2));

Console.WriteLine(ob.Size);
