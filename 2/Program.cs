// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
if (firstNum < 1 || secondNum < 1)
{
    Console.Write("Некорректное значение");
    return;
}

int result;
if (firstNum < secondNum)
{
    result = SumNaturalInRange(firstNum, secondNum);
}
else
{
    result = SumNaturalInRange(secondNum, firstNum);
}

Console.WriteLine($"M = {firstNum}; N = {secondNum} -> {result}");

int SumNaturalInRange(int bottom, int top)
{
    if (top > bottom) return top + SumNaturalInRange(bottom, top - 1);
    else return top;
}