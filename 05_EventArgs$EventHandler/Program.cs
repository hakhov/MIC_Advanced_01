

SomeProcces someProcces = new SomeProcces();

someProcces.ProcessCompleted += ProcessCompletedHandlerMethod;
someProcces.SratProcess();


static void ProcessCompletedHandlerMethod(object? sender, EventArgs? e)
    => Console.WriteLine("Process completed!!!! ");