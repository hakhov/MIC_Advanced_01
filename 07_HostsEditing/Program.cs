using System.Text;

string hostPath = @"C:\Windows\System32\drivers\etc";

string newPath = @"D:\hosts.file";
FileInfo fileNew = new FileInfo(@"D:\hosts.file");
FileStream fileStream = fileNew.Create();
fileStream.Close();

try
{
  using (var streamWriter = new StreamWriter(
  newPath, false, Encoding.Default))
  {
    string blockText = $"     127.0.0.1 facebook.com{Environment.NewLine}   127.0.0.1  www.facebook.com";
    string oldText = File.ReadAllText(hostPath + "\\hosts");

    streamWriter.WriteLine(oldText + Environment.NewLine + blockText);
  }
}
catch (Exception ex)
{
  Console.WriteLine(ex.Message);
}

File.Delete(hostPath + @"\hosts");
File.Move(newPath, hostPath + "\\hosts");
