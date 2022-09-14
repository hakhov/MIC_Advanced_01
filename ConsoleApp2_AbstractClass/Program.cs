Shape Shape = new Triangle(20);
Shape[] shapes = { new Triangle(20), new Square() };
abstract class Shape
{
    private int hight;
    public Shape(int hight)
    {
        this.hight = hight;
    }

    //public Shape()
    //{

    //}
    public abstract void GetSurface();

    public virtual void DisplayInfo()
    {
        Console.WriteLine("HGello");
    }
}

class Triangle : Shape
{
    public Triangle(int hight) : base(hight)
    {
    }

    public override void GetSurface()
    {
        throw new NotImplementedException();
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo(); 
    }
}

class Square:Shape
{

}