// Напишите программу, которая на вход принимает число 
/*
int GetSum(int num)
{
    int sum = 0;

    for(int current = 1; current <= num; current++)
    {
        sum += current;   // sum = sum + current;
    }
    return sum;
}

Console.Write("Input a positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

int s = GetSum(a);

Console.WriteLine($"Sum of number from 1 to {a} is {s}");
*/


// Задача 2  Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
/*
int Num(int n)
{
    int current = 0;
    while(n > 0)
    {
        n /= 10;
        current++;
    }
    return current;
}
Console.WriteLine("Add the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = Num(number);
Console.WriteLine($"Number of digits is {a}");
*/

// Задача 3 Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.


// Задача 4 Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "");

    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);


// ДЗ дополнительно (+ к тому, что есть на сайте): создать метод, который генерирует массив, запрашивая каждый элемент



