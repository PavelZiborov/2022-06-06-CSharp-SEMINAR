/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Pow(int A, int B)
{
    if (B == 1)
        return A;
    B--;
    return A * Pow(A, B);
}


Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"Результат: {Pow(A, B)}");






