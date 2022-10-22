// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 1 вариант
// int DegreeNum(int a, int b){
//     int u = a;
//     for(int i=1; i < b; i++){
//         a *= u;
//     }
//     return a;
// }

// Console.WriteLine("Введите число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int c = DegreeNum(a,b);
// Console.WriteLine(c);

// 2 вариант
// double DegreeNum(double a, double b){
//     double s = Math.Pow(a,b);
//     return s;
// }

// Console.WriteLine("Введите число А: ");
// double a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число В: ");
// double b = Convert.ToInt32(Console.ReadLine());
// double u = DegreeNum(a,b);
// Console.WriteLine(u);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumNum(int n){
//     int sum = 0;
//     while(n > 0){
//         sum += n % 10;
//         n /= 10;
//     }
//     return sum;
// }
// Console.WriteLine("Add the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = SumNum(number);
// Console.WriteLine($"Number of digits is {a}");


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// int[] SetArray(int size){
//     int[] array = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,10);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// Console.WriteLine("Input number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = SetArray(size);
// ShowArray(myArray);


// Доп условие к массиву: создать метод, который генерирует массив, запрашивая каждый элемент

// int[] SetArray(int size){
//     int[] array = new int [size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Введите элемент: ");
//         int a = Convert.ToInt32(Console.ReadLine());
//         array[i] = a;
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// Console.WriteLine("Input number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = SetArray(size);
// ShowArray(myArray);