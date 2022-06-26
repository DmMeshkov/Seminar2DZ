//на вход принимается трехзначное число и выводится вторая цифра числа.

int SecNumber(int number)
{
    if (number < 100 || number > 999)
    {
        Console.WriteLine("Wrong Number");
        return 0;
    }
    else
    {
        int Second = number % 100 / 10;
        Console.WriteLine(Second);
        return 0;
    }
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
SecNumber(num);