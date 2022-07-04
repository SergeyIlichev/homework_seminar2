/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Напишите трехзначное число ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > 99 && number < 1000)
{
    int secondDigit = (number % 100) / 10;
    Console.WriteLine($"Второй цифрой числа {number} является {secondDigit}");
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}