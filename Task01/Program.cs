﻿// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");



// Напишите программу, которая на 
// 1.вход принимает два числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
int squareB = numberB * numberB;
if (numberA == squareB)
{
   Console.WriteLine($"Число {numberA} является квадратом {numberB}"); 
}
else 
{
    Console.WriteLine($"Число {numberA} не является квадратом {numberB}");
}