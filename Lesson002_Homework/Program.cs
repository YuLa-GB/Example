// Задача 10. Напишите программу, которая на вход  принимает трехзначное число и на выходе показывает вторую цифру этого числа.
/*
int ShowTheSecond (int num)
{
    int ed = num / 10;
    int result = ed % 10;
    return result; 
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowTheSecond(number));
*/

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
string ShowTheThird (int num)
{
    int length = Convert.ToString(num).Length;

       if(length > 2)
       {
       // Console.WriteLine("TEST " + (num / Math.Pow(10, length - 3)));
        int result = num / Convert.ToInt32(Math.Pow(10, length - 3)) % 10;
        return Convert.ToString(result);
       }

     return "Третьей цифры нет";
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowTheThird(number));
*/


// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
string CheckingTheWeekend (int num)
{
    if(num == 6 || num == 7)
    {
        return "да";
    }
    return "нет";
}

Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Является ли выходным днем: {CheckingTheWeekend(number)}");
*/