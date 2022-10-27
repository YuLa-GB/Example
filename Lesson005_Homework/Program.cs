// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int EvenNumber(int[] array)
// {
//     int current = 0;

//     for(int i = 0; i < array.Length; i++){
//         if(array[i] %2 == 0){
//             current++;
//         }
//     }
//     return current;
// }

// Console.WriteLine("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);
// int result = EvenNumber(myArray);
// Console.WriteLine("Количество четных чисел в массиве " + result);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0,30);
//     return array;
// }

// int SumOddNumber(int[] array)
// {
//     int sum = 0;
    
//     for(int i = 0; i < array.Length; i++){
//         if(i %2 != 0)
//             sum += array[i];
//     }
//     return sum;
// }

// Console.WriteLine("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);
// int result = SumOddNumber(myArray);
// Console.WriteLine("сумма элементов, стоящих на нечетных позициях " + result);




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = Convert.ToDouble(new Random().Next());
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double DifferenceOfNumber(double[] array)
{
    double dif = 0;
    double maxNumber = array[0];
    double minNumber = array[0];

    for(int i = 0; i < array.Length; i++){ 
        if(array[i] > maxNumber) maxNumber = array[i];  
        if(array[i] < minNumber) minNumber = array[i]; 
    }
    dif = maxNumber - minNumber;
    return dif;
}

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(size);
ShowArray(myArray);
double result = DifferenceOfNumber(myArray);
Console.WriteLine("Разница между минимальным и максимальным элементом " + result);
