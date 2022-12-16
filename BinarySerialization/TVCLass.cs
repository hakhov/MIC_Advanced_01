[Serializable]

public class TVCLass
{
  [NonSerialized]
  private int SerialNumber = 10000;

  public void OnOff(bool _switch)
  {
    Console.WriteLine(_switch ? "TV turn on" : "TV turn off");
  }
}