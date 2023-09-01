//VARIABLES
byte number1 = 224;
short number2 = 16000;
int number3 = 1000_000_00;
long number4 = 1000_000_000_000;
bool x = true;
char symbol = '$';
float number5 = 23.4f;
double number6 = 585.4;
decimal number7 = 5151525.5m;
string text = "Hello, world";



//CALCULATOR
Console.WriteLine("Hello user, it's calculator");

Console.Write("Enter first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please enter operation, which you want to make(+,-,*,/)");
char operation = Convert.ToChar(Console.ReadLine());

if(operation == '+')
{
    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
}
else if(operation == '-')
{
    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
}
else if(operation == '*')
{
    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
}
else if(operation == '/')
{
    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
}



//MATH OPERATION
Console.WriteLine("Enter some number");
int y=Convert.ToInt32(Console.ReadLine());

Console.WriteLine(-6*Math.Pow(y, 3)+5*Math.Pow(y,2)-10*y+15);
Console.WriteLine(Math.Abs(y) * Math.Sin(y));
Console.WriteLine(2*Math.PI*y);
Console.WriteLine(Math.Max(y, number1));

Console.ReadLine();
