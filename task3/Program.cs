/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Напишите цифру, которая соответсвует дню недели");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number >= 6)
{
    Console.WriteLine("Да");
}

else
{
    Console.WriteLine("Нет");
}