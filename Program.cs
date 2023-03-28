/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/
/* 1 - Генерируем массив трехзначных чисел от 100 до 999
   2 - Выводим массив на экран
   3 - Создаем переменную even(четное), изначально она равна 0
   4 - Делим каждый элемент массива на 2 без остатка(можно использовать foreach)
   5 - Если элемент массива(число) делится на 2, то мы прибавляем к even единицу(1)
   6 - Выводим массив на экран и выводим значение переменной even, это значение - и есть количество четных элементов
*/

int even = 0;

void FillArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
        array[i]=new Random().Next(100,999);
}



void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}



void FindEven(int[] array)
{
  
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
        even++; 
    }
}
  
}



void PrintEven(int[] array)
{
    Console.WriteLine($"Количество четных чисел в массиве = {even}");
}



int[] array = new int[4];
FillArray(array);
PrintArray(array);
FindEven(array);
PrintEven(array);









/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


int odd = 0;

void NewArray(int[] newarray)
{
    for (int i=0; i<array.Length;i++)
        newarray[i]=new Random().Next(1,99);
}


void WriteArray(int[] newarray)
{
    foreach (int item in newarray)
        Console.Write($"{item} ");
    Console.WriteLine();
}

void FindOdd(int[] newarray)
{
    for (int i=0; i<newarray.Length;i++)
    {
    if (newarray[i] % 2 != 0)
    {
        odd += newarray[i];
    }
}
    
}

int[] newarray = new int[4];


/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/