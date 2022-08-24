using _04_withNew;

ClassA classA = new ();
ClassB classB = new ();

ClassB classB1 = new ClassA().FunctionA ();

int x = new ClassA().FunctionA().FunctionB1 ();
Console.WriteLine(x);

new ClassA().FunctionA ().FunctionB2();

//new ClassA().FunctionA() == new ClassB()