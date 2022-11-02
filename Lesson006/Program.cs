// Задача1: Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д)

// int[] CreateRandomArray()
// {
//     Console.Write("Input a number of elements: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input min possible value: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input max possible value: ");
//     int max = Convert.ToInt32(Console.ReadLine());
    
//     int[] array = new int[size];

//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(min, max + 1);
//     return array;
// }


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

bool Exist(int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a){      // или это условие можно записать как  return a + b > c && a + c > b && b + c > a;
        return true;                               //  вместо условия if....return...else...
    }
    else return false;
}

// Console.Write("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число:");
// int num3 = Convert.ToInt32(Console.ReadLine());
// bool exist = Exist(num1, num2, num3);
// if(exist) Console.Write("Треугольник возможен");
// else Console.Write("Треугольник невозможен");

// Задача 3: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементарного копирования.

// int[] Copy(int[] array)
// {
//     int[] CopyArray = new int [array.Length];
//     for(int i = 0; i < array.Length; i++){
//         CopyArray[i] = array[i];
//     }
//     return CopyArray;
// }

// int[] array = CreateRandomArray();
// ShowArray(array);
// ShowArray(Copy(array));
// array[1] = 8;
// ShowArray(array);

// Задача 4: Не используя рекурсию, вывести первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

int[] Fibbo(int n, int a, int b){
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < n; i++) {
        array[i] = array[i - 2] + array[i - 1];
    }
    return array;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
int[] fib = Fibbo(size, first, second);
ShowArray(fib);
