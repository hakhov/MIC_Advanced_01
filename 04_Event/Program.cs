MyClass myClass = new();

myClass.MyEvent += new DelegateForEvent(Handler1);
myClass.MyEvent += new DelegateForEvent(Handler2);
myClass.MyEvent -= Handler2;
myClass.MyEvent += delegate { Console.WriteLine("Event Handler from the Anonymouse Method"); };

myClass.MyEvent -= delegate { Console.WriteLine("Event Handler from the Anonymouse Method"); };
myClass.MyEvent += () => { Console.WriteLine("Like Lambda"); };

myClass.InvokeEvent();

//EventArgs; ;
    EventHandler