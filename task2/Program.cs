/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > 99 && number < 1000)
{
    int thirdDigit = (number % 100) % 10;
    Console.WriteLine($"Третья цифра числа {number} это {thirdDigit}");
}

else if (number > 999 && number < 10000)
{
    int thirdDigit = ((number % 1000) % 100) / 10;
    Console.WriteLine($"Третья цифра числа {number} это {thirdDigit}");
}

else if (number > 9999 && number < 100000)
{
    int thirdDigit = ((number % 10000) % 1000) / 100;
    Console.WriteLine($"Третья цифра числа {number} это {thirdDigit}");
}

else if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}