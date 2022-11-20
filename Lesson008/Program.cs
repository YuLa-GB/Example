// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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


void ChangeArray(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1))
        Console.WriteLine("Impossible to change!");
    else
        for(int i = 0; i < array.GetLength(0) - 1; i++)
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array [j,i] = temp;
            }
}

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// ChangeArray(myArray);
// Console.WriteLine(" ");
// Show2dArray(myArray);


// Задача 1. Необходимо задать двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива 
//                                                (а точнее нужно поменять местами строки, заданные пользователем).

void ReChange(int[,] array, int row1, int row2)
{
    if(row1 < array.GetLength(0) && row2 < array.GetLength(0))
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2,j] = temp;
        }
    else
        Console.WriteLine("Невозможно заменить!");
}

// int[,] myArray = CreateRandom2dArray();
// Show2dArray(myArray);
// Console.Write("Введите номер строки 1: ");
// int str1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер строки 2: ");
// int str2 = Convert.ToInt32(Console.ReadLine());
// ReChange(myArray, str1 - 1, str2 - 1);
// Show2dArray(myArray);



// Задача 2.Вариант 1: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
//           Вариант 2: не удалить, а занулить.

int[,] CutArray(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i, j] < array[minI, minJ])
            {
                minI = i;
                minJ = j;
            }

    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for(int i = 0, x = 0; i < array.GetLength(0); i++)
        if(i != minI) 
        {
            for(int j = 0, y = 0; j < array.GetLength(1); j++)
                if(j != minJ)
                {
                    newArray[x,y] = array[i,j];
                    y++;
                }
            x++;
        }
    return newArray;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[,] newArray = CutArray(myArray);
Console.WriteLine(" ");
Show2dArray(newArray);



// ДЗ уточнение: 