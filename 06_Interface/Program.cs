var cars = new List<ICar>();
var humons = new List<IHumon>();

cars.Add(new BMW());
cars.Add(new Audi());
cars.Add(new Hibrid());

//humons.Add(new BMW());
//humons.Add(new Audi());
humons.Add(new Hibrid());

foreach (var item in cars)
{
    Console.WriteLine(item.Move(1000));
}

Hibrid hibrid = new Hibrid();
 

Console.WriteLine(((ICar)hibrid).Move(500));
Console.WriteLine(((IHumon)hibrid).Move(30));
