//Напишите программу, которая на вход принимает число и выдает его квадрат(число, умноженное само на себя)


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(  Console.ReadLine()  );
int square = num*num;
Console.WriteLine("Квадрат введенного числа равен "+ square);

if (num<0)
{
    Console.WriteLine("Это отрицательное число");
}
else
{
    Console.WriteLine("Это неотрицательное число");
}
