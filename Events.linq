<Query Kind="Program" />

void Main()
{
	var v = new Video(){Title="Video 1"};
	var ve = new VideoEncoder();
	ve.Encode(v);
}

class Video
{
	public string Title {get;set;}
}

class VideoEncoder
{
	// Define a delegate:
	
	public delegate 
	
	public void Encode(Video video)
	{
		Console.WriteLine($"Encoding: \"{video.Title}\".");
		Thread.Sleep(3000);
	}
}