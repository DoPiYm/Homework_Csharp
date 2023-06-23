// **Задание 1:**Напишите программу,
// которая на вход принимает два числа и выдаёт,
// какое число большее,.

Console.Clear();
Console.WriteLine("Введи первое число");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
Console.WriteLine("Первое число " + numberA + " Больше чем второе число " + numberB);
}
else
{
Console.WriteLine("Второе число " + numberB + " Больше чем первое число " + numberA);
}
