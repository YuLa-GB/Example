// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//            Выполнить с помощью рекурсии.

// void ShowNums(int n)
// {
//     Console.Write(n + " ");
//     if(n > 1) ShowNums(n - 1);
// }

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNums(n);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void ShowNumber(int m, int n)
{
    if(n == m)
    {
        Console.Write(m + " ");   
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

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNumber(m,n);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
