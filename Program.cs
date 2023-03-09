//Напишите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
//a = 2, b =10 > нет
//a = 9, b = 3 > да
// и т.д

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(  Console.ReadLine()  );
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(  Console.ReadLine()  );

int square = second*second;

if (square == first)
{
    Console.WriteLine("Является");
}
else
{
     Console.WriteLine("Не является");
}