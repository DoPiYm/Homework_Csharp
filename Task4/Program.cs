// * *Задание 4:**Напишите программу,
// которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Четные числа от 2 до" + number);
while (i <= number)
{
if (i % 2 != 1)
{
Console.Write(i + ", ");
not = false;
}
i++;
}
if (not)
{
Console.WriteLine("Нет четных чисел");
}
