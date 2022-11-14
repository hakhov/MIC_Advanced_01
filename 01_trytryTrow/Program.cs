
try
{
    try
    {
        Console.WriteLine("Please insert string wich lenght should be more than 10");
        string? txt = Console.ReadLine();

        if (txt?.Length < 10)
        {
            throw new IndexOutOfRangeException();
        }
        Console.WriteLine("Try worked!!!!");
    }
    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
        throw new ArgumentException() ;
    }
    catch(ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Catch from work");
    throw;
}

