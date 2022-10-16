// Задача 10. Напишите программу, которая на вход  принимает трехзначное число и на выходе показывает вторую цифру этого числа.

int ShowTheSecond (int num)
{
    int ed = num / 10;
    int result = ed % 10;
    return result;
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowTheSecond(number));