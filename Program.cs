/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


void PrintNumbers(int N)
{
    if (N <= 0)
    {
        return;
    }
    Console.Write(N);
    if (N > 1)
    {
        Console.Write(", ");
    }
    PrintNumbers(N - 1);
}







Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Все натуральные числа от N до 1:");
PrintNumbers(N);
Console.WriteLine();







/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/







int FindSumRec(int M, int Nu)
{
    if (M == Nu)
    {
        return M;
    }
    else
    {
        return M + FindSumRec(M + 1, Nu);
    }
}

Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int Nu = Convert.ToInt32(Console.ReadLine());
int sum = FindSumRec(M, Nu);
Console.WriteLine($"Сумма натуральных чисел от {M} до {Nu}: {sum}");







/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int m = 2, n = 3;

int Ackermann(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return Ackermann(m - 1, 1);
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    void Main(string[] args)
    {
        
        Console.WriteLine("A({0},{1}) = {2}", m, n, Ackermann(m, n));

        m = 3; n = 2;
        Console.WriteLine("A({0},{1}) = {2}", m, n, Ackermann(m, n));
    }

Ackermann(m, n);
Main(args);
























































































