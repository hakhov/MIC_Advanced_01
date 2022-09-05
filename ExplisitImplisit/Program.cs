int x = 4;
long y = x;

int z = (int)y;

Secund secund = new();
secund.Senunds = 3600;
Time time = new();
Time time1 = secund;

Console.WriteLine(time1.H);
Console.WriteLine(time1.M);
Console.WriteLine(time1.S);

time.S = 7200;
secund = (Secund)time;
Console.WriteLine(secund.Senunds);

int xx = (int)secund;
Secund secund1 = xx;


