// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] CreateRandom2dArray()
// {
//     Console.Write("Input a number of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of columns: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a min possible value: ");
//     double minValue = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Input a max possible value: ");
//     double maxValue = Convert.ToDouble(Console.ReadLine());

//     double[,] array = new double[rows, columns];

//     for(int i = 0; i < rows; i++)
//         for(int j = 0; j < columns; j++)
//         {
//             array[i,j] = Math.Round(Convert.ToDouble(new Random().NextDouble()), 2);
//         }

//     return array;
// }

// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
// }


// double[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void ExistingArrayElement(int[,] array)
{
    Console.Write("Input first index: ");
    int first = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input second index: ");
    int second = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            if(first == i && second == j){
                Console.Write(array[i,j] + " ");
                return;
            }
        }
    }
    Console.Write("Числа с такими индексами в массиве нет");
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
ExistingArrayElement(array);






// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.