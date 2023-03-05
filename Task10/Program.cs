// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {number}");

// int firstDigit = number / 100;
// int lastDigit = number % 10;

// int result = firstDigit * 10 + lastDigit;

// Console.Write($"Результат {result}");

int removeSecondDigit = RemoveSecondDigit(number);
Console.WriteLine($"Результат = {removeSecondDigit}");

int RemoveSecondDigit(int num) // num = number
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = (num - (firstDigit * 100) - lastDigit) / 10;
    return result;
}