// Manipulation symbols
// System.Text.RegularExpressions
//String & StringBuilder
//Match Matches -NextMatch()

using System.Text.RegularExpressions;

string txt = "Hello, My name is ello, and like mellon bit yello";

Match match1 = Regex.Match(txt, "ello");
Console.WriteLine(match1.Index);//Համընկնումը առաջին ինդեքսի շաբլոնի հետ
Console.WriteLine(match1.Value);// Շաբլոնը
Console.WriteLine(match1.Name);// - մի հատ նայել
Console.WriteLine(match1.Captures);// using collectioni
Console.WriteLine(match1.Success); // true
Console.WriteLine(Regex.IsMatch(txt, "ello"));

Match match2 = match1.NextMatch();
Console.WriteLine(match2.Index);//18 ic

Match match3 = match2.NextMatch();
Console.WriteLine(match3.Index);//34 ic

Match match4 = match3.NextMatch();
Console.WriteLine(match4.Index);//45 ic

Console.WriteLine("-------------------------------");

Console.WriteLine(txt.IndexOf("ello"));
int index = txt.IndexOf("ello");
Console.WriteLine(txt.IndexOf("ello", index + 1));

Console.WriteLine("-------------------------------");

foreach (Match item in Regex.Matches(txt,"ello"))
{
    Console.WriteLine(item.Index);
}