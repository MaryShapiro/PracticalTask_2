// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.

/*
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = 0;

int GetThirdDigit(int num)
{
    if (num >= 100)
    {
        result = num % 10;
        if (num > 999)
        {
            result = (num / 10) % 10;
        }
        if (num > 9999)
        {
            result = (num / 100) % 10;
        }
        if (num > 99999)
        {
            result = (num / 1000) % 10;
        }
        Console.WriteLine($"{num} -> {result}");
    }
    else
    {
        Console.WriteLine($"{num} -> Третьей цифры нет");
    }
    return result;
}

Console.WriteLine(GetThirdDigit(num));