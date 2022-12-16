
using XML_Serialization.Models;

public partial class Program
{
  static void SerializationStart(MyClass myClass)
  {
    MyXml xml = new MyXml();
    //myClass.ItemsGenerator();

    //for (int i = 0; i < 15; i++)
    //{
    //  myClass.Items.Add($"Element: {i}");
    //}

    using (FileStream fileStream = new FileStream(@"D:\Serialization.xml", FileMode.Create, FileAccess.Write))
    {
      xml.xmlSerializer.Serialize(fileStream, myClass);
    }
  }
}
