﻿/*

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your number is " + num);
*/

// Задача 1. Напишите программу, которая на вход принимается  два числа и проверяет является ли первое число квадратом второго

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