Humon humon = new();
//Car car = new();
humon.GetDrive(new Car());
humon.GetDrive(new LuxCar());
//Car car = new LuxCar();

class Humon
{
    public void GetDrive(Car car)
    {
        car.Drive();
    }
}

class Car
{
    public virtual void Drive()
    {
        Console.WriteLine("I am driving:");
    }
}

class LuxCar:Car
{
    //public new void Drive()
    //{
    //    Console.WriteLine("I am driving Lux Car");
    //}

    public override void Drive()
    {
        base.Drive();
        Console.WriteLine("I am driving Lux Car");
    }
}

class A
{

}

class B:A
{
   
}

class C: B
{

}

