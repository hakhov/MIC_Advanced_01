//public delegate void Notify();
public class SomeProcces
{
    public event EventHandler? ProcessCompleted;

    public void SratProcess()
    {
        Console.WriteLine("Process started!!");

        //some code... 
        //
        //

        OnProcessCompleted(EventArgs.Empty);
    }

    protected virtual void OnProcessCompleted(EventArgs? e)
    {
        if (e is not null)
            ProcessCompleted?.Invoke(this, e);
    }


}