string? txt = "Hello how are you!";

Console.WriteLine(txt);

//NewStringImplementation newString = delegate (string txt)
//    {
//        return txt.Replace(' ', '+');
//    };
NewStringImplementation newString = (string txt) => txt.Replace(' ', '+');

Console.WriteLine(newString(txt));
delegate string NewStringImplementation(string value);

