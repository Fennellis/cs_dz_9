// Задача 68: Напишите программу
// вычисления функции Аккермана
// с помощью рекурсии. Даны два
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

(int numberN, uint numberM) = Input();

bool n0 = numberN == 0 && numberM < Math.Pow(2,32) - 1;
bool n1 = numberN == 1 && numberM < Math.Pow(2,32) - 1;
bool n2 = numberN == 2 && numberM <= 100000000;
bool n3 = numberN == 3 && numberM <= 11;
bool n4 = numberN == 4 && numberM <= 1;
bool n5 = numberN == 5 && numberM == 0;

if (n0 || n1 || n2 || n3 || n4 || n5)
{
    uint result = Ack(numberN, numberM);
Console.WriteLine($"n = {numberN}, m = {numberM} -> A(n,m) = {result}");
}
else
{
    Console.WriteLine("Результат слишком велик");
}

(int, uint) Input()
{
    Console.Write("Введите число n: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число m: ");
    uint secondNumber = Convert.ToUInt32(Console.ReadLine());
    return (firstNumber, secondNumber);
}

uint Ack(int n, uint m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return Ack(n - 1, 1);
    else return Ack(n - 1, Ack(n, m - 1));
}
