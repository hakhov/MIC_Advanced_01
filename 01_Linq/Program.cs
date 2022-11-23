using System.Collections.Generic;

string[] txt = { "Hakob", "Hayk", "Samvel", "David", "Asya", "Lilit" };

var selectedString = new List<string>();

foreach (string str in txt)
{
    if (str.ToUpper().StartsWith("H"))
        selectedString.Add(str.ToUpper());
}

Console.WriteLine($"Selected Array: {string.Join(", ", selectedString)}");

var selectedLinqARray = from item in txt
                        where item.StartsWith("H")
                        select item;

var lmb = txt.Where(x => x.StartsWith("H")).OrderBy(x => x).ToList();

Console.WriteLine($"Selected Array: {string.Join(", ", lmb)}");
