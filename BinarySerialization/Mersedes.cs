
[Serializable]

public class Mersedes : Car
{
	public Mode mode;
	public Mersedes(string name, int speed, Mode mode)
		:base(name, speed)
	{
		this.mode = mode;
	}

	public void SetMode(Mode mode)
	{
		this.mode = mode;
		Console.WriteLine(this.mode);
	}
}
