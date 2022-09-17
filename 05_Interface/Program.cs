MyClass myClass = new MyClass();
myClass.MethodFromTheBase();
myClass.MethodInterface1();
myClass.MethodInterface2();

Console.WriteLine(new String('_', 50));

BClass bClass = myClass as BClass;
bClass.MethodFromTheBase();

IInterface1 interface1 = myClass as IInterface1; //Upcasting
interface1.MethodInterface1();

IInterface2 interface2 = myClass as IInterface2; //Upcasting
interface2.MethodInterface2();
