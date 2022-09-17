
using _03_Interface;

MyClass myClass1 = new MyClass();

myClass1.MethodInterface1();
myClass1.MethodInterface2();

IInterface1 interface1 = new MyClass();
interface1.MethodInterface1();

IInterface2 interface2 = new MyClass();
interface2.MethodInterface2();