
using System.Text;

string path = @"D:\Test\1.dat";
FileInfo fileInfo = new FileInfo(path);

Console.WriteLine("Please insert text for rrecord into file:");
string text = Console.ReadLine();

using (FileStream fileStreamForWrite = new FileStream(path, FileMode.OpenOrCreate))
{

  byte[] bufferForWrite = Encoding.Default.GetBytes(text);
  fileStreamForWrite.Write(bufferForWrite, 0, bufferForWrite.Length);
  Console.WriteLine("Text created:");
}

using (FileStream fileStreamForRead = File.OpenRead(path))
{
  byte[] bufferForRead = new byte[fileStreamForRead.Length];

  fileStreamForRead.Read(bufferForRead, 0, bufferForRead.Length);
  string textFromFileStream = Encoding.Default.GetString(bufferForRead);
  Console.WriteLine($"Your tex info is here!\n{textFromFileStream}");
}

