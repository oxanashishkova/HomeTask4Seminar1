// #4 На вход принимаем три числа, на выходе даем макс из них.

Console.WriteLine("Enter number 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number 3: ");
int number3 = int.Parse(Console.ReadLine());
int maximum = number1;

if (maximum < number2) maximum = number2;
if (maximum < number3) maximum = number3;

Console.WriteLine($"Maximum = {maximum}");