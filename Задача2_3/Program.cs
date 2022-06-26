// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// 198 %10=8
// 1986%100=86/10=8
// 19865%1000/100=8


// int n = Convert.ToInt32(Console.ReadLine());
// int k =  (int)Math.Log10(n)-2;
// Console.WriteLine(k < 0 ? "No such digit" : (n %(int)Math.Pow(10, k + 1) /(int)Math.Pow(10, k)).ToString());


void ThirdNumber(int Number)
{
    if (Number < 100) Console.WriteLine("Третьей цифры нет");
    if (Number >= 100 && Number <= 999) Console.WriteLine(Number % 10);
    //int res=Number%100/10;
    if (Number >= 1000 && Number <= 9999) Console.WriteLine(Number % 100 / 10);
    if (Number >= 10000 && Number <= 99999) Console.WriteLine(Number % 1000 / 100);
    if (Number >= 100000 && Number <= 999999) Console.WriteLine(Number % 10000 / 1000);
    if (Number >= 1000000 && Number <= 9999999) Console.WriteLine(Number % 100000 / 10000);
    if (Number >= 10000000 && Number <= 99999999) Console.WriteLine(Number % 1000000 / 100000);
    if (Number >= 100000000 && Number <= 999999999) Console.WriteLine(Number % 10000000 / 1000000);
    if (Number >= 1000000000 && Number <= 2147483647) Console.WriteLine(Number % 100000000 / 10000000);
}
Console.WriteLine("Input number");
int Res = Convert.ToInt32(Console.ReadLine());
ThirdNumber(Res);