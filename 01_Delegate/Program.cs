//MyClass.MyMethod();
//MyClass myClass = new MyClass();

//MyDelegate myDelegate = new MyDelegate(myClass.MyMethod);
//myDelegate.Invoke();
//myDelegate();

MyClassDeledateWithParametrs ob = new MyClassDeledateWithParametrs();

MyDelegateWithParametr withParametrsDelegate = new MyDelegateWithParametr(ob.MyMethod);
string txt = withParametrsDelegate.Invoke("MIC class");
Console.WriteLine(txt);
Console.WriteLine(withParametrsDelegate("HEllo"));