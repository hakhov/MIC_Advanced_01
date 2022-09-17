 
    internal class Hibrid : IHumon, ICar
    {
        int IHumon.Move(int distance)
        {
            return distance / 1000;
        }

        int ICar.Move(int distance)
        {
            return distance / 100000;
        }
    } 