/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
int P =  Convert.ToInt32(Math.Pow(A,B));
Console.WriteLine($"Число {A} в степени {B} = {P}");


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 1000);
}



void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"[{item} ]");
    Console.WriteLine();
}





int[] array = new int[8];
FillArray(array);
PrintArray(array);






























/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/