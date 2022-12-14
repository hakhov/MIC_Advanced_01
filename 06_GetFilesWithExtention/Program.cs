
string path = @"D:\Yandex\YandexDisk\Фотокамера";

DirectoryInfo directoryInfo = new DirectoryInfo(path);
FileInfo[] images = directoryInfo.GetFiles("*.jpg");

Console.WriteLine($"Found {images.Length} *.jpg files!");

foreach (var currentImage in images)
{
  Console.WriteLine($"FileName: {currentImage.Name}");
  Console.WriteLine($"Length: {currentImage.Length/1024}");
  Task.Delay(3).Wait();
}

