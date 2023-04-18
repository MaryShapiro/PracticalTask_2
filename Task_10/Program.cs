// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

int GetSecondDigit(int num)
{
    int result = (num / 10) % 10;
    return result;
}
Console.WriteLine($"{num} -> {GetSecondDigit(num)}");