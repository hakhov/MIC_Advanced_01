
[Serializable]
public class Car
{
  protected int speed;
  protected string name;
  protected TVCLass tVCLass;

  public Car(string name, int speed)
  {
    this.name = name;
    this.tVCLass = new TVCLass();
    this.speed = speed;
  }

  public void TurnOnTV(bool state)
  {
    tVCLass.OnOff(state);
  }

  public string Name
  {
    get { return name; }
    set { name = value; }
  }

  public int Speed
  {
    get { return speed; }
    set { speed = value; }
  }
}
