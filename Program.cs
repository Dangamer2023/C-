/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

14212 -> нет

12821 -> да

23432 -> да*/

void Pallidrom(int n)
{
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваше число: {number}");
int d1 = number / 10000;
    int d2 = (number / 1000) % 10;
    int d3 = (number / 100) % 10;
    int d4 = (number / 10) % 10;
    int d5 = number % 10;
if(d1 == d5 && d2 == d4)
{
    Console.WriteLine($"{number} -> да");

}
else
    Console.WriteLine($"{number} -> нет");
}



/*Задача 21

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*void Coordinates(int XYZ)
{
Console.WriteLine("Введите координаты точки A (x,y,z):");
    string[] aStr = Console.ReadLine().Split(',');
    double aX = double.Parse(aStr[0]);
    double aY = double.Parse(aStr[1]);
    double aZ = double.Parse(aStr[2]);

    Console.WriteLine("Введите координаты точки B (x,y,z):");
    string[] bStr = Console.ReadLine().Split(',');
    double bX = double.Parse(bStr[0]);
    double bY = double.Parse(bStr[1]);
    double bZ = double.Parse(bStr[2]);

    double dist = Math.Sqrt(Math.Pow(aX - bX, 2) + Math.Pow(aY - bY, 2) + Math.Pow(aZ - bZ, 2));

    Console.WriteLine("Расстояние между точками: {0:F2}", dist);
}*/











/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/


/*void Main()
    {
        Console.Write("Введите число N: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Таблица кубов чисел от 1 до {0}:", n);
        PrintCubeTable(n);
    }



void PrintCubeTable(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int cube = i * i * i;
            Console.Write("{0} ", cube);
        }
        Console.WriteLine();
    }*/
































































/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

/*Console.WriteLine("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int B = Convert.ToInt32(Console.ReadLine());
int P =  Convert.ToInt32(Math.Pow(A,B));
Console.WriteLine($"Число {A} в степени {B} = {P}");*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]


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
PrintArray(array);*/






























/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/