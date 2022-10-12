class Developer
{
    public string Name = "Hakob";

    public void Typeofdeveloper(DevelopersType developersType)
    {
        Console.WriteLine("I am Happy to teach you here:");

        switch (developersType)
        {
            case DevelopersType.Web:
                Console.WriteLine($"I am {Name} and I am {developersType} developer:");
                break;
            case DevelopersType.Front:
                Console.WriteLine($"I am {Name} and I am {developersType} developer:");
                break;
            case DevelopersType.Back:
                Console.WriteLine($"I am {Name} and I am {developersType} developer:");
                break;
            case DevelopersType.UiUx:
                Console.WriteLine($"I am {Name} and I am {developersType} developer:");
                break;
        }

        Console.WriteLine("Thank you:");
    }
}