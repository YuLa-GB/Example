// Задача 1. Напишите программу, которая принимает двузначное число и показывает наибольшую цифру числа.
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
