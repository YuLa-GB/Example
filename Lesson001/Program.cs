/*

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

// Задача 1. Напишите программу, которая на вход принимается  два числа и проверяет является ли первое число квадратом второго
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int q2 = n2 * n2;

if(n1 == q2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

//Задача 2. Напишите программу, которая на вход принимает одно число N, а на выход показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;

if(n < 0)
{
    current = n;
    n = -n;
}

while(current <= n)
{
    Console.Write(current + " ");
    current++;
}
*/

//  Целочисленное число
/*
3162 % 10 -> 2
3162 % 100 -> 62
3162 % 1000 -> 162
*/

// Задача 3. Напишите программу, которая на вход принимает  трехзначное число и на выходе показывает последнюю цифру этого числа

Console.Write("Input a tree-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    Console.WriteLine("Last digit of " + n + " is " + n % 10);
}
else
{
    Console.WriteLine("Uncorrect input!");
}
