﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int num = Prompt("Введите целое десятичное число: ");
int found = Prompt("Введите целое десятичное число основание системы исчисления: ");

Console.WriteLine(DecToBin(num, found));

int DecToBin(int num, int foundation)
{
    int res = 0;
    int multiplier = 1;

    while (num > 0)
    {
        res += (num % foundation) * multiplier;
        num = num / foundation;
        multiplier *= 10;
    }

    return res;
}

int Prompt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}