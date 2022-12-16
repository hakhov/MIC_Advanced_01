using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Serialization.Models
{
  public class MyClass
  {
    private string id = "button";
    private int size = 100;
    private Point position = new Point(30, 20);
    private string password = "12345678_password";
    private List<string> items = new List<string>();

    public string ID { get; set; }
    public int Size { get; set; }

    public Point Position { get; set; }

    public string Password { get; set; }

    public List<string> Items { get; set; }

    public void ItemsGenerator()
    {
      for (int i = 0; i < 15; i++)
      {
        Items.Add($"Element: {i}");
      }
    }

    public MyClass()
    {
      for (int i = 0; i < 15; i++)
      {
        Items.Add($"Element: {i}");
      }
    }
  }
}
