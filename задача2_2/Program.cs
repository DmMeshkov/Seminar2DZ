
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

void Weekend(int Day)
{
    if (Day == 6 || Day == 7)
        Console.WriteLine("it is a weekend");

    if (Day > 0 && Day < 6)
        Console.WriteLine("it is work day");

    if (Day < 1 || Day > 7)
        Console.WriteLine("it is not a day of the week");
}
Console.WriteLine("Input a digit: ");
int day = Convert.ToInt32(Console.ReadLine());

Weekend(day);
