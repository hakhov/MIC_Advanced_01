var student = GetTupleMethod();

static void SetTupleMethod(Tuple<string, string, int> tupleStudent)
{
    Console.WriteLine($"Student name is {tupleStudent.Item1}, age is {tupleStudent.Item3}");
}

static Tuple<string, string, int> GetTupleMethod()
{
    var tupleStudent = new Tuple<string, string, int>("Tom", "Smith", 50);
    return tupleStudent;
}

// (_,10)
//Tuple fild name
