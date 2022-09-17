MyClass myClass = new MyClass();
//myClass.MethodInterface();

IInterface1 myInterface1 = myClass as IInterface1;
myInterface1.MethodInterface();

IInterface2 myInterface2 = myClass as IInterface2;
myInterface2.MethodInterface();