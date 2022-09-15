using AbstractProject;
using System.Text;

Console.OutputEncoding = Encoding.Default;

Figure[] figures = new Figure[3];

figures[0] = new Rectangle(20, 30);
figures[1] = new Rectangle(10, 50, "Shape");
figures[2] = new Rectangle(10, 50, "Makeres");

for (int i = 0; i < figures.Length; i++)
{
    figures[i].DisplayInfo();
    Console.WriteLine("Surface is {0}", figures[i].Surface());
    Console.WriteLine(new String('_', 40));
}
