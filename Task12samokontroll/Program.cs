/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();
int GetNumber(string msg)
{
    Console.Write(msg);
    int rez = Convert.ToInt32(Console.ReadLine());
    return rez;
}

Console.Clear();
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе");
int rezult = 0;
int a = GetNumber("Введите число: ");
while (a > 0)
{
    rezult += a % 10;
    a = a / 10;
}
Console.WriteLine($"Результат: {rezult}");