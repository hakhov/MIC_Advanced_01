public delegate double CalcDelegate(double number1, double number2);

internal class Calculation
{
    public void DoCalculation(double x, double y, CalcDelegate calcDelegate)
    {
        //double result = calcDelegate(x, y);
        double result = calcDelegate.Invoke(x, y);
        Console.WriteLine($"Result is {result}");
    }
    public double Add(double number1, double number2)
    {
        return number1 + number2;
    }
    public double Sub(double number1, double number2)
    {
        return number1 - number2;
    }
    public double Mul(double number1, double number2)
    {
        return number1 * number2;
    }
    public double Div(double number1, double number2)
    {
        var result = number2 != 0 ? number1 / number2 : 0;
        return result;
    }
}