// Задача1: Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д)

int[] CreateRandomArray()
{
    Console.Write("Input a number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}


void ChangeArray(int[] array)
{
    for(int i = 0, j = array.Length -1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

// int[] myArray = CreateRandomArray();
// ShowArray(myArray);
// ChangeArray(myArray);
// ShowArray(myArray);


// Задача 2: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Правило, согласно которому необходимо решить задачу: каждая сторона треугольника д.б. строго меньше суммы двух других сторон!!!

// Задача 3: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементарного копирования.