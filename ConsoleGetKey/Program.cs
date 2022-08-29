using ConsoleGetKey;

ConsoleKey key;

do
{
    key = Console.ReadKey().Key;
    int keyCode = (int)key;
    Console.WriteLine();
    Console.WriteLine($"\tEnum {key}\t KeyCode is {keyCode}");

    ClassKey classKey = new(key);
    classKey.GetInfo();

} while (key != ConsoleKey.Escape);
