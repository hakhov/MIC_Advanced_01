namespace Calculate
{
    public class Calc
    {
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
            return number2 != 0 ? number1 / number2 : 0;
        }

        public bool ValidNumber(string txt)
        {
            if (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt)) return false;
            if (!double.TryParse(txt, out _)) return false;

            return true;
        }
    }
}