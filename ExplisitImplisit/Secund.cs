public  class Secund
{
    public int Senunds { get; set; }

	//public Secund(int senunds)
	//{
	//	Senunds = senunds;
	//}

	public static explicit operator int(Secund secund)
	{
		return secund.Senunds;
	}

	public static implicit operator Secund(int a)
	{
		return new Secund { Senunds = a };
	}
}