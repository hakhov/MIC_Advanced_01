
Console.WriteLine("Hello car SHOPE");
Console.WriteLine("IN this shop you can fide 3 perfect cars:");

Manager mg = new Manager();

List<Car> bmw = mg.Initialize();
List<Car> mercedes = mg.Initialize();
List<Car> audi = mg.Initialize();

Console.WriteLine("|---------------------------------------------|");
Console.WriteLine("\t" + "BMW      |" + "\t" + "Press 1 to select me:");
Console.WriteLine("\t" + "MERCEDES |" + "\t" + "Press 2 to select me:");
Console.WriteLine("\t" + "AUDI     |" + "\t" + "Press 3 to select me:");

Console.WriteLine("|---------------------------------------------|");

Console.WriteLine("\n" + "To select Car name please enter each number they are using");

Console.Write("Your use care is = ");
int number = int.Parse(Console.ReadLine());

List<Car> arr = new List<Car>();

Console.WriteLine();

switch (number)
{
    case 1:

        foreach (var item in bmw)
        {
            Console.WriteLine(
                $"{item.ID}\t" +
                $"{item.CarName}\t" +
                $"{item.ModelName}\t" +
                $"{item.PowerOfCar}\t" +
                $"{item.Color}" +
                $"- ${item.Cost}");
            arr.Add(item);
        }
        break;
    case 2:
        foreach (var item in mercedes)
        {
            Console.WriteLine(
                $"{item.ID}\t" +
                $"{item.CarName}\t" +
                $"{item.ModelName}\t" +
                $"{item.PowerOfCar}\t" +
                $"{item.Color}" +
                $"- ${item.Cost}");
            arr.Add(item);
        }
        break;
    case 3:
        foreach (var item in audi)
        {
            Console.WriteLine(
                $"{item.ID}\t" +
                $"{item.CarName}\t" +
                $"{item.ModelName}\t" +
                $"{item.PowerOfCar}\t" +
                $"{item.Color}" +
                $"- ${item.Cost}");
            arr.Add(item);
        }
        break;
    default:
        break;
}
Console.WriteLine();

Console.Write("Please insert your maximum price ($) = ");
int cost = int.Parse(Console.ReadLine());
Console.WriteLine();

mg.PurchaseSysytem(arr, cost);

Console.WriteLine($"Sorry but your bagate ${cost} is smaller then car price:\n Thank you for your order but " +
    "We need to cansole Application!");