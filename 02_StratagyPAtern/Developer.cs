
using System.Xml.Linq;

public class Developer
{
    private string _name;
    private IDeveloperType? _developerType;
    public Developer(string name)
    {
        _name = name;
    }

    public void SetDeveloperType(IDeveloperType developerType)
    {
        _developerType = developerType;
    }

    public void GetDeveloeprType()
    {
        if (_developerType is null)
        {
            Console.WriteLine("We need developers:");
            return;
        }

        Console.WriteLine("I am Happy to teach you here:");

        //  Console.WriteLine($"I am {Name} and I am {developersType} developer:");

        Console.Write($"I am {_name} and I am ");
        _developerType.Profession();
        Console.WriteLine(" developer:");

        Console.WriteLine("Thank you:");
    }


}