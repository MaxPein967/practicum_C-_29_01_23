// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

int a = 1;
int b = 7;

if (number >= a && number <= b)
{
    number = number - 1;
    Console.WriteLine(daysOfWeek[number]);
}
else
    Console.WriteLine("Не является днем недели");
    



