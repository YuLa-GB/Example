// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// string CheckPalindrom(string a)
// {
    
//     if(a[0] == a[4] && a[1] == a[3])  return "да";
//     else return "нет";
// }

// Console.Write("Введите пятизначное число: ");
// string number = Console.ReadLine();
// CheckPalindrom(number);
// Console.WriteLine(CheckPalindrom(number));

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistans (double x, double x1, double y, double y1, double z, double z1)
// {
//     double num = 0;
//     num = Math.Pow((x1 - x),2) + Math.Pow((y1 - y),2) + Math.Pow((z1 - z),2);
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
// Console.Write("Введите координату z: ");
// double z = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// double z1 = Convert.ToDouble(Console.ReadLine());

// double findDistans = FindDistans(x, x1, y, y1, z, z1);
// Console.WriteLine(findDistans);

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void ShowNumbers(int num)
// {
//     int count = 1;
//     while(count <= num)
//     {
//         double n = Math.Pow(count,3);
//         Console.Write(n + " ");
//         count++;
//     }
// }

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(number);