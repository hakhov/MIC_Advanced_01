public class Time
{
    public int H { get; set; }
    public int M { get; set; }
    public int S { get; set; }

    public static implicit operator Time(Secund secund)
    {
        int h = secund.Senunds / 3600;
        int m = secund.Senunds / 60;
        int s = secund.Senunds;
        return new Time { H = h, M = m, S = s };
    }

    public static explicit operator Secund(Time time)
    {
        return new Secund { Senunds = time.H * 3600 + time.M * 60 + time.S };
    }
}