MyMultyDlegate? multyDlegate = null;
MyClass ob = new MyClass();
MyMultyDlegate multyDlegate1 = new MyMultyDlegate(ob.Method1);
MyMultyDlegate? multyDlegate2 = new MyMultyDlegate(ob.Method2);
MyMultyDlegate? multyDlegate3 = new MyMultyDlegate(ob.Method3);

// multydelegate

multyDlegate -= multyDlegate1 + multyDlegate2 + multyDlegate3;
multyDlegate += ob.Method1;
multyDlegate();

Console.WriteLine("Please select number 1 to 5");
string? choise = Console.ReadLine();

switch (choise)
{
    case "1":
        multyDlegate1();
        break;
    case "2":
        multyDlegate3();
        break;
    case "3":
        MyMultyDlegate? dlegate = multyDlegate - multyDlegate1;
        dlegate?.Invoke();
        break;
}
