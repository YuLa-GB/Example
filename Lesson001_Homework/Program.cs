// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    Console.WriteLine("Max number is " + n1);
    Console.WriteLine("Min number is " + n2);
}
else
{
    Console.WriteLine("Max number is " + n2);
    Console.WriteLine("Min number is " + n1);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int a = 22;
int b = 3;
int c = 9;

int max = a;
if (a > max ) max = a;
if (b > max ) max = b;
if (c > max ) max = c;


Console.Write("max = ");
Console.WriteLine(max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.WriteLine("четное число");
}
else
{
    Console.WriteLine("нечетное");
}
*/

// Задача 8: Напишите программу, котопая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 1;

if(n < 0)
{
    current = n;
}

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
