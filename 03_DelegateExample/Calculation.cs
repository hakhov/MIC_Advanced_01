
internal class Calculation
{
    public void Add(double number1, double number2)=>
        Console.WriteLine($"Add is = {number1 + number2}");
     
    public void Sub(double number1, double number2)=>
        Console.WriteLine($"Sub is = {number1 - number2}"); 
    public void Mul(double number1, double number2)=>
        Console.WriteLine($"Mul is = {number1 * number2}"); 
    public void Div(double number1, double number2)
    {
        var result = number2 != 0 ? number1 / number2 : 0;
        Console.WriteLine($"Div is = {result}");
    }
}