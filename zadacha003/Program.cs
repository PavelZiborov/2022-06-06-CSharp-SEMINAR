/*
Задача 67: Напишите программу, которая будет принимать
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9
*/

void SumOfDigits(int number, int result)
{

    int sum = number % 10;
    number = number / 10;
    result = result + sum;
    if (number != 0)
        SumOfDigits(number, result);
    else
        Console.WriteLine($"Сумма цифр этого числа = {result}");
}

Console.WriteLine("Введите число >0: ");
int number = int.Parse(Console.ReadLine());
SumOfDigits(number, 0);

