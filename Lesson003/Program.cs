// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X не равно 0, Y не равно 0 и выдает номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(double x, double y)
{
    int num = 0;

    if(x > 0 && y > 0) num = 1;
    if(x < 0 && y > 0) num = 2;
    if(x < 0 && y < 0) num = 3;
    if(x > 0 && y < 0) num = 4;

    return num;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());

int quartNum = FindQuart(x,y);
Console.WriteLine($"The point A({x},{y}) is in {quartNum} quart");
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double FindDistans (double x, double x1, double y, double y1)
// {
//     double num = 0;
//     num = Math.Pow((x1 - x),2) + Math.Pow((y1 - y),2);
//     num = Math.Sqrt(num);
//     return num;
// }

// Console.Write("Введите координату x: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату x1: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// double y1 = Convert.ToDouble(Console.ReadLine());

// double findDistans = FindDistans(x, x1, y, y1);
// Console.WriteLine(findDistans);


// Задача 3. Напишите программу, которая принимает на вход число (N) и выдает ряд квадратов чисел от 1 до N.
/*
void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count,2);
        Console.Write(n + " ");
        count++;
    }
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);
*/
