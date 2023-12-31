﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Clear();

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday (int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine ("Ошибка!!! Если ты считаешь что это день недели иди поспи");
    return false;
}

int weekDay = Prompt ("Введите деь недели -> ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine ("Выходной");
    }

    else 
    {
         Console.WriteLine ("Будний день");
    }
}