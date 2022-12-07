
int counter = 0;

ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(MyMethod);
Thread thread = new Thread(parameterizedThreadStart);
thread.Start(counter);

Thread.Sleep(1400);
Console.WriteLine($"counter from MAin= {counter}");
