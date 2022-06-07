/*
Задача 65: Задайте значения M и N. Напишите программу,
которая выведет все натуральные числа в промежутке от M до N.
*/

void PrintNumbers(int M, int N)
{
    if (M <= N)
    {
        Console.Write($"{M++}  ");
        PrintNumbers(M, N);
    }
}

int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());
PrintNumbers(M, N);