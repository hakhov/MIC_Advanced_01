
string path = @"D:\1.txt";

FileInfo fileInfo = new FileInfo(path);

if (fileInfo.Exists)
{
    Console.WriteLine($"Name: - {fileInfo.Name}");
    Console.WriteLine($"FullName: - {fileInfo.FullName}");
    Console.WriteLine($"CreationTime: - {fileInfo.CreationTime}");
    Console.WriteLine($"Length: - {fileInfo.Length}");
}

string txt = "Hello this is our first line.\r\n" +
    "This is my second line\r\n" +
    "This is third line:";

try
{
    File.AppendAllLines(path, txt.Split(Environment.NewLine.ToCharArray()).ToList<string>());
    Console.WriteLine($"Record on the {path} is successed");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
