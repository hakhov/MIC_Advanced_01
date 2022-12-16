using System.Xml.Serialization;
using XML_Serialization.Models;

namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    readonly XmlSerializer xmlSerializer = new XmlSerializer(typeof(MyClass));

    MyClass instanceForSerialization = new MyClass();
    MyClass instanceForDeserialization;
    private void button1_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < 15; i++)
      {
        instanceForSerialization.Items.Add($"Element: {i}");
      }

      using (FileStream fileStream = new FileStream(@"D:\Serialization.xml", FileMode.Create, FileAccess.Write))
      {
        xmlSerializer.Serialize(fileStream, instanceForSerialization);
      }

      MessageBox.Show("Its Ok");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        FileStream stream = new FileStream(@"D:\Serialization.xml", FileMode.Open, FileAccess.Read);

        instanceForDeserialization = xmlSerializer.Deserialize(stream) as MyClass;

        textBox1.Text = "ID : " + instanceForDeserialization.ID + Environment.NewLine +
                        "Size : " + instanceForDeserialization.Size + Environment.NewLine +
                        "Password: " + instanceForDeserialization.Password + Environment.NewLine +
                        "Point :" + instanceForDeserialization.Position + "\t";

        foreach (var item in instanceForDeserialization.Items)
        {
          textBox1.Text += "\t" + item + Environment.NewLine;
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}