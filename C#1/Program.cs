﻿// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// а = 25, b = 5 -> да
// а = 2, b = 10 -> нет
// а = 9, b = -3 -> да
// а = -3, b = 9 -> нет

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = numberB * numberB;
if(result == numberA)
{
    Console.WriteLine($"Результат: {result} Да");
}
else
{
    Console.WriteLine($"Результат: {result} Нет");
}
