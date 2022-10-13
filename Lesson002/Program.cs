// Задача 1. Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.
/*
int FindBiggerDigit(int num)
{
    int result;                   // когда метод что-то возвращает, например int, то команда обязательно должна заканчиваться return
                        
        int ed = num % 10;         // либо мы расчитываем, получив цифры, какая из них больше и выводим ту самую цифру
        int dec = num / 10;

        if(ed > dec)
            result = ed;
        else
            result = dec;

    return result;
}

Console.Write("Input a two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int biggerDigit = FindBiggerDigit(number);

Console.WriteLine($"Bigger digit of {number} is {biggerDigit}");
*/

//Задача 2 Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int RemoveTheSecond(int num)
{
    int ed = num % 10;
    int doc = num / 100;
    int result = doc * 10 + ed;
    return result;
}

int number = new Random().Next(100,1000);
Console.WriteLine(number);
Console.WriteLine(RemoveTheSecond(number));


// Задача 3 Напишите программу , которая принимает на вход число n и проверяет, 
//          кратно ли оно одновременно и a и b (целочисленные делители, также задаются пользоватлем)
