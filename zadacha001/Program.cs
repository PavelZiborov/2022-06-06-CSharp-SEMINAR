/*
Задача 63: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

void Natural(int first, int last)
{
    Console.Write($"{first++}  ");

    if (first <= last)
        Natural(first, last);
}

int first = 0;
int last = int.Parse(Console.ReadLine());
Natural(first, last);