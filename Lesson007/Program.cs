// Задача 1 на организацию двух базовых методов: Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

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

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);


// Задача 2. задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:Aij=i+j. 
// Выведите полученный массив на экран.


int[,] CreateIndex2dArray(int oneSize, int twoSize)
{
    int[,] array = new int[oneSize, twoSize];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            array[i,j] = i + j;

    return array;
}

// Show2dArray(CreateIndex2dArray(5,10));


// Задача 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.

void Square2dArrayEven(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2)
        for(int j = 0; j < array.GetLength(1); j += 2)
            array[i,j] *= array[i,j];
}

// int[,] array = CreateRandom2dArray();
// Show2dArray(array);
// Square2dArrayEven(array);
// Console.WriteLine();
// Show2dArray(array);


// Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

int SumElementMainDiagonal2dArray(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sum += array[i,i];
    }
    return sum;
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
Console.WriteLine(SumElementMainDiagonal2dArray(array));

// по ДЗ: задача 47 аналогичная задача для одномерного массива, вещественные числа генерируются с помощью метода Nextdouble (без аргументов)
// задача 50: позиция - это индекс (i,j). - метод типа void
//                                        - метод типа int (внутри метода, если индексы будут несуществующими,
//                                                     можем вывести Console.. и указать, что такого элемента нет)
//                                        - метод типа string (фраза, что элемента нет)
// задача 52: если сначала хотим пойти со столбцов, а не со строк, то нужно сделать внешний цикл, который отвечает за столбцы(j),
//             а внутренний - за строки(i). Возвращать будем одномерный массив.