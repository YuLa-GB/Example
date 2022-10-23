// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].Найдите сумму отрицательных элементов массива.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     Console.WriteLine("Creating array:");
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write($"Input a {i + 1} element of array: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Complete!");
//     return array;
// }

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

// int SumOfNegatives(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
//         if(array[i] < 0)
//             sum += array[i];

//     return sum;
// }

// Console.Write("Input a number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// ShowArray(myArray);

// int result = SumOfNegatives(myArray);
// Console.WriteLine("Sum of negative elements is " + result);


// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] ReversArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;
    return array;
} 

// Console.WriteLine("Add array's size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Add array's maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Add array's minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// int[] array1 = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array1);
// array1 = ReversArray(array1);
// ShowArray(array1);

// Задайте массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int Current(int[] array){
    int current = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] < 100 && array[i] > 9){
            current++;
        }
    }
    return current;
}

// Console.WriteLine("Add array's size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Add array's maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Add array's minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// int[] array1 = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array1);
// int result = Current(array1);
// Console.WriteLine("Number of two-digit is " + result);


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool CheckNumber(int[] array, int num){
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
            return true;
    }   
        return false;
}

Console.WriteLine("Add array's size: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add array's maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add array's minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
int[] array1 = CreateRandomArray(size, minValue, maxValue);
ShowArray(array1);
Console.WriteLine("Add your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(CheckNumber(array1, num))
    Console.WriteLine("Your number is in the array.");
else
    Console.WriteLine("Your number isn't the array.");

