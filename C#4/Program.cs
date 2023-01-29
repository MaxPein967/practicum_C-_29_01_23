// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8
// Console.WriteLine("Введите трехзначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{n % 10}");


Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int b = 100;
int c = 999;
if (number >= b && number <= c)
{
    string strNumber = number.ToString();
    char a = strNumber[strNumber.Length - 1];
    Console.WriteLine("Последняя цифра: " + a);
}
else
{
    Console.WriteLine("Введите трехзначное число ");
    Console.ReadKey();
}

