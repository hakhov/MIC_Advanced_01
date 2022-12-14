
//MoveTo
string path = @"D:\Test\1.dat";
string newPath = @"D:\MoveTo\1.dat";

//FileInfo fileInfoForMoveTo = new FileInfo(path);

//if (fileInfoForMoveTo.Exists)
//{
//  //fileInfoForMoveTo.MoveTo(newPath);
//  File.Move(path, newPath);
//}


FileInfo fileInfoForCopyTo = new FileInfo(path);

if (fileInfoForCopyTo.Exists)
{
  //fileInfoForCopyTo.CopyTo(newPath, true);
  File.Copy(path, newPath);
}