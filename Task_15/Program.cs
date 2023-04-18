// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

/*
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.WriteLine("Введите день недели ");
int DayOfWeek = int.Parse(Console.ReadLine()!);

int FindDayOfWeek (int DayOfWeek)
{
    if (DayOfWeek == 6 || DayOfWeek == 7)
    {
        Console.WriteLine($"{DayOfWeek} -> Выходной день");
    }
    else
    {
        if (DayOfWeek <= 5)
        {
            Console.WriteLine ($"{DayOfWeek} -> Будний день");
        }
        else
        {
            Console.WriteLine("Ошибка: В неделе всего 7 дней!");
        }
    }
    return DayOfWeek;
    
}

Console.WriteLine(FindDayOfWeek(DayOfWeek));