using System.IO.Compression;

string sourcePath = @"D:\1.pdf";
string sourceAfterCompressed = @"D:\1.zip";
string newSource = @"D:\1_new.pdf";

MyCompress(sourcePath, sourceAfterCompressed);
DeCOmpressed(sourceAfterCompressed, newSource);

static void MyCompress(string sourcePath, string sourceAfterCompressed)
{
  using (var sourceStream = new FileStream(sourcePath, FileMode.OpenOrCreate))
  {
    using (var compressedFileStream = File.Create(sourceAfterCompressed))
    {
      using (var compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
      {
        sourceStream.CopyTo(compressionStream);
      }
    }
  }
}

static void DeCOmpressed(string sourceAfterCompressed, string newSource)
{
  using (var sourceStream = new FileStream(sourceAfterCompressed, FileMode.OpenOrCreate))
  {
    using (var deccompressedFileStream = File.Create(newSource))
    {
      using (var decompressionStream = new GZipStream(deccompressedFileStream, CompressionMode.Decompress))
      {
        decompressionStream.CopyTo(deccompressedFileStream);
      }
    }
  }
}