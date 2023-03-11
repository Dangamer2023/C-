/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

if(first>second)
{
    Console.WriteLine("max= "+first);
}
else{

 Console.WriteLine("max= "+second);
}


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите три числа через пробел:");

        // Считываем три числа, введенных пользователем
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        // Находим максимальное число
        int max = a;
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }

        Console.WriteLine("Максимальное число: "+max);

    /*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Число является чётным");
        }
        else
        {
            Console.WriteLine("Число не является чётным");
        }

        


/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
        
        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++) {
            if (i % 2 == 0) {
                Console.Write(i + " ");
            }
        }

