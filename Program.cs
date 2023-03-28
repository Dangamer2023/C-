//Решаем задачу с рекурсией и факториалом
// 1! = 1
// 0! = 1

double Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}


// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonachi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachi(n - 1) + Fibonachi(n - 2);
}


for (int i = 1; i< 10; i++)
{
    Console.WriteLine(Fibonachi(i));
}

