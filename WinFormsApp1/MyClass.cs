using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML_Serialization.Models
{
  //[Serializable]

  [XmlRoot("MyClassRoot")]
  public class MyClass
  {
    private string id = "button";
    private int size = 100;
    private Point position = new Point(30, 20);
    private string password = "12345678_password";
    private List<string> items = new List<string>();


    [XmlElement("Element")]
    public string ID
    {
      get { return id; }
      set { id = value; }
    }

    [XmlAttribute("Lenght")]
    public int Size
    {
      get { return size; }
      set { size = value; }
    }

    [XmlElement("Point")]
    public Point Position
    {
      get { return position; }
      set { position = value; }
    }

    [XmlIgnore]
    //[XmlAttribute("Point")]

    public string Password
    {
      get { return password; }
      set { password = value; }
    }

    [XmlArray]
    [XmlArrayItem("Element")]
    public List<string> Items
    {
      get { return items; }
      set { items = value; }
    }
  }
}
