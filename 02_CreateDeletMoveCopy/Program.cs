
string path = @"D:\Test";
////if (!Directory.Exists(path)) return;
//Directory.CreateDirectory(path);
////Directory.Delete(path);

//Console.WriteLine(Directory.GetParent(path));
//Console.WriteLine(Directory.GetDirectoryRoot(path));
//Console.WriteLine(Directory.GetCreationTime(path));
//Console.WriteLine(Directory.GetLastAccessTime(path));
//Console.WriteLine(Directory.GetLastWriteTime(path));

string subPath = @"unit\check";

DirectoryInfo dirInfo = new DirectoryInfo(path);
if (!dirInfo.Exists)
{
    dirInfo.Create();
    dirInfo.CreateSubdirectory(subPath);
}

Console.WriteLine("Directorys created:");

try
{
    dirInfo.Delete(false);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

