
using System.Text;

string path = @"D:\1.txt";

if (!File.Exists(path)) return;

using (var fileStream = new FileStream(path, FileMode.OpenOrCreate))
{
  for(long i = fileStream.Length; i>=0;i--)
  {
    fileStream.Seek(i, SeekOrigin.Begin);
    byte[] buffer = new byte[1];

    fileStream.Read(buffer, 0, 1);
    if (Encoding.Default.GetString(buffer,0,1) =="(")
    {
      fileStream.Seek(i, SeekOrigin.Begin);
      fileStream.Write(Encoding.Default.GetBytes("+"), 0, 1);
    }
  }
}