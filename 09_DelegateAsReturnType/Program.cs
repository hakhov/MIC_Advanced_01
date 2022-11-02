DelegateWithTypeofDelegate delegateWithTypeofDelegate= new DelegateWithTypeofDelegate(MethodTypeIsDelegate);
delegateWithTypeofDelegate.Invoke();

DelegateTypeOfVoid delegateTypeOfVoid = MethodTypeIsVoid;
delegateTypeOfVoid.Invoke();

static DelegateTypeOfVoid MethodTypeIsDelegate()
{
    return new DelegateTypeOfVoid(MethodTypeIsVoid);
}

static void MethodTypeIsVoid()
{
    Console.WriteLine("I am method with void Type!");
}

delegate void DelegateTypeOfVoid();

delegate DelegateTypeOfVoid DelegateWithTypeofDelegate();
