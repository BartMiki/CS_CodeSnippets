<Query Kind="Program" />

class Program
{
    static void Main(string[] args)
    {
        var v = new Video() { Title = "Video 1" };
        var videoEncoder = new VideoEncoder();
        var mailService = new MailService();
        videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
        var messageService = new MessageService();
        videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
        videoEncoder.Encode(v);
    }
}

public class Video
{
    public string Title { get; set; }
}

public class VideoEncoder
{
    public event EventHandler<VideoEvenArgs> VideoEncoded;

    public void Encode(Video video)
    {
        Console.WriteLine($"Encoding: \"{video.Title}\".");
        Thread.Sleep(500);
        OnVideoEncoded(video);
    }

    protected virtual void OnVideoEncoded(Video video)
    {
        VideoEncoded?.Invoke(this,new VideoEvenArgs(){Video = video});
    }
}

public class MailService
{
    public void OnVideoEncoded(object source, VideoEvenArgs args)
    {
        Console.WriteLine($"{GetType().Name}: sending an e-mail about \"{args.Video.Title}\".");
    }
}

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEvenArgs args)
    {
        Console.WriteLine($"{GetType().Name}: sending an e-mail about \"{args.Video.Title}\".");
    }
}

public class VideoEvenArgs : EventArgs
{
    public Video Video { get; set; }
}
