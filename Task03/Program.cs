﻿// // // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");


// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница


Console.WriteLine("Введите номер дня недели:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA == 1)
{
    Console.WriteLine("Понедельник");
}
else if (numberA == 2) 
{
    Console.WriteLine("Вторник");
}
else if (numberA == 3)
{
    Console.WriteLine("Среда");
}
else if (numberA == 4)
{
    Console.WriteLine("Четверг");
}
else if (numberA == 5)
{
    Console.WriteLine("Пятница");
}
else if (numberA == 6)
{
    Console.WriteLine("Суббота");
}
else if (numberA == 7)
{
    Console.WriteLine("Воскресенья");
}
else 
{
    Console.WriteLine("Неверноe число дня недели");
}