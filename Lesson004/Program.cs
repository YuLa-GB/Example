// Задача 1.  Напишите программу, которая на вход принимает число (А) и выдает сумму чисел от 1 до А.
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

// int Num(int n)
// {
//     int current = 0;
//     while(n > 0)
//     {
//         n /= 10;
//         current++;
//     }
//     return current;
// }
// Console.WriteLine("Add the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int a = Num(number);
// Console.WriteLine($"Number of digits is {a}");


// Задача 3 Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.


// Задача 4 Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке
/*
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
*/

// ДЗ дополнительно (+ к тому, что есть на сайте): создать метод, который генерирует массив, запрашивая каждый элемент



// Типы данных
// bool a = true;
// bool b = false;
// bool x;

// int c = 10;
// double d = 10.8;
// float e = 3.14F;

// char f = 'b';
// string g = "hello";

// = - оператор присваивание, возвращает то что справа
// ==   >=   <=   !=   >   < - операторы сравнения, возвращает bool
// && || - логические операторы, вовзращает bool
// + - / * - арифметические операторы, возвращает число


// a == b   c > d - a, b, c, d -  операнды

// int a = 10;
// int b = 4;
// bool s = a > b;
// Console.WriteLine(s == true);
// Console.WriteLine(s);

// int a = 10;
// int b = 5;
// int s = a;

// a = b;
// b = s;

// Console.WriteLine(a); // должно вывестись 5
// Console.WriteLine(b); // должно вывестись 10

// int[] test = {1, 2, 8, 5, 7};

// for (int i = 0; i < test.Length - 1; i++) {
//     bool s = test[i+1] > test[i];
//     if(s){
//         Console.WriteLine(true);
//     }    
// }

// int Test(int a, int b) {
//     int max;
//     if(a > b){
//        max = a; 
//     }
//     else{
//         max = b;
//     }
//     return max;
// }

// int s = Test(5,10);
// Console.WriteLine(s);

// // true && true -> true
// // true && false -> false

// // true || true -> true
// // true || false -> true

// bool TF(bool a, bool b){
//     return a && b;
// }



