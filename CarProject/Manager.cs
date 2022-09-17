
    public class Manager
    {
        internal List<Car> Initialize()
        {
            Random rnd = new Random();

            List<Car> arr = new List<Car>();
            int count = rnd.Next(2, 5);

            for (int i = 0; i < count; i++)
            {
                arr.Add(
                    new Car()
                    {
                        ID = Guid.NewGuid(),
                        CarName = "Car" + i,
                        ModelName = (ModelName)(rnd.Next(0, 3)),
                        Color = (ConsoleColor)(rnd.Next()),
                        PowerOfCar = 10 * i + 200,
                        Cost = 100 * rnd.Next(1, 6)
                    }
                    ); ;
            }
            return arr;
        }

        internal int GetCostSum(List<Car> arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item.Cost;
            }
            return sum;
        }
        internal int GetCostMin(List<Car> arr)
        {
            int min = int.MaxValue;

            foreach (var item in arr)
            {
                if (min > item.Cost)
                {
                    min = item.Cost;
                }
            }
            return min;
        }

        internal void NextOrderInfo(List<Car> arr, int cost)
        {
            Console.WriteLine($"|----------------you have a ${cost} for order---------------------|");

            foreach (var item in arr)
            {
                if (cost >= item.Cost)
                {
                    Console.WriteLine(
                        $"{arr.IndexOf(item)}\t" +
                        $"{item.CarName}\t" +
                        $"{item.ModelName}\t" +
                        $"{item.PowerOfCar}\t" +
                        $"{item.Color}" +
                        $"- ${item.Cost}");
                }
            }
        }

        internal void PurchaseSysytem(List<Car> arr, int cost)
        {
            while (cost >= GetCostMin(arr))
            {
                Console.WriteLine("\tIn this price you can order only these models:\n");

               NextOrderInfo(arr, cost);

                Console.Write("Please select wich model do you need:\n Selected models is =");

                int id = int.Parse(Console.ReadLine());

                if (arr[id].Cost < cost)
                {
                    Console.WriteLine(new string('♦', 70));
                    Console.WriteLine($"Congratulations you ardered a new Care:");

                    Console.WriteLine(
                $"{arr[id].CarName}\t" +
                $"{arr[id].ModelName}\t" +
                $"{arr[id].PowerOfCar}\t" +
                $"{arr[id].Color}" +
                $"- ${arr[id].Cost}"
                                     );
                    Console.WriteLine(new string('♦', 70));
                }

                cost -= arr[id].Cost;
                arr.RemoveAt(id);
            }
        }
    }


