public delegate void DelegateForEvent();
public class MyClass
{
    public event DelegateForEvent? MyEvent = null;

    public void InvokeEvent()
    {
        MyEvent?.Invoke();
    }
}