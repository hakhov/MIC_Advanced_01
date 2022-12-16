
using System.Reflection;

public partial class Program
{
  static void GetInfoAboutClass(object myClass)
  {
    Type type = myClass.GetType();

    Console.WriteLine($"Full Name : {type.FullName}");
    Console.WriteLine($"Base Type : {type.BaseType}");
    Console.WriteLine($"Is Abstruct : {type.IsAbstract}");
    Console.WriteLine($"Is Sealed : {type.IsSealed}");
    Console.WriteLine($"Is IsClass : {type.IsClass}");
  }

  static void GetInfoABoputMethods(object myClass)
  {
    Type type = myClass.GetType();

    MethodInfo[] methods = type.GetMethods(
      BindingFlags.Instance
      | BindingFlags.Public
      | BindingFlags.NonPublic
      | BindingFlags.Static
      | BindingFlags.DeclaredOnly
      );

    foreach (var item in methods)
    {
      Console.WriteLine($"Methods {item.Name}");
    }
  }
}