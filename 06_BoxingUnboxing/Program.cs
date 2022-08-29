int a = 5;
int b = a;

int c = 6;
object d = c;
a = (int)d + 5;

double x = 5;
decimal y = 5;
Console.WriteLine((decimal)x+y);

int x1 = int.MaxValue;
long y1 = long.MaxValue;
long x2 = y1 + x1;

Console.WriteLine(x1+y1);

