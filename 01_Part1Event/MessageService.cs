
public class MessageService
{
    public void OnMessageSent(object? sender, VideoEventArgs? e)
    {
        Console.WriteLine("MessageService: Sending an sms ...." + e?.Video?.Title);
    }
}