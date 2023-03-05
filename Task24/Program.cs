﻿// Задача 24: Напишите программу, которая принимает 
// 1. на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36



Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine()); // 7

int sum = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");

int SumNumbers(int num) // num = 7
{
    int sum = 0;

    for (int i = 1; i <= num; i++)
    {
        sum += i; // sum = sum + i
    }

    return sum;
}