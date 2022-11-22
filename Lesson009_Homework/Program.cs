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

// int ShowNumber(int sum, int m, int n)
// {
//     if(m == n)
//     {
//         return sum + m;
//     }
//     if(m < n) 
//     {
//         return ShowNumber(sum + m, m + 1, n);
//     }
//     if(m > n) 
//     {
//         return ShowNumber(sum + n, m, n + 1);
//     }
//     return 0;
// }

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(ShowNumber(0,m,n));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     if (n == 0)
//         return Akkerman(m - 1, 1);
//     return Akkerman(m - 1, Akkerman(m, n - 1));
// }
 
//  Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(Akkerman(m,n));
   
    

