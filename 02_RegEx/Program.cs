// @ - հրամանի համար
// \b կիրառվում է pattern - ը տեքստի մեջ space- երից առանձին բառրերում սկզբից և վերջից։
// \S ցանկացած սիմվոլ բացի space - Ից
// \s - ցանկացած պռոբել 
// * - ցանկացծ սիմվոլի
// \S*
//? 

// [ ] - [1-9][a-z] Ell[o|O]
// \d
// \D
// \w
// ^

using System.Text.RegularExpressions;

string txt = "Hello?x, My name is ellom, and like nelloe bit yello k  e";
//string pattern = @"ello\b";
//string pattern = @"\bello";
//string pattern = @"\Sello";
//string pattern = @"\sello";
//Console.WriteLine(txt.Length);
//string pattern = @"\S*e\b";
//string pattern = @"\bn*e\b"; // www.google.com
//string pattern = @"Hellon?x";
//Console.WriteLine(Regex.IsMatch("kob",@"H?akob"));

//MatchCollection matchCollection = Regex.Matches(txt, pattern);

//foreach (Match match in matchCollection)
//{
//    //Console.WriteLine(match.Value);
//    Console.WriteLine(match.Index);
//    //Console.WriteLine(match.Name);
//}
Console.WriteLine(Regex.IsMatch("T his is MIC class", @"[T|t]\S"));
Console.WriteLine(Regex.Match("T his is MIC class", @"[T|t]\S"));
Console.WriteLine(Regex.IsMatch("0AA", @"\d\D\w"));
Console.WriteLine(Regex.IsMatch("aaa bb xdsee xda", @"x[^d]"));
Console.WriteLine("//////////////////////");

//()
Console.WriteLine(Regex.IsMatch("Jlo", "J(any|afer|anifer|lo)"));
// $
Console.WriteLine(Regex.IsMatch("Hakk", @"[Ha|HA|hA]k$"));
//{n}
//{n,}
//{n,m}
Console.WriteLine("//////////////////////");

Console.WriteLine(Regex.IsMatch("123", @"\d{3}"));
Console.WriteLine(Regex.IsMatch("12", @"\d{3,}"));
Console.WriteLine(Regex.IsMatch("12435", @"\d{3,8}"));

// +374(10)112-456

//Console.ReadLine();
Console.WriteLine("0000000000000000000000000000");
string[] phoneNumber = { "sqe", "54345345", "+374-410-124152", "+374(10)112-456" };

foreach (var item in phoneNumber)
{
    Console.WriteLine($"This is a correct phone number {IsValidPhoneNumber(item)}");
}

static bool IsValidPhoneNumber(string item)
{
    string pattern = @"^\+374\([1-9][0-9]\)[0-9]{3}\-[0-9]{3}";

    //if (Regex.IsMatch(item, pattern))
    //    return true;
    //else
    //    return false;
    return Regex.IsMatch(item, pattern);
}