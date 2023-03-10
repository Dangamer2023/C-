//Напишите программу, которая принимает на вход одно число(N), а на выходе показывает все целые числа в промежутке от -N до +N
//4 -> "-4,-3,-2,-1,0,1,2,3,4"
//2 ->"-2,-1,0,1,2"

Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;
while(i<=N){
    Console.Write(i+ "  ");
    i++;


}

/*Напишите программу, которая на вход принимает трехзначное число и на выходе показывает последнюю цифру этого числа
 456 -> 6
 782 -> 2
918 -> 8*/

try 
{
Console.WriteLine("Введите трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
int mod = n%10;
Console.WriteLine(mod);
}
catch
{
    Console.WriteLine("Введите число");
}

//Напишите программу, которая выдает день недели по заданному номеру

Console.WriteLine("Введите число от 1 до 7");
string DayNum = Console.ReadLine();

if(DayNum == "1") Console.WriteLine("Понедельник");
else if(DayNum == "2") Console.WriteLine("Вторник");
else if(DayNum == "3") Console.WriteLine("Среда");
else if(DayNum == "4") Console.WriteLine("Четверг");
else if(DayNum == "5") Console.WriteLine("Пятница");
else if(DayNum == "6") Console.WriteLine("Суббота");
else if(DayNum == "7") Console.WriteLine("Воскресенье");
else Console.WriteLine("Введите число от 1 до 7 включительно");