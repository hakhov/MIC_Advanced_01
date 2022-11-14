HDD hDD = new();
Monitor monitor = new();
Computer computer = new(hDD, monitor);

class HDD
{

}
class SSD : HDD
{

}

class Monitor
{

}

class Computer
{
    private HDD? _hDD;
    private Monitor? _monitor;
    //public Computer()
    //{
    //    hDD = new SSD();
    //    monitor= new Monitor(); 
    //}
    public Computer(HDD hDD, Monitor monitor)
    {
        _hDD = hDD;
        _monitor = monitor;
    }
}
