// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.WriteLine("Введите первое число");
int num0 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int num1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число");
int num2 = Convert.ToInt32(Console.ReadLine());

int maxNumber = num0;

if (num1 > maxNumber)
{
    maxNumber = num1;
}
if (num2 > maxNumber)
{
    maxNumber = num2;
}
System.Console.WriteLine("Большее число " + maxNumber);