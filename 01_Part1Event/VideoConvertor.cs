
//public delegate void VideoConvertorEventHandler(object s, EventArgs args);
public class VideoConvertor
{
    public event EventHandler<VideoEventArgs>? VideoConvertedEvent;
    public void Convertor(Video? video)
    {
        Console.WriteLine("Converting process ....");
        Thread.Sleep(5000);

        OnVideoConverted(video);
    }

    protected virtual void OnVideoConverted(Video? video)
    {
        if (VideoConvertedEvent is not null)
            VideoConvertedEvent(this, new VideoEventArgs() { Video = video });
    }
}
