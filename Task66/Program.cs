// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int number1 = InputInt("Введите первое целое число: ");
int number2 = InputInt("Введите второе целое число: ");
Console.WriteLine($"Сумма элементов от {number1} до {number2} = {CountNaturalSum(number1, number2)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int number1, int number2)
{
    if (number1 == number2)
        return number2;
    return number2 + CountNaturalSum(number1, number2 - 1);
}