Hashiv<int> h1 = new Hashiv<int>();
Hashiv<string> h2 = new Hashiv<string>();
h1.ID = 800;
h2.ID = "800";


Transfer<Hashiv<int>, string> ob = new Transfer<Hashiv<int>, string>()
{
    FromHashiv = h1,
    ToHashiv = h1,
    JobType = "BankingTransfer from ... to "
};

Transfer<int, int> ob2 = new Transfer<int, int>()
{
    ToHashiv = h1.ID,
    FromHashiv = h1.ID,
    JobType = 10000
};

class Hashiv<T>
{
    public T ID { get; set; }
    public int Sum { get; set; }
}

class Transfer<T,TT>
{
    public T FromHashiv { get; set; }
    public T ToHashiv { get; set; }
    public TT JobType { get; set; }
}