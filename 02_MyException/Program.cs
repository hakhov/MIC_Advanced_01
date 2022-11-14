try
{
    Person person = new Person { Age = 15 };
}
catch (PersonException ex)
{
    Console.Write($"Error: {ex.Message} {ex.Value}");
}
