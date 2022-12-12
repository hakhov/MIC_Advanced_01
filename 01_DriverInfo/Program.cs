//Path, Directory, File, FileSystemInfo, DrirecoryInfo, DriveInfo

using System.IO;
using System.Text;

DriveInfo[] driveInfos = DriveInfo.GetDrives();

foreach (var item in driveInfos)
{
    Console.WriteLine($"Name: {item.Name}");
    Console.WriteLine($"DriveType: {item.DriveType}");
    if (item.IsReady)
    {
        Console.WriteLine($"DriveFormat: {item.DriveFormat}");
        Console.WriteLine($"DriveFormat: {item.DriveFormat}");
        Console.WriteLine($"Total size: {item.TotalSize}");
        Console.WriteLine($"Total free size: {item.TotalFreeSpace}");
    }
    //Console.WriteLine(new string('=',50));


    string dirPath = @item.Name;

    
    if(Directory.Exists(dirPath))
    {
        string[] directorys = Directory.GetDirectories(dirPath);

        foreach (var dir in directorys)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(dir);
        }
    }

    Console.WriteLine(new string('_', 50)); 
    string[] files = Directory.GetFiles(dirPath);

    foreach (var file in files)
    {
        Console.WriteLine(file);
    }
}
