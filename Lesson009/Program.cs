// Задача 1. Задайте значение N. Напишите программу , которая выведет все натуральные числа в промежутке от 1 до N. 
// Рекурсия!

void ShowNums(int n)
{
    if(n > 1) ShowNums(n - 1);
    Console.Write(n + " ");
}

// ShowNums(5);

// Задача 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigits(int n)
{
    if(n != 0) return SumOfDigits(n / 10) + n % 10;
    else return 0;
}

// Console.WriteLine(SumOfDigits(1234));

// Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNumber(int m, int n)
{
    if(n == m)
    {
        Console.Write(m + " ");    // или Console.Write(n + " "), так как n = m
    }
    if(n < m)
    {
        ShowNumber(m-1, n);
        Console.Write(m + " ");
    } 
    if(n > m) 
    {
        ShowNumber(m, n-1);
        Console.Write(n + " ");
    }
}

// ShowNumber(7,1);



// Задача 4. Напишите программу, которая на вход принимает два числа А и В, и возводит число А в целую степень В.

double ShowDegree(double a, double b)
{
    if(b < 0)
    {
        return 1/a * ShowDegree(a, b + 1);
    }
    if(b > 0)
    {
        return a * ShowDegree(a, b-1);
    }
    return 1;
}

Console.WriteLine(ShowDegree(2,-3));