﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
int numberQuarter = Convert.ToInt32(Console.ReadLine());

string rangeQuarter = RangeQuarter(numberQuarter);
string result = rangeQuarter != "Error"
                ? $"Данной четвертри соответствует диапозон -> {rangeQuarter}"
                : "Введен неорректный номер четверти";
Console.WriteLine(result);

string RangeQuarter(int numQuarter)
{
    if (numQuarter == 1) return "x > 0, y > 0";
    if (numQuarter == 2) return "x < 0, y > 0";
    if (numQuarter == 3) return "x < 0, y < 0";
    if (numQuarter == 4) return "x > 0, y < 0";
    return "Error";
}