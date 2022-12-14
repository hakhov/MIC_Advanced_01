string path = @"D:\1.txt";

try
{
	using (var streamReader = new StreamReader(path))
	{
		//Console.WriteLine(streamReader.ReadToEnd());
		Console.WriteLine(await streamReader.ReadToEndAsync());
    Console.ReadKey();
  }
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

