
using System.Runtime.Serialization.Formatters.Binary;

Mersedes mersedes = new Mersedes("C 350", 250, Mode.Classic);
mersedes.TurnOnTV(true);
mersedes.SetMode(Mode.Classic);

FileStream fileStream = File.Create(@"D:\Car.dat");


BinaryFormatter binaryFormatter = new BinaryFormatter();

binaryFormatter.Serialize(fileStream, mersedes);
fileStream.Close();

fileStream = File.OpenRead(@"D:\Car.dat");
mersedes = binaryFormatter.Deserialize(fileStream) as Mersedes;



