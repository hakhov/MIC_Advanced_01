CalcDelegate? mulDelegate, addDelegate, subDelegate, divDelegate;
Calculation calculation = new();
addDelegate = new CalcDelegate(calculation.Add);
addDelegate(1.5, 2.8);

subDelegate = new CalcDelegate(calculation.Sub);
subDelegate(1.5, 2.8);

mulDelegate = new CalcDelegate(calculation.Mul);
mulDelegate(1.5, 2.8);

divDelegate = new CalcDelegate(calculation.Div);
divDelegate(1.5, 2.8);

public delegate void CalcDelegate(double number1, double number2);

