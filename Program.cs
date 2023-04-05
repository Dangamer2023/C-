//Здесь будет код с рекурсией

//Сумма чисел от 1 до N

/*int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}


int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10)); //55
Console.WriteLine(SumRec(10)); //55


//Факториал числа

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;

}



int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(10)); // 3628800
Console.WriteLine(FactorialRec(10)); // 3628800



//Вычислить a^n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}



int PowerRec(int a, int n)
{
    //return n == 0 ? 1 : PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}



Console.WriteLine(PowerFor(2, 10)); // 1024
Console.WriteLine(PowerRec(2, 10)); // 1024


//Посчитаем сумму всех чисел от 1 до N, где N вводится пользователем

int Summa(int num)
{
    int sum = 0;
    while (true)
    {
        if (num == 0) break;
        sum += num;
        num = num - 1;
    }
    return sum;
}



int SummaRec(int num)
{
    if (num == 0) return 0;
    return num + SummaRec(num - 1);
}






Console.WriteLine("Введите натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех целых чисел от 1 до {num} равна {Summa(num)}");
Console.WriteLine($"Сумма рекурсией всех целых чисел от 1 до {num} равна {SummaRec(num)}");


/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
от 1 до N

N = 5 -> "1,2,3,4,5"
N = 6 -> "1,2,3,4,5,6"*/


string NumbersAmount(int Nat)
{
    if(Nat == 0) return "";
    return NumbersAmount(Nat-1)+ " "+Nat;
}




Console.WriteLine("Введите значение N");
int Nat = Convert.ToInt32(Console.ReadLine());
Console.Write(NumbersAmount(Nat));



/*for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i);
}*/



/*Задача 63: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
от M до N

M = 1; N = 5 -> "1,2,3,4,5"
M = 4; N = 8 -> "4,5,6,7,8"*/
