int number = new Random().Next(5);

string result = number switch
{
    0 => "Zero",
    1 => "One",
    _ => "any"
};

Console.WriteLine($"{result} - {number}");